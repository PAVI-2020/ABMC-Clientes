using System;

namespace ABMC_Clientes.Clases {
	public class Factura {
		private int id_factura;
		private int numero_factura;
		private int id_cliente;
		private DateTime fecha;
		private int id_usuario_creador;
		private bool borrado;

		public Factura(int id_factura, int numero_factura, int id_cliente, DateTime fecha, int id_usuario_creador, bool borrado) {
			this.id_factura = id_factura;
			this.numero_factura = numero_factura;
			this.id_cliente = id_cliente;
			this.fecha = fecha;
			this.id_usuario_creador = id_usuario_creador;
			this.borrado = borrado;
		}

		public int Id_factura { get => id_factura; set => id_factura = value; }
		public int Numero_factura { get => numero_factura; set => numero_factura = value; }
		public int Id_cliente { get => id_cliente; set => id_cliente = value; }
		public DateTime Fecha { get => fecha; set => fecha = value; }
		public int Id_usuario_creador { get => id_usuario_creador; set => id_usuario_creador = value; }
		public bool Borrado { get => borrado; set => borrado = value; }
	}
}
