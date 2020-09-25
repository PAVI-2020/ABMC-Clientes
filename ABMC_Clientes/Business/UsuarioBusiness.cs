using ABMC_Clientes.Clases;
using ABMC_Clientes.DataAccess;

namespace ABMC_Clientes.Business {
	public class UsuarioBusiness {

		public Usuario ValidarUsuario(string nombre, string pass) {
			UsuarioDatos usuarioDatos = new UsuarioDatos();
			Usuario ret = usuarioDatos.GetUsuario(nombre);

			return (ret != null && ret.Password == pass) ? ret : null;
		}
	}
}
