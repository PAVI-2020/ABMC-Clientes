using System.Data;

namespace ABMC_Clientes.DataAccess {
	public abstract class ObjetoDatos<T> {
		protected string TABLE;
		protected string[] FIELDS;
		protected string PRIMARYKEY; // Estos valores deben ser seteados en el constructor de los derivados

		string FieldSQL => string.Join(", ", FIELDS);

		public T[] Recuperar() {
			Datos datos = new Datos();
			DataTable tabla = datos.ConsultarTabla(FieldSQL, TABLE);

			if (tabla.Rows.Count <= 0)
				return new T[0];

			return BatchConvertir(tabla);
		}

		public T[] RecuperarCondicion(params string[] condiciones) {
			Datos datos = new Datos();
			DataTable tabla = datos.ConsultarTabla(FieldSQL, TABLE, condiciones);

			if (tabla.Rows.Count <= 0)
				return new T[0];

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
			string eliminacion = "UPDATE " + TABLE + " SET borrado = 1 WHERE " + PRIMARYKEY + " = " + keyValue;

			datos.Actualizar(eliminacion);
		}

		public void Insertar(T objeto) {
			Datos datos = new Datos();
			string insercion = "INSERT INTO " + TABLE + " (" + FieldSQL + ") VALUES (" +
								GetValuesSQL(objeto) + ")";
			datos.Actualizar(insercion);
		}

		protected abstract T Convertir(DataRow input);
		protected abstract string GetValuesSQL(T input);
	}
}
