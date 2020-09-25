using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMC_Clientes.Clases {
	public class Usuario {
		private int idUsuario;
		private string n_usuario;
		private string password;
		private string mail;
		private string estado;
		private int idPerfil;

		public int IdUsuario { get => idUsuario; set => idUsuario = value; }
		public string N_usuario { get => n_usuario; set => n_usuario = value; }
		public string Password { get => password; set => password = value; }
		public string Mail { get => mail; set => mail = value; }
		public int IdPerfil { get => idPerfil; set => idPerfil = value; }
		public string Estado { get => estado; set => estado = value; }
	}
}
