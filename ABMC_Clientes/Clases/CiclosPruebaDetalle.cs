using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMC_Clientes.Clases {
	public class CiclosPruebaDetalle {
		private  int id_ciclo_prueba_detalle;
		private  int id_ciclo_prueba;
		private  int caso_prueba;
		private  int id_usuario_tester;
		private  int cantidad_horas;
		private  DateTime fecha_ejecucion;
		private  bool aceptado;
		private  bool borrado;

		public CiclosPruebaDetalle(int id_ciclo_prueba_detalle, int id_ciclo_prueba, int caso_prueba, int id_usuario_tester, int cantidad_horas, DateTime fecha_ejecucion, bool aceptado, bool borrado) {
			this.Id_ciclo_prueba_detalle = id_ciclo_prueba_detalle;
			this.Id_ciclo_prueba = id_ciclo_prueba;
			this.Caso_prueba = caso_prueba;
			this.Id_usuario_tester = id_usuario_tester;
			this.Cantidad_horas = cantidad_horas;
			this.Fecha_ejecucion = fecha_ejecucion;
			this.Aceptado = aceptado;
			this.Borrado = borrado;
		}

		public int Id_ciclo_prueba_detalle { get => id_ciclo_prueba_detalle; set => id_ciclo_prueba_detalle = value; }
		public int Id_ciclo_prueba { get => id_ciclo_prueba; set => id_ciclo_prueba = value; }
		public int Caso_prueba { get => caso_prueba; set => caso_prueba = value; }
		public int Id_usuario_tester { get => id_usuario_tester; set => id_usuario_tester = value; }
		public int Cantidad_horas { get => cantidad_horas; set => cantidad_horas = value; }
		public DateTime Fecha_ejecucion { get => fecha_ejecucion; set => fecha_ejecucion = value; }
		public bool Aceptado { get => aceptado; set => aceptado = value; }
		public bool Borrado { get => borrado; set => borrado = value; }
	}
}
