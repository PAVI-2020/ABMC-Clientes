using ABMC_Clientes.Clases;
using System.Data;

namespace ABMC_Clientes.DataAccess {
	public class UsuarioDatos : ObjetoDatos<Usuario> {
		public Usuario GetUsuario(string username) {
			return RecuperarCondicion("usuario = '" + username + "'")[0];
		}

		protected override Usuario Convertir(DataRow input) {
			Usuario u = new Usuario {
				IdUsuario = int.Parse(input["id_usuario"].ToString()),
				N_usuario = input["usuario"].ToString(),
				Mail = input["email"].ToString(),
				Estado = input["estado"].ToString(),
				Password = input["password"].ToString()
			};

			return u;
		}
	}
}
