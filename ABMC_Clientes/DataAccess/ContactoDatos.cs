using System.Data;
using ABMC_Clientes.Clases;

namespace ABMC_Clientes.DataAccess {
    public class ContactoDatos : ObjetoDatos<Contacto> {
        protected override Contacto Convertir(DataRow input) {
            Contacto c = new Contacto(
                id_contacto: (int)input["id_contacto"],
                nombre: (string)input["nombre"],
                apellido: (string)input["apellido"],
                email: (string)input["email"],
                telefono: (string)input["telefono"],
                borrado: (bool)input["borrado"]
            );

            return c;
        }
    }
}
