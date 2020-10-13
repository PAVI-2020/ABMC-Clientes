using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMC_Clientes.Clases {
	class CiclosPrueba {
		private  int id_ciclo_prueba;
		private  DateTime fecha_inicio_ejecucion;
		private  DateTime fecha_fin_ejecucion;
		private  int id_responsable;
		private string usuario;
		private  int id_plan_prueba;
		private  bool aceptado;
		private  bool borrado;

		public CiclosPrueba(int id_ciclo_prueba, DateTime fecha_inicio_ejecucion, DateTime fecha_fin_ejecucion, string usuario, int id_responsable, int id_plan_prueba, bool aceptado, bool borrado) {
			this.Id_ciclo_prueba = id_ciclo_prueba;
			this.Fecha_inicio_ejecucion = fecha_inicio_ejecucion;
			this.Fecha_fin_ejecucion = fecha_fin_ejecucion;
			this.Id_responsable = id_responsable;
			this.usuario = usuario;
			this.Id_plan_prueba = id_plan_prueba;
			this.Aceptado = aceptado;
			this.Borrado = borrado;
		}

		public int Id_ciclo_prueba { get => id_ciclo_prueba; set => id_ciclo_prueba = value; }
		public DateTime Fecha_inicio_ejecucion { get => fecha_inicio_ejecucion; set => fecha_inicio_ejecucion = value; }
		public DateTime Fecha_fin_ejecucion { get => fecha_fin_ejecucion; set => fecha_fin_ejecucion = value; }
		public int Id_responsable { get => id_responsable; set => id_responsable = value; }
		public int Id_plan_prueba { get => id_plan_prueba; set => id_plan_prueba = value; }
		public bool Aceptado { get => aceptado; set => aceptado = value; }
		public bool Borrado { get => borrado; set => borrado = value; }
		public string Usuario { get => usuario; set => usuario = value; }
	}
}
