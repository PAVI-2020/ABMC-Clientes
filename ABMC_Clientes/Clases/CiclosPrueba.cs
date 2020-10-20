using System;

namespace ABMC_Clientes.Clases {
	[SQLTable("CiclosPrueba")]
	class CiclosPrueba {
		private int id_ciclo_prueba;
		private DateTime fecha_inicio_ejecucion;
		private DateTime fecha_fin_ejecucion;
		private int id_responsable;
		private int usuario;
		private int id_plan_prueba;
		private bool aceptado;
		private bool borrado;
		private CiclosPruebaDetalle[] detalles;

		public CiclosPrueba() { }

		public CiclosPrueba(int id_ciclo_prueba, DateTime fecha_inicio_ejecucion, DateTime fecha_fin_ejecucion, int usuario, int id_responsable, int id_plan_prueba, bool aceptado, bool borrado) {
			this.Id_ciclo_prueba = id_ciclo_prueba;
			this.Fecha_inicio_ejecucion = fecha_inicio_ejecucion;
			this.Fecha_fin_ejecucion = fecha_fin_ejecucion;
			this.Id_responsable = id_responsable;
			this.Usuario = usuario;
			this.Id_plan_prueba = id_plan_prueba;
			this.Aceptado = aceptado;
			this.Borrado = borrado;
		}

		[SQLField("id_ciclo_prueba")]	public int Id_ciclo_prueba { get => id_ciclo_prueba; set => id_ciclo_prueba = value; }
		[SQLField("fecha_inicio_ejecucion")] public DateTime Fecha_inicio_ejecucion { get => fecha_inicio_ejecucion; set => fecha_inicio_ejecucion = value; }
		[SQLField("fecha_fin_ejecucion")] public DateTime Fecha_fin_ejecucion { get => fecha_fin_ejecucion; set => fecha_fin_ejecucion = value; }
		[SQLField("id_responsable")] public int Id_responsable { get => id_responsable; set => id_responsable = value; }
		[SQLField("id_plan_prueba")] public int Id_plan_prueba { get => id_plan_prueba; set => id_plan_prueba = value; }
		[SQLField("aceptado")] public bool Aceptado { get => aceptado; set => aceptado = value; }
		[SQLField("borrado")] public bool Borrado { get => borrado; set => borrado = value; }
		public int Usuario { get => usuario; set => usuario = value; }
		[SQLDependency]	public CiclosPruebaDetalle[] Detalles { get => detalles; set => detalles = value; }
	}
}
