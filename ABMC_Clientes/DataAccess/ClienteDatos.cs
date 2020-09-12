using ABMC_Clientes.Clases;
using System;
using System.Data;

namespace ABMC_Clientes.DataAccess {
	public class ClienteDatos {
		public static Cliente[] RecuperarCliente() {
			string consultaSQL = "SELECT C.id_cliente, C.cuit, C.razon_social, C.borrado, C.calle, C.numero, C.fecha_alta, Co.nombre as 'nombre_contacto', B.nombre as 'nombre_barrio'";
			string tablasConsulta = "Clientes C JOIN Contactos Co ON (C.id_contacto == Co.id_contacto) JOIN Barrios B ON (B.id_barrio == C.id_barrio)";
			string condicion = "B.id_producto=";
			Datos datos = new Datos();
			DataTable tablas = datos.ConsultarTabla(consultaSQL, tablasConsulta, condicion);

			if (tablas.Rows.Count <= 0)
				return null;

			return ConvertirClientes(tablas);
		}

		public static Cliente[] RecuperarClienteFiltrado(int id = -1, int cuit = -1, string razonSocial = "", string calle = "", int numero = -1, DateTime fechaAlta = default(DateTime), int idBarrio = -1, int idContacto = -1) {
			string consultaSQL = "SELECT C.id_cliente, C.cuit, C.razon_social, C.borrado, C.calle, C.numero, C.fecha_alta, Co.nombre as 'nombre_contacto', B.nombre as 'nombre_barrio'";
			string tablasConsulta = "Clientes C JOIN Contactos Co ON (C.id_contacto == Co.id_contacto) JOIN Barrios B ON (B.id_barrio == C.id_barrio)";
			string[] condiciones = {
				((id != -1)             ? "C.id_cliente="   + id.ToString()         : ""),
				((cuit != -1)           ? "C.cuit="         + cuit.ToString()       : ""),
				((razonSocial != "")    ? "C.razon_social=" + razonSocial           : ""),
				((calle != "")          ? "C.calle="        + calle                 : ""),
				((numero != -1)         ? "C.numero="       + numero.ToString()     : ""),
				((idBarrio != -1)       ? "C.id_barrio="    + idBarrio.ToString()   : ""),
				((idContacto != -1)     ? "C.id_contacto="  + numero.ToString()     : ""),
				((fechaAlta != default(DateTime)) ? "C.fecha_alta=" + fechaAlta.ToString() : "")
			};

			string condicion = string.Join(" AND ", condiciones);

			Datos datos = new Datos();
			DataTable tablas = datos.ConsultarTabla(consultaSQL, tablasConsulta, condicion);

			if (tablas.Rows.Count <= 0)
				return null;

			return ConvertirClientes(tablas);
		}

		public static Cliente ConvertirCliente(DataRow input) {
			Cliente c = new Cliente(
				id: (int)input["id_cliente"],
				cuit: (int)input["cuit"],
				razonSocial: input["razon_social"].ToString(),
				borrado: (bool)input["borrado"],
				calle: input["calle"].ToString(),
				numero: (int)input["numero"],
				fechaAlta: DateTime.Parse(input["fecha_alta"].ToString()),
				nombreBarrio: input["nombre_barrio"].ToString(),
				nombreContacto: input["nombre_contacto"].ToString(),
				idBarrio: (int)input["id_barrio"],
				idContacto: (int)input["id_contacto"]
			);

			return c;
		}

		public static Cliente[] ConvertirClientes(DataTable input) {
			Cliente[] ret = new Cliente[input.Rows.Count];

			for (int i = 0; i < ret.Length; i++) {
				ret[i] = ConvertirCliente(input.Rows[i]);
			}

			return ret;
		}
	}
}
