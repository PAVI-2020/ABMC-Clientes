using ABMC_Clientes.Clases;
using System.Data;
using System.Linq;

namespace ABMC_Clientes.DataAccess {
	public class BarrioDatos {
		public static Barrio[] RecuperarBarrio() {
			string consultaSQL = "B.id_barrio, B.nombre, B.borrado";
			string tablasConsulta = "Barrios B";

			Datos datos = new Datos();
			DataTable tablas = datos.ConsultarTabla(consultaSQL, tablasConsulta, "B.borrado = 0");

			if (tablas.Rows.Count <= 0)
				return null;

			return ConvertirBarrios(tablas);
		}

		public static Barrio[] RecuperarBarrioFiltrado(int id = -1, string nombre = "") {
			string consultaSQL =  "B.id_barrio, B.nombre, B.borrado"; 
			string tablasConsulta = "Barrios B";
			string[] condiciones = {
				((id != -1)             ? "B.id_barrio="   + id.ToString()                 : ""),
				((nombre != "")         ? "B.nombre='"     + nombre                + "'"   : ""),
				"B.borrado=0"
			};

			condiciones = condiciones.Where(x => !string.IsNullOrEmpty(x)).ToArray();

			string condicion = string.Join(" AND ", condiciones);

			Datos datos = new Datos();
			DataTable tablas = datos.ConsultarTabla(consultaSQL, tablasConsulta, condicion);

			if (tablas.Rows.Count <= 0)
				return null;

			return ConvertirBarrios(tablas);
		}

		public static Barrio ConvertirBarrio(DataRow input) {
			Barrio b = new Barrio(
				id_barrio:      (int)input["id_barrio"],
				nombre:         (string)input["nombre"],
				borrado:        (bool)input["borrado"]
			);

			return b;
		}

		public static Barrio[] ConvertirBarrios(DataTable input) {
			Barrio[] ret = new Barrio[input.Rows.Count];

			for (int i = 0; i < ret.Length; i++) {
				ret[i] = ConvertirBarrio(input.Rows[i]);
			}

			return ret;
		}
		
		public static void EliminarBarrio(int id_barrio) {
			Datos datos = new Datos();
			string eliminacion = "UPDATE Barrios Set Borrado = 1 WHERE id_barrio = " + id_barrio;

			datos.Actualizar(eliminacion);
		}

		public static void InsertarBarrio(Barrio barrio) {
			Datos datos = new Datos();
			string insercion = "INSERT INTO Barrios (nombre, borrado) VALUES ('" +
								barrio.Nombre.ToString() + "', 0)";
			datos.Actualizar(insercion);
		}

		public static void ActualizarBarrio(Barrio barrio) {
			Datos datos = new Datos();
			string actualizacion = "UPDATE Barrios SET nombre= '" + barrio.Nombre.ToString() +"' WHERE id_barrio=" + barrio.Id_barrio;

			datos.Actualizar(actualizacion);
		}
	}

}
