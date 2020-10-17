namespace ABMC_Clientes.Clases {
    public class Proyecto {
        private int id_proyecto;
        private int id_producto;
        private string descripcion;
        private string version;
        private string alcance;
        private int id_responsable;
        private bool borrado;

        public Proyecto() { }

        public Proyecto(int id_proyecto, int id_producto, string descripcion, string version, string alcance, int id_responsable, bool borrado) {
            this.Id_proyecto = id_proyecto;
            this.Id_producto = id_producto;
            this.Descripcion = descripcion;
            this.Version = version;
            this.Alcance = alcance;
            this.Id_responsable = id_responsable;
            this.Borrado = borrado;
        }

        public int Id_proyecto { get => id_proyecto; set => id_proyecto = value; }
        public int Id_producto { get => id_producto; set => id_producto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Version { get => version; set => version = value; }
        public string Alcance { get => alcance; set => alcance = value; }
        public int Id_responsable { get => id_responsable; set => id_responsable = value; }
        public bool Borrado { get => borrado; set => borrado = value; }
    }
}
