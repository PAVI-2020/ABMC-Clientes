using ABMC_Clientes.Clases;
using System.Data;
using System.Linq;

namespace ABMC_Clientes.DataAccess {
	public class PruebaDatos : ObjetoDatos<Prueba> {
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
