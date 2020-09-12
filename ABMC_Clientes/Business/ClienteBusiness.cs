using System;
using ABMC_Clientes.Clases;
using ABMC_Clientes.DataAccess;

namespace ABMC_Clientes.Business {
	public class ClienteBusiness {
		public Cliente[] ConsultarClientes() {
			return ClienteDatos.RecuperarCliente();
		}

		public void Eliminar(Cliente c)
		{
			ClienteDatos oClienteDatos = new ClienteDatos();
			oClienteDatos.Eliminar(c);
		}

		public void Insertar(Cliente cliente)
        {
			

			ClienteDatos oClienteDatos = new ClienteDatos();
			oClienteDatos.Insertar(cliente);

		}

		public void ActualizarUsuario(Cliente cliente)
		{
			ClienteDatos oClienteDatos = new ClienteDatos();
			oClienteDatos.Actualizar(cliente);
		}

	}
}
