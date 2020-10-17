using ABMC_Clientes.Clases;
using ABMC_Clientes.DataAccess;

namespace ABMC_Clientes.Business {
    public class ContactosBusiness {
		public Contacto[] Recuperar() {
			ContactoDatos contactoDatos = new ContactoDatos();
			return contactoDatos.Recuperar();
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
	}
}
