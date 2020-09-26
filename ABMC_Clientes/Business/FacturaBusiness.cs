using ABMC_Clientes.Clases;
using ABMC_Clientes.DataAccess;

namespace ABMC_Clientes.Business {

	public class FacturaBusiness {
		public Factura[] ConsultarFacturas() {
			return FacturaDatos.RecuperarFactura();
		}

		public void Insertar(Factura factura) {
			FacturaDatos.InsertarFactura(factura);
		}

		public void CrearFactura(Factura factura)
        {
			FacturaDatos.InsertarFactura(factura);
        }
	}
}
