using ABMC_Clientes.Clases;
using ABMC_Clientes.DataAccess;

namespace ABMC_Clientes.Business {
	public class PruebasBusiness {
		public Prueba[] ConsultarPruebas() {
			return PruebaDatos.RecuperarPruebas();
		}

		public Prueba[] ConsultarPruebasFiltrado(int id_plan_prueba = -1, int id_proyecto = -1, string nombre = "", int id_responsable = -1, string descripcion = "") {
			return PruebaDatos.RecuperarPruebasFiltrado(id_plan_prueba, id_proyecto, nombre, id_responsable, descripcion);
		}

		public void Eliminar(int id_prueba) {
			PruebaDatos.EliminarPrueba(id_prueba);
		}

		public void Insertar(Prueba prueba) {
			PruebaDatos.InsertarPrueba(prueba);
		}

		public void ActualizarPrueba(Prueba prueba) {
			PruebaDatos.ActualizarPrueba(prueba);
		}
	}
}
