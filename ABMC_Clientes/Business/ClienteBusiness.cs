using ABMC_Clientes.Clases;
using ABMC_Clientes.DataAccess;

namespace ABMC_Clientes.Business {
	public class ClienteBusiness {
		public Cliente[] ConsultarClientes() {
			return ClienteDatos.RecuperarCliente();
		}
	}
}
