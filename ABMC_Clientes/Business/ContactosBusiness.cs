using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABMC_Clientes.Clases;
using ABMC_Clientes.DataAccess;

namespace ABMC_Clientes.Business
{
    class ContactosBusiness
    {
        public DataTable mostrarTodos()
        {
            ContactoDatos cDatos = new ContactoDatos();
            return cDatos.mostrarTodos();
        }

        public void Agregar(Contacto c)
        {
            ContactoDatos cDatos = new ContactoDatos();
            cDatos.insertarContacto(c);
        }

        public DataTable consultar(Contacto c)
        {
            ContactoDatos cDatos = new ContactoDatos();
            return cDatos.consultarFiltrados(c.Id_contacto, c.Nombre, c.Apellido, c.Email, c.Telefono);
        }

        public void modificar(Contacto c)
        {
            ContactoDatos cDatos = new ContactoDatos();
            cDatos.modificarContacto(c);
        }

        public void eliminar(int id)
        {
            ContactoDatos cDatos = new ContactoDatos();
            cDatos.eliminarContacto(id);
        }
    }
}
