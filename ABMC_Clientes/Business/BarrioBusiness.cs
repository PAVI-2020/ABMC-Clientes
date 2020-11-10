using ABMC_Clientes.Clases;
using ABMC_Clientes.DataAccess;

namespace ABMC_Clientes.Business {
	public class BarrioBusiness {
		public Barrio[] ConsultarBarrios() {
			BarrioDatos barrioDatos = new BarrioDatos();
			return barrioDatos.Recuperar("Barrios.borrado = 0");
		}

		public Barrio[] ConsultarBarriosFiltrado(int id_barrio = -1, string nombre = "") {
			BarrioDatos barrioDatos = new BarrioDatos();
			return barrioDatos.RecuperarFiltrado(id_barrio, nombre);
		}

		public void Eliminar(int id_barrio) {
			BarrioDatos barrioDatos = new BarrioDatos();
			barrioDatos.Eliminar(id_barrio);
		}

		public void Insertar(Barrio barrio) {
			BarrioDatos barrioDatos = new BarrioDatos();
			barrioDatos.Insertar(barrio);
		}

		public void ActualizarBarrio(Barrio barrio) {
			BarrioDatos barrioDatos = new BarrioDatos();
			barrioDatos.Actualizar(barrio);
		}
	}
}
