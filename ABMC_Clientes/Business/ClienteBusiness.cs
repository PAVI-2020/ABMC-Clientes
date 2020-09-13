using ABMC_Clientes.Clases;
using ABMC_Clientes.DataAccess;

namespace ABMC_Clientes.Business {
	public class ClienteBusiness {
		public Cliente[] ConsultarClientes() {
			return ClienteDatos.RecuperarCliente();
		}

		public void Eliminar(int id) {
			ClienteDatos.EliminarCliente(id);
		}

		public void Insertar(Cliente cliente) {
			ClienteDatos.InsertarCliente(cliente);
		}

		public void ActualizarUsuario(Cliente cliente) {
			ClienteDatos.ActualizarCliente(cliente);
		}
	}
}
