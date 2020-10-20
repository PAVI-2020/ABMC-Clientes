using ABMC_Clientes.Clases;
using System.Data;

namespace ABMC_Clientes.DataAccess {
	public class UsuarioDatos : ObjetoDatos<Usuario> {
		public Usuario GetUsuario(string username) {
			Usuario[] matches = Recuperar("usuario = '" + username + "'");
			if (matches.Length != 1)
				return null;
			return matches[0];
		}
	}
}
