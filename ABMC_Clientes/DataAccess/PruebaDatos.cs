using ABMC_Clientes.Clases;
using System.Data;
using System.Linq;

namespace ABMC_Clientes.DataAccess {
	public class PruebaDatos {
		public static Prueba[] RecuperarPruebas() {
			string consultaSQL = "P.id_plan_prueba, P.id_proyecto, P.nombre, P.id_responsable, P.descripcion, P.borrado";
			string tablasConsulta = "PlanesDePrueba P";

			Datos datos = new Datos();
			DataTable tablas = datos.ConsultarTabla(consultaSQL, tablasConsulta, "P.borrado = 0");

			if (tablas.Rows.Count <= 0)
				return null;

			return ConvertirPruebas(tablas);
		}

		public static Prueba[] RecuperarPruebasFiltrado(int id_plan_prueba=-1, int id_proyecto=-1, string nombre="", int id_responsable=-1, string descripcion="") {
			string consultaSQL =  "P.id_plan_prueba, P.id_proyecto, P.nombre, P.id_responsable, P.descripcion, P.borrado";
			string tablasConsulta = "PlanesDePrueba P";
			string[] condiciones = {
				((id_plan_prueba != -1) ? "P.id_plan_prueba="   + id_plan_prueba.ToString()     : ""),
				((id_proyecto != -1)    ? "P.id_proyecto='"     + id_proyecto			+ "'"   : ""),
				((nombre != "")         ? "P.nombre='"			+ nombre				+ "'"   : ""),
				((id_responsable != -1) ? "P.id_responsable='"  + id_responsable		+ "'"   : ""),
				((descripcion!= "")     ? "P.descripcion='"     + descripcion			+ "'"   : ""),
				"P.borrado=0"
			};

			condiciones = condiciones.Where(x => !string.IsNullOrEmpty(x)).ToArray();

			string condicion = string.Join(" AND ", condiciones);

			Datos datos = new Datos();
			DataTable tablas = datos.ConsultarTabla(consultaSQL, tablasConsulta, condicion);

			if (tablas.Rows.Count <= 0)
				return null;

			return ConvertirPruebas(tablas);
		}

		public static Prueba ConvertirPrueba(DataRow input) {
			Prueba p = new Prueba(
				id_plan_prueba: (int)input["id_plan_prueba"],
				id_proyecto:	(int)input["id_proyecto"],
				nombre:			(string)input["nombre"],
				id_responsable:	(int)input["id_responsable"],
				descripcion:	(string)input["descripcion"],
				borrado:		(bool)input["borrado"]
			);

			return p;
		}

		public static Prueba[] ConvertirPruebas(DataTable input) {
			Prueba[] ret = new Prueba[input.Rows.Count];

			for (int i = 0; i < ret.Length; i++) {
				ret[i] = ConvertirPrueba(input.Rows[i]);
			}

			return ret;
		}
		
		public static void EliminarPrueba(int id_plan_prueba) {
			Datos datos = new Datos();
			string eliminacion = "UPDATE PlanesDePrueba Set Borrado = 1 WHERE id_plan_prueba = " + id_plan_prueba;

			datos.Actualizar(eliminacion);
		}

		public static void InsertarPrueba(Prueba prueba) {
			Datos datos = new Datos();
			string insercion = "INSERT INTO PlanesDePrueba (id_proyecto, nombre, id_responsable, descripcion, borrado) VALUES ('" +
								prueba.Id_proyecto.ToString() + "', '" +
								prueba.Nombre + "', '" +
								prueba.Id_responsable.ToString() + "', '" +
								prueba.Descripcion + "'" +
								", 0)";
			datos.Actualizar(insercion);
		}

		public static void ActualizarPrueba(Prueba prueba) {
			Datos datos = new Datos();
			string actualizacion = "UPDATE PlanesDePrueba SET id_proyecto= '" + prueba.Id_proyecto.ToString() +
				"', nombre= '" + prueba.Nombre +
				"', id_responsable= '" + prueba.Id_responsable.ToString() +
				"', descripcion= '" + prueba.Descripcion +
				"' WHERE id_plan_prueba=" + prueba.Id_plan_prueba;

			datos.Actualizar(actualizacion);
		}
	}

}
