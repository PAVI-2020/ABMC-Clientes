using ABMC_Clientes.Clases;
using System;
using System.Data;

namespace ABMC_Clientes.DataAccess
{
	public class FacturaDatos
	{
		public static Factura[] RecuperarFactura()
		{
			string consultaSQL = "F.id_factura, F.numero_factura, F.id_cliente, F.fecha, F.id_usuario_creador, F.borrado, C.razon_social as 'nombre_cliente', U.usuario as 'nombre_usuario' ";
			string tablasConsulta = "Facturas F JOIN Clientes C on (F.id_cliente = C.id_cliente) JOIN Usuarios U on (F.id_usuario_creador = U.id_usuario)";

			Datos datos = new Datos();
			DataTable tablas = datos.ConsultarTabla(consultaSQL, tablasConsulta, "F.borrado = 0");

			if (tablas.Rows.Count <= 0)
				return null;

			return ConvertirFacturas(tablas);
		}

		public static Factura ConvertirFactura(DataRow input)
		{
			Factura f = new Factura(
				id_factura: (int)input["id_factura"],
				numero_factura: (int)input["numero_factura"],
				id_cliente: (int)input["id_cliente"],
				fecha: (DateTime)input["fecha"],
				id_usuario_creador: (int)input["id_usuario_creador"],
				borrado: (bool)input["borrado"]
			);

			return f;
		}

		public static Factura[] ConvertirFacturas(DataTable input)
		{
			Factura[] ret = new Factura[input.Rows.Count];

			for (int i = 0; i < ret.Length; i++)
			{
				ret[i] = ConvertirFactura(input.Rows[i]);
			}

			return ret;
		}

		public static void InsertarFactura(Factura factura)
		{
			Datos datos = new Datos();
			string insercion = "INSERT INTO Factura (id_factura, numero_factura, id_cliente, fecha, id_usuario_creador, borrado) VALUES ('" +
								factura.Id_factura.ToString() + "', '" +
								factura.Numero_factura.ToString() + "', '" +
								factura.Id_cliente.ToString() + "', '" +
								factura.Fecha.ToString("yyyy-MM-dd hh:mm:ss") + "'" +
								factura.Id_usuario_creador.ToString() + "'" +
								", 0)";
			datos.Actualizar(insercion);
		}
	}
}

