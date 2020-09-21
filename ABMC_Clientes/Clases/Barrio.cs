using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMC_Clientes.Clases {
	public class Barrio {
		private int id_barrio;
		private string nombre;
		private bool borrado;

		public int Id_barrio { get => id_barrio; set => id_barrio = value; }
		public string Nombre { get => nombre; set => nombre = value; }
		public bool Borrado { get => borrado; set => borrado = value; }

		public Barrio() {}

		public Barrio(int id_barrio, string nombre, bool borrado) {
			this.id_barrio = id_barrio;
			this.nombre = nombre;
			this.borrado = borrado;
		}
	}
	
}
