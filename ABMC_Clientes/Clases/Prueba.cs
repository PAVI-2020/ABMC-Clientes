namespace ABMC_Clientes.Clases {
	public class Prueba {
		private int id_plan_prueba;
		private int id_proyecto;
		private string nombre;
		private int id_responsable;
		private string descripcion;
		private bool borrado;

		public Prueba() { }

		public Prueba(int id_plan_prueba, int id_proyecto, string nombre, int id_responsable, string descripcion, bool borrado) {
			this.id_plan_prueba = id_plan_prueba;
			this.id_proyecto = id_proyecto;
			this.nombre = nombre;
			this.id_responsable = id_responsable;
			this.descripcion = descripcion;
			this.borrado = borrado;
		}

		public int Id_plan_prueba { get => id_plan_prueba; set => id_plan_prueba = value; }
		public int Id_proyecto { get => id_proyecto; set => id_proyecto = value; }
		public string Nombre { get => nombre; set => nombre = value; }
		public int Id_responsable { get => id_responsable; set => id_responsable = value; }
		public string Descripcion { get => descripcion; set => descripcion = value; }
		public bool Borrado { get => borrado; set => borrado = value; }
	}
	
}
