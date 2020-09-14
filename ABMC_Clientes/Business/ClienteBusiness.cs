﻿using ABMC_Clientes.Clases;
using ABMC_Clientes.DataAccess;
using System;

namespace ABMC_Clientes.Business {
	public class ClienteBusiness {
		public Cliente[] ConsultarClientes() {
			return ClienteDatos.RecuperarCliente();
		}

		public Cliente[] ConsultarClientesFiltrado(int id = -1, string cuit = "", string razonSocial = "", string calle = "", string numero = "", DateTime fechaAlta = default(DateTime), int idBarrio = -1, int idContacto = -1) {
			return ClienteDatos.RecuperarClienteFiltrado(id, cuit, razonSocial, calle, numero, fechaAlta, idBarrio, idContacto);
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
