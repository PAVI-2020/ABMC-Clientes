using ABMC_Clientes.Clases;
using ABMC_Clientes.DataAccess;

namespace ABMC_Clientes.Business {
	class CicloPruebaBusiness {
		public CiclosPrueba[] ConsultarCiclosPrueba() {
			CicloPruebaDatos cicloPruebaDatos = new CicloPruebaDatos();
			return cicloPruebaDatos.Recuperar();
		}

		public void Insertar(CiclosPrueba factura) {
			CicloPruebaDatos cicloPruebaDatos = new CicloPruebaDatos();
			cicloPruebaDatos.Insertar(factura);
		}

		public void CrearCiclo(CiclosPrueba factura) {
			CicloPruebaDatos cicloPruebaDatos = new CicloPruebaDatos();
			cicloPruebaDatos.Insertar(factura);
		}
	}
}
