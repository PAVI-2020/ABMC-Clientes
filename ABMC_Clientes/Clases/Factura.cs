using System;

namespace ABMC_Clientes.Clases {
	[SQLTable("Facturas")]
	[SQLSecondaryTable("Clientes", "Facturas.id_cliente = Clientes.id_cliente")]
	[SQLSecondaryTable("Usuario", "Facturas.id_usuario_creador = Usuarios.id_usuario")]
	public class Factura {
		private int id_factura;
		private string numero_factura;
		private int id_cliente;
		private DateTime fecha;
		private int id_usuario_creador;
		private bool borrado;
		private string nombreCliente;
		private string nombreUsuarioCreador;
		private DetalleFactura[] detalles;

		public Factura(int id_factura, string numero_factura, int id_cliente, DateTime fecha, int id_usuario_creador, bool borrado, string nombreCliente, string nombreUsuarioCreador, DetalleFactura[] det) {
			this.id_factura = id_factura;
			this.numero_factura = numero_factura;
			this.id_cliente = id_cliente;
			this.fecha = fecha;
			this.id_usuario_creador = id_usuario_creador;
			this.borrado = borrado;
			this.NombreCliente = nombreCliente;
			this.NombreUsuarioCreador = nombreUsuarioCreador;
			this.detalles = det;
		}

		public Factura(int id_factura, string numero_factura, int id_cliente, DateTime fecha, int id_usuario_creador, bool borrado) {
			this.id_factura = id_factura;
			this.numero_factura = numero_factura;
			this.id_cliente = id_cliente;
			this.fecha = fecha;
			this.id_usuario_creador = id_usuario_creador;
			this.borrado = borrado;
		}

		[SQLPrimaryKey]
		[SQLField("id_factura")]		public int Id_factura { get => id_factura; set => id_factura = value; }
		[SQLField("numero_factura")]	public string Numero_factura { get => numero_factura; set => numero_factura = value; }
		[SQLField("id_cliente")]		public int Id_cliente { get => id_cliente; set => id_cliente = value; }
		[SQLField("fecha")]				public DateTime Fecha { get => fecha; set => fecha = value; }
		[SQLField("id_usuario_creador")]public int Id_usuario_creador { get => id_usuario_creador; set => id_usuario_creador = value; }
		[SQLField("borrado")]			public bool Borrado { get => borrado; set => borrado = value; }

		[SQLSecondaryField("Clientes.razon_social", "nombre_cliente")]	public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
		[SQLSecondaryField("Usuario.usuario", "nombre_creador")]		public string NombreUsuarioCreador { get => nombreUsuarioCreador; set => nombreUsuarioCreador = value; }
		public DetalleFactura[] Detalles { get => detalles; set => detalles = value; }
	}
}
