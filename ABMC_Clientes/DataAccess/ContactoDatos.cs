using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABMC_Clientes.Clases;

namespace ABMC_Clientes.DataAccess
{
    class ContactoDatos
    {
        Datos oDato = new Datos();

        public DataTable mostrarTodos()
        {
            DataTable tabla = new DataTable();
            tabla = oDato.ConsultarTabla("id_contacto, nombre, apellido, email, telefono", "Contactos", "borrado = 0");
            return tabla;
        }

        public void insertarContacto(Contacto c)
        {
            string insercion = "INSERT into Contactos (nombre, apellido, email, telefono, borrado) VALUES ('" +
                                c.Nombre + "', '" +
                                c.Apellido + "', '" +
                                c.Email + "', '" +
                                c.Telefono + "', " +
                                "0)";
            oDato.Actualizar(insercion);
        }

        public DataTable consultarFiltrados(int id=-1, string nombre="", string apellido="", string mail="", string telefono = "")
        {
            string consultaSQL = "c.id_contacto, c.nombre, c.apellido, c.email, c.telefono";
            string tablasConsulta = "Contactos c";
            string[] condiciones = {
                ((id != -1)             ? "c.id_contacto="   + id.ToString()                 : ""),
                ((nombre != "")         ? "c.nombre='"     + nombre                + "'"   : ""),
                ((apellido != "")         ? "c.apellido='"     + apellido                + "'"   : ""),
                ((mail != "")         ? "c.email='"     + mail                + "'"   : ""),
                ((telefono != "")         ? "c.telefono='"     + nombre                + "'"   : ""),
                "c.borrado=0"
            };

            condiciones = condiciones.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            string condicion = string.Join(" AND ", condiciones);

            DataTable tablas = oDato.ConsultarTabla(consultaSQL, tablasConsulta, condicion);

            if (tablas.Rows.Count <= 0)
                return null;

            return tablas;
        }

        public void modificarContacto(Contacto c)
        {
            string update = "UPDATE Contactos SET nombre = '" + c.Nombre + "', apellido = '" +
                             c.Apellido + "', email = '" +
                             c.Email + "', telefono = '" +
                             c.Telefono +
                            "' WHERE id_contacto = " + c.Id_contacto;

            oDato.Actualizar(update);
        }

        public void eliminarContacto(int id)
        {
            string delete = "UPDATE Contactos SET borrado = 1 WHERE id_contacto = " + id;
            oDato.Actualizar(delete);
        }
    }
}
