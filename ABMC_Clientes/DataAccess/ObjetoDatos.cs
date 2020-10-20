using ABMC_Clientes.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace ABMC_Clientes.DataAccess {
	public abstract class ObjetoDatos<T> where T : new() {
		protected string table;
		protected string[] fields;
		protected string primaryKey; // Estos valores deben ser seteados en el constructor de los derivados

		string FieldSQL => string.Join(", ", fields);

		public ObjetoDatos() {
			table = typeof(T).GetCustomAttribute<SQLTableAttribute>().table;
			List<string> fieldNames = new List<string>();

			foreach (PropertyInfo p in typeof(T).GetProperties())
				if (p.GetCustomAttribute<SQLFieldAttribute>() != null)
					fieldNames.Add(p.GetCustomAttribute<SQLFieldAttribute>().sqlName);

			fields = fieldNames.ToArray();
		}

		public T[] Recuperar(params string[] condiciones) {
			Datos datos = new Datos();
			DataTable tabla = datos.ConsultarTabla(GetSelectSQL(), GetSelectTable(), condiciones);

			if (tabla.Rows.Count <= 0)
				return new T[0];

			return BatchConvertir(tabla);

			string GetSelectSQL() {
				List<string> fields = new List<string>();
				foreach (PropertyInfo p in typeof(T).GetProperties())
					if (p.GetCustomAttribute<SQLFieldAttribute>() != null) {
						SQLFieldAttribute attr = p.GetCustomAttribute<SQLFieldAttribute>();
						fields.Add(table + "." + attr.sqlName);
					} else if (p.GetCustomAttribute<SQLSecondaryFieldAttribute>() != null) {
						SQLSecondaryFieldAttribute attr = p.GetCustomAttribute<SQLSecondaryFieldAttribute>();
						fields.Add(attr.table + " as '" + attr.sqlName + "'");
					}

				return string.Join(", ", fields);
			}

			string GetSelectTable() {
				string ret = table;
				foreach (SQLSecondaryTableAttribute attr in typeof(T).GetCustomAttributes<SQLSecondaryTableAttribute>()) {
					ret += " JOIN " + attr.table + " ON (" + attr.joinCondition + ")";
				}

				return ret;
			}
		}

		public T[] BatchConvertir(DataTable input) {
			T[] ret = new T[input.Rows.Count];

			for (int i = 0; i < ret.Length; i++) {
				ret[i] = Convertir(input.Rows[i]);
			}

			return ret;
		}

		protected T Convertir(DataRow input) {
			T ret = new T();
			foreach (PropertyInfo p in typeof(T).GetProperties())
				if (p.GetCustomAttribute<SQLFieldAttribute>() != null)
					p.SetValue(ret, input[p.GetCustomAttribute<SQLFieldAttribute>().sqlName]);
				else if (p.GetCustomAttribute<SQLSecondaryFieldAttribute>() != null)
					p.SetValue(ret, input[p.GetCustomAttribute<SQLSecondaryFieldAttribute>().sqlName]);

			return ret;
		}

		public void Eliminar(params object[] keyValues) {
			Datos datos = new Datos();
			string eliminacion = "UPDATE " + table + " SET borrado = 1 WHERE " + GetPrimaryKeyCondition(keyValues);

			datos.Actualizar(eliminacion);
		}

		public void Insertar(T objeto) {
			Datos datos = new Datos();
			string insercion = "INSERT INTO " + table + " (" + FieldSQL + ") VALUES (" + GetValuesSQL(objeto) + ")";
			datos.Actualizar(insercion);
		}

		public void Actualizar(T objeto) {
			Datos datos = new Datos();
			string actualizacion = "UPDATE " + table + " SET " + GetUpdateValuesSQL(objeto) + " WHERE " + GetPrimaryKeyCondition(objeto);
			datos.Actualizar(actualizacion);
		}

		protected string GetValuesSQL(T input) {
			List<string> fields = new List<string>();
			foreach (PropertyInfo p in typeof(T).GetProperties())
				if (p.GetCustomAttribute<SQLFieldAttribute>() != null)
					fields.Add(p.GetValue(input).ToString());

			return string.Join(", ", fields);
		}

		protected string GetUpdateValuesSQL(T input) {
			List<string> fields = new List<string>();
			foreach (PropertyInfo p in typeof(T).GetProperties())
				if (p.GetCustomAttribute<SQLFieldAttribute>() != null && p.GetCustomAttribute<SQLPrimaryKey>() == null)
					fields.Add(p.GetCustomAttribute<SQLFieldAttribute>().sqlName + " = '" + GetValueForSQL(p.GetValue(input)) + "'");

			return string.Join(", ", fields);
		}

		protected string GetPrimaryKeyCondition(T input) {
			List<string> fields = new List<string>();
			foreach (PropertyInfo p in typeof(T).GetProperties())
				if (p.GetCustomAttribute<SQLPrimaryKey>() != null)
					fields.Add(p.GetCustomAttribute<SQLFieldAttribute>().sqlName + " = '" + p.GetValue(input).ToString() + "'");

			return string.Join(", ", fields);
		}

		protected string GetPrimaryKeyCondition(params object[] keyValues) {
			List<string> fields = new List<string>();
			int i = 0;
			foreach (PropertyInfo p in typeof(T).GetProperties())
				if (p.PropertyType.GetCustomAttribute<SQLPrimaryKey>() != null) {
					fields.Add(p.PropertyType.GetCustomAttribute<SQLFieldAttribute>().sqlName + " = '" + keyValues[i].ToString() + "'");
					i++;
				}

			return string.Join(", ", fields);
		}

		protected string GetValueForSQL(object from) {
			if (from.GetType() == typeof(DateTime))
				return ((DateTime)from).ToString("yyyy-MM-dd hh:mm:ss");
			else if (from.GetType() == typeof(bool))
				return ((bool)from) ? "1" : "0";

			return from.ToString();
		}
	}
}
