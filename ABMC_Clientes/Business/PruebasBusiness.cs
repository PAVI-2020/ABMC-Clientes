using ABMC_Clientes.Clases;
using ABMC_Clientes.DataAccess;

namespace ABMC_Clientes.Business {
	public class PruebasBusiness {
		public Prueba[] ConsultarPruebas() {
			PruebaDatos pruebaDatos = new PruebaDatos();
			return pruebaDatos.Recuperar("Pruebas.borrado = 0");
		}

		public Prueba[] ConsultarPruebasFiltrado(int id_plan_prueba = -1, int id_proyecto = -1, string nombre = "", int id_responsable = -1, string descripcion = "") {
			PruebaDatos pruebaDatos = new PruebaDatos();
			return pruebaDatos.RecuperarPruebasFiltrado(id_plan_prueba, id_proyecto, nombre, id_responsable, descripcion);
		}

		public void Eliminar(int id_prueba) {
			PruebaDatos pruebaDatos = new PruebaDatos();
			pruebaDatos.Eliminar(id_prueba);
		}

		public void Insertar(Prueba prueba) {
			PruebaDatos pruebaDatos = new PruebaDatos();
			pruebaDatos.Insertar(prueba);
		}

		public void ActualizarPrueba(Prueba prueba) {
			//PruebaDatos.ActualizarPrueba(prueba);
		}
	}
}
