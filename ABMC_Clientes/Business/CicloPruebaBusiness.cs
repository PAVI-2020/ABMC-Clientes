using ABMC_Clientes.Clases;
using ABMC_Clientes.DataAccess;

namespace ABMC_Clientes.Business {
	class CicloPruebaBusiness {
		public CiclosPrueba[] ConsultarCiclosPrueba() {
			return CicloPruebaDatos.RecuperarCicloPrueba();
		}

		public void Insertar(CiclosPrueba factura) {
			CicloPruebaDatos.InsertarCiclosPrueba(factura);
		}

		public void CrearCiclo(CiclosPrueba factura) {
			CicloPruebaDatos.InsertarCiclosPrueba(factura);
		}
	}
}
