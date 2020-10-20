using ABMC_Clientes.Clases;
using ABMC_Clientes.DataAccess;

namespace ABMC_Clientes.Business {
    public class ProyectoBusiness {
		public Proyecto[] ConsultarProyectos() {
			ProyectoDatos datos = new ProyectoDatos();
			return datos.Recuperar("Proyectos.borrado = 0");
		}
	}
}

