using System;

namespace ABMC_Clientes.Clases {
	public class DetalleFactura {
		private int id_detalle_factura;
		private int id_factura;
		private int numero_orden;
		private int id_producto;
		private int id_proyecto;
		private int id_ciclo_prueba;
		private decimal precio;
		private bool borrado;

		public DetalleFactura(int id_detalle_factura, int id_factura, int numero_orden, int id_producto, int id_proyecto, int id_ciclo_prueba, decimal precio, bool borrado) {
			this.id_detalle_factura = id_detalle_factura;
			this.id_factura = id_factura;
			this.numero_orden = numero_orden;
			this.id_producto = id_producto;
			this.id_proyecto = id_proyecto;
			this.id_ciclo_prueba = id_ciclo_prueba;
			this.precio = precio;
			this.borrado = borrado;
		}

		public int Id_detalle_factura { get => id_detalle_factura; set => id_detalle_factura = value; }
		public int Id_factura { get => id_factura; set => id_factura = value; }
		public int Numero_orden { get => numero_orden; set => numero_orden = value; }
		public int Id_producto { get => id_producto; set => id_producto = value; }
		public int Id_proyecto { get => id_proyecto; set => id_proyecto = value; }
		public int Id_ciclo_prueba { get => id_ciclo_prueba; set => id_ciclo_prueba = value; }
		public decimal Precio { get => precio; set => precio = value; }
		public bool Borrado { get => borrado; set => borrado = value; }
	}
}
