using ABMC_Clientes.Clases;

namespace ABMC_Clientes.Business {
	class CicloPruebaBusiness {
		public CiclosPrueba[] ConsultarCiclosPrueba() {
			return CiclosPruebaDatos.RecuperarFactura();
		}

		public void Insertar(CiclosPrueba factura) {
			CiclosPruebaDatos.InsertarFactura(factura);
		}

		public void CrearCiclo(CiclosPrueba factura) {
			CiclosPruebaDatos.InsertarFactura(factura);
		}
	}
}
