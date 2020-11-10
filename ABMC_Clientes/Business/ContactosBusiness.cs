using ABMC_Clientes.Clases;
using ABMC_Clientes.DataAccess;

namespace ABMC_Clientes.Business {
    public class ContactosBusiness {
		public Contacto[] Recuperar() {
			ContactoDatos contactoDatos = new ContactoDatos();
			return contactoDatos.Recuperar("Contactos.borrado = 0");
		}

		public void Eliminar(int id_Contacto) {
			ContactoDatos contactoDatos = new ContactoDatos();
			contactoDatos.Eliminar(id_Contacto);
		}

		public void Insertar(Contacto Contacto) {
			ContactoDatos contactoDatos = new ContactoDatos();
			contactoDatos.Insertar(Contacto);
		}

		public void Actualizar(Contacto Contacto) {
			ContactoDatos contactoDatos = new ContactoDatos();
			contactoDatos.Actualizar(Contacto);
		}

		public Contacto[] RecuperarFiltrado(int id_contacto = -1, string nombre = "", string apellido = "", string email = "", string telefono = "") {
			ContactoDatos contactoDatos = new ContactoDatos();
			return contactoDatos.RecuperarFiltrado(id_contacto, nombre, apellido, email, telefono);
		}
	}
}
