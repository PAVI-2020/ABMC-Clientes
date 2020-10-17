using ABMC_Clientes.Clases;
using ABMC_Clientes.DataAccess;

namespace ABMC_Clientes.Business {
	public class CicloPruebaDetalleBusiness {
		public CiclosPruebaDetalle[] ConsultarCiclosPruebaDetalle() {
			CicloPruebaDetalleDatos cicloPruebaDetalleDatos = new CicloPruebaDetalleDatos();
			return cicloPruebaDetalleDatos.Recuperar();
		}
	}
}
