using ABMC_Clientes.Clases;
using ABMC_Clientes.DataAccess;

namespace ABMC_Clientes.Business {
	public class DetalleFacturaBusiness {
		public DetalleFactura[] ConsultarFacturas() {
			return DetalleFacturaDatos.RecuperarDFactura();
		}
	}
}
