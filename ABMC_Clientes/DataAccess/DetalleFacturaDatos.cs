﻿using ABMC_Clientes.Clases;
using System.Data;

namespace ABMC_Clientes.DataAccess {
	public class DetalleFacturaDatos {
		public static DetalleFactura[] RecuperarDFactura() {
			string consultaSQL = "D.id_detalle_factura, D.id_factura, D.numero_orden, D.id_producto, D.id_proyecto, D.id_ciclo_prueba, D.precio, D.borrado";
			string tablasConsulta = "FacturasDetalle D";

			Datos datos = new Datos();
			DataTable tablas = datos.ConsultarTabla(consultaSQL, tablasConsulta, "D.borrado = 0");

			if (tablas.Rows.Count <= 0)
				return null;

			return ConvertirDFacturas(tablas);
		}

		public static DetalleFactura ConvertirDFactura(DataRow input) {
			DetalleFactura f = new DetalleFactura(
				id_detalle_factura: (int)input["id_detalle_factura"],
				id_factura:			(int)input["id_factura"],
				numero_orden:		(int)input["numero_orden"],
				id_producto:        (int)input["id_producto"],
				id_proyecto:        (int)input["id_proyecto"],
				id_ciclo_prueba:	(int)input["id_ciclo_prueba"],
				precio:				(decimal)input["precio"],
				borrado:            (bool)input["borrado"]
			);

			return f;
		}

		public static DetalleFactura[] ConvertirDFacturas(DataTable input) {
			DetalleFactura[] ret = new DetalleFactura[input.Rows.Count];

			for (int i = 0; i < ret.Length; i++) {
				ret[i] = ConvertirDFactura(input.Rows[i]);
			}

			return ret;
		}

		public static void InsertarDFactura(DetalleFactura dFactura) {
			Datos datos = new Datos();
			string insercion = "INSERT INTO FacturasDetalle (id_detalle_factura, id_factura, numero_orden, id_producto, id_ciclo_prueba, precio, borrado) VALUES ('" +
								dFactura.Id_detalle_factura.ToString() + "', '" +
								dFactura.Id_factura.ToString() + "', '" +
								dFactura.Numero_orden.ToString() + "', '" +
								dFactura.Id_producto.ToString() + "', '" +
								dFactura.Id_proyecto.ToString("yyyy-MM-dd hh:mm:ss") + "'" +
								dFactura.Id_ciclo_prueba.ToString() + "'" +
								dFactura.Precio.ToString() + "'" +
								", 0)";
			datos.Actualizar(insercion);
		}
	}
}