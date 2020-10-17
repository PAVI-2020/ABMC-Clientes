using ABMC_Clientes.Clases;
using System.Data;

namespace ABMC_Clientes.DataAccess {
	public class UsuarioDatos : ObjetoDatos<Usuario> {
		public Usuario GetUsuario(string username) {
			return RecuperarCondicion("usuario = '" + username + "'")[0];
		}
	}
}
