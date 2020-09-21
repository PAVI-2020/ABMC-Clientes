using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMC_Clientes.Clases
{
    class Contacto
    {
        private int id_contacto;
        private string nombre;
        private string apellido;
        private string email;
        private string telefono;
        private bool borrado;

        public Contacto(int id_contacto, string nombre, string apellido, string email, string telefono, bool borrado)
        {
            this.id_contacto = id_contacto;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.telefono = telefono;
            this.borrado = borrado;
        }

        public int Id_contacto { get => id_contacto; set => id_contacto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public bool Borrado { get => borrado; set => borrado = value; }
    }
}
