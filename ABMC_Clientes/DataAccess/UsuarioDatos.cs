using ABMC_Clientes.Clases;
using System.Data;

namespace ABMC_Clientes.DataAccess {
	public class UsuarioDatos : ObjetoDatos<Usuario> {
		public UsuarioDatos() {
			TABLE = "Usuarios";
			FIELDS = new string[] { "id_usuario", "usuario", "password", "email", "estado", "borrado" };
			PRIMARYKEY = "id_usuario";
		}

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

		protected override string GetValuesSQL(Usuario input) {
			string[] values = {
				input.IdUsuario.ToString(),
				input.N_usuario,
				input.Password,
				input.Mail,
				input.Estado,
				input.Borrado.ToString()
			};

			return string.Join(", ", values);
		}
	}
}
