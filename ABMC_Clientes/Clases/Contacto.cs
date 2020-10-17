namespace ABMC_Clientes.Clases {
    [SQLTable("Contactos")]
    public class Contacto {
        private int id_contacto;
        private string nombre;
        private string apellido;
        private string email;
        private string telefono;
        private bool borrado;

        public Contacto(int id_contacto, string nombre, string apellido, string email, string telefono, bool borrado) {
            this.id_contacto = id_contacto;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.telefono = telefono;
            this.borrado = borrado;
        }

        [SQLPrimaryKey]
        [SQLField("id_contacto")]   public int Id_contacto { get => id_contacto; set => id_contacto = value; }
        [SQLField("nombre")]        public string Nombre { get => nombre; set => nombre = value; }
        [SQLField("apellido")]      public string Apellido { get => apellido; set => apellido = value; }
        [SQLField("email")]         public string Email { get => email; set => email = value; }
        [SQLField("telefono")]      public string Telefono { get => telefono; set => telefono = value; }
        [SQLField("borrado")]       public bool Borrado { get => borrado; set => borrado = value; }
    }
}
