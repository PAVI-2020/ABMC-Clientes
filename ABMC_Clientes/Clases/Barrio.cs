namespace ABMC_Clientes.Clases {
	[SQLTable("Barrios")]
	public class Barrio {
		private int id_barrio;
		private string nombre;
		private bool borrado;

		[SQLPrimaryKey]
		[SQLField("id_barrio")]	public int Id_barrio { get => id_barrio; set => id_barrio = value; }
		[SQLField("nombre")]	public string Nombre { get => nombre; set => nombre = value; }
		[SQLField("borrado")]	public bool Borrado { get => borrado; set => borrado = value; }

		public Barrio() {}

		public Barrio(int id_barrio, string nombre, bool borrado) {
			this.id_barrio = id_barrio;
			this.nombre = nombre;
			this.borrado = borrado;
		}
	}
	
}
