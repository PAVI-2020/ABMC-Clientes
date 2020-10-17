using System;

namespace ABMC_Clientes.Clases {
	[SQLTable("CiclosPruebaDetalle")]
	public class CiclosPruebaDetalle {
		private int id_ciclo_prueba_detalle;
		private int id_ciclo_prueba;
		private int id_caso_prueba;
		private int id_usuario_tester;
		private int cantidad_horas;
		private DateTime fecha_ejecucion;
		private bool aceptado;
		private bool borrado;

		public CiclosPruebaDetalle() { }

		public CiclosPruebaDetalle(int id_ciclo_prueba_detalle, int id_ciclo_prueba, int caso_prueba, int id_usuario_tester, int cantidad_horas, DateTime fecha_ejecucion, bool aceptado, bool borrado) {
			this.Id_ciclo_prueba_detalle = id_ciclo_prueba_detalle;
			this.Id_ciclo_prueba = id_ciclo_prueba;
			this.Id_Caso_prueba = caso_prueba;
			this.Id_usuario_tester = id_usuario_tester;
			this.Cantidad_horas = cantidad_horas;
			this.Fecha_ejecucion = fecha_ejecucion;
			this.Aceptado = aceptado;
			this.Borrado = borrado;
		}

		[SQLField("id_ciclo_prueba_detalle")]	public int Id_ciclo_prueba_detalle { get => id_ciclo_prueba_detalle; set => id_ciclo_prueba_detalle = value; }
		[SQLField("id_ciclo_prueba")]			public int Id_ciclo_prueba { get => id_ciclo_prueba; set => id_ciclo_prueba = value; }
		[SQLField("id_caso_prueba")]			public int Id_Caso_prueba { get => id_caso_prueba; set => id_caso_prueba = value; }
		[SQLField("id_usuario_tester")]			public int Id_usuario_tester { get => id_usuario_tester; set => id_usuario_tester = value; }
		[SQLField("cantidad_horas")]			public int Cantidad_horas { get => cantidad_horas; set => cantidad_horas = value; }
		[SQLField("fecha_ejecucion")]			public DateTime Fecha_ejecucion { get => fecha_ejecucion; set => fecha_ejecucion = value; }
		[SQLField("aceptado")]					public bool Aceptado { get => aceptado; set => aceptado = value; }
		[SQLField("borrado")]					public bool Borrado { get => borrado; set => borrado = value; }
	}
}
