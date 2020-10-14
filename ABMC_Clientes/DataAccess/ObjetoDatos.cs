using System.Data;

namespace ABMC_Clientes.DataAccess {
	public abstract class ObjetoDatos<T> {
		string table = "";
		string[] fields;
		string primaryKey = "";

		string FieldSQL => string.Join(", ", fields);

		public T[] Recuperar() {
			Datos datos = new Datos();
			DataTable tabla = datos.ConsultarTabla(FieldSQL, table);

			if (tabla.Rows.Count <= 0)
				return null;

			return BatchConvertir(tabla);
		}

		public T[] BatchConvertir(DataTable input) {
			T[] ret = new T[input.Rows.Count];

			for (int i = 0; i < ret.Length; i++) {
				ret[i] = Convertir(input.Rows[i]);
			}

			return ret;
		}

		public void Eliminar(int keyValue) {
			Datos datos = new Datos();
			string eliminacion = "UPDATE " + table + " SET borrado = 1 WHERE " + primaryKey + " = " + keyValue;

			datos.Actualizar(eliminacion);
		}

		public void Insertar(T objeto) {
			Datos datos = new Datos();
			string insercion = "INSERT INTO " + table + " (" + FieldSQL + ") VALUES (" +
								GetValuesSQL(objeto) + ")";
			datos.Actualizar(insercion);
		}

		protected abstract T Convertir(DataRow input);
		protected abstract string GetValuesSQL(T input);
	}
}
