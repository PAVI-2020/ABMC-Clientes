using ABMC_Clientes.Clases;
using System.Data;
using System.Linq;

namespace ABMC_Clientes.DataAccess {
	public class PruebaDatos : ObjetoDatos<Prueba> {
		protected override Prueba Convertir(DataRow input) {
			Prueba p = new Prueba(
				id_plan_prueba: (int)input["id_plan_prueba"],
				id_proyecto: (int)input["id_proyecto"],
				nombre: (string)input["nombre"],
				id_responsable: (int)input["id_responsable"],
				descripcion: (string)input["descripcion"],
				borrado: (bool)input["borrado"]
			);

			return p;
		}

		public Prueba[] RecuperarPruebasFiltrado(int id_plan_prueba = -1, int id_proyecto = -1, string nombre = "", int id_responsable = -1, string descripcion = "") {
			string[] condiciones = {
				((id_plan_prueba != -1) ? "id_plan_prueba="   + id_plan_prueba.ToString()     : ""),
				((id_proyecto != -1)    ? "id_proyecto='"     + id_proyecto           + "'"   : ""),
				((nombre != "")         ? "nombre='"          + nombre                + "'"   : ""),
				((id_responsable != -1) ? "id_responsable='"  + id_responsable        + "'"   : ""),
				((descripcion!= "")     ? "descripcion='"     + descripcion           + "'"   : ""),
				"borrado=0"
			};

			condiciones = condiciones.Where(x => !string.IsNullOrEmpty(x)).ToArray();

			return RecuperarCondicion(condiciones);
		}
	}
}
