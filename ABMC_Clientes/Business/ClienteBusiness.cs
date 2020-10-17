using ABMC_Clientes.Clases;
using ABMC_Clientes.DataAccess;
using System;

namespace ABMC_Clientes.Business {
	public class ClienteBusiness {
		public Cliente[] ConsultarClientes() {
			ClienteDatos clienteDatos = new ClienteDatos();
			return clienteDatos.Recuperar();
		}

		public Cliente[] ConsultarClientesFiltrado(int id = -1, string cuit = "", string razonSocial = "", string calle = "", string numero = "", DateTime fechaAlta = default(DateTime), int idBarrio = -1, int idContacto = -1) {
			ClienteDatos clienteDatos = new ClienteDatos();
			return clienteDatos.RecuperarClienteFiltrado(id, cuit, razonSocial, calle, numero, fechaAlta, idBarrio, idContacto);
		}

		public void Eliminar(int id) {
			ClienteDatos clienteDatos = new ClienteDatos();
			clienteDatos.Eliminar(id);
		}

		public void Insertar(Cliente cliente) {
			ClienteDatos clienteDatos = new ClienteDatos();
			clienteDatos.Insertar(cliente);
		}

		public void ActualizarUsuario(Cliente cliente) {
			ClienteDatos clienteDatos = new ClienteDatos();
			clienteDatos.Actualizar(cliente);
		}
	}
}
