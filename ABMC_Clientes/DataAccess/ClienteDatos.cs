using ABMC_Clientes.Clases;
using System;
using System.Data;
using System.Linq;

namespace ABMC_Clientes.DataAccess {
	public class ClienteDatos {
		public static Cliente[] RecuperarCliente() {
			string consultaSQL = "C.id_cliente, C.cuit, C.razon_social, C.borrado, C.calle, C.numero, C.fecha_alta, Co.nombre as 'nombre_contacto', Co.apellido as 'apellido_contacto', B.nombre as 'nombre_barrio', C.id_barrio, C.id_contacto";
			string tablasConsulta = "Clientes C JOIN Contactos Co ON (C.id_contacto = Co.id_contacto) JOIN Barrios B ON (B.id_barrio = C.id_barrio)";
			
			Datos datos = new Datos();
			DataTable tablas = datos.ConsultarTabla(consultaSQL, tablasConsulta, "C.borrado = 0");

			if (tablas.Rows.Count <= 0)
				return null;

			return ConvertirClientes(tablas);
		}

		public static Cliente[] RecuperarClienteFiltrado(int id = -1, string cuit = "", string razonSocial = "", string calle = "", string numero = "", DateTime fechaAlta = default(DateTime), int idBarrio = -1, int idContacto = -1) {
			string consultaSQL = "C.id_cliente, C.cuit, C.razon_social, C.borrado, C.calle, C.numero, C.fecha_alta, Co.nombre as 'nombre_contacto', Co.apellido as 'apellido_contacto', B.nombre as 'nombre_barrio', B.id_barrio, C.id_contacto";
			string tablasConsulta = "Clientes C JOIN Contactos Co ON (C.id_contacto = Co.id_contacto) JOIN Barrios B ON (B.id_barrio = C.id_barrio)";
			string[] condiciones = {
				((id != -1)             ? "C.id_cliente="	+ id.ToString()					: ""),
				((cuit != "")           ? "C.cuit='"        + cuit					+ "'"	: ""),
				((razonSocial != "")    ? "C.razon_social='"+ razonSocial           + "'"	: ""),
				((calle != "")          ? "C.calle='"       + calle                 + "'"	: ""),
				((numero != "")         ? "C.numero='"      + numero.ToString()     + "'"	: ""),
				((idBarrio != -1)       ? "C.id_barrio="    + idBarrio.ToString()			: ""),
				((idContacto != -1)     ? "C.id_contacto="  + idContacto.ToString()			: ""),
				((fechaAlta != default(DateTime)) ? "C.fecha_alta='" + fechaAlta.ToString("yyyy-MM-dd hh:mm:ss") + "'" : "")
			};

			condiciones = condiciones.Where(x => !string.IsNullOrEmpty(x)).ToArray();

			string condicion = string.Join(" AND ", condiciones);

			Datos datos = new Datos();
			DataTable tablas = datos.ConsultarTabla(consultaSQL, tablasConsulta, condicion);

			if (tablas.Rows.Count <= 0)
				return null;

			return ConvertirClientes(tablas);
		}

		public static Cliente ConvertirCliente(DataRow input) {
			Cliente c = new Cliente(
				id:				(int)input["id_cliente"],
				cuit:			(string)input["cuit"],
				razonSocial:	(string)input["razon_social"],
				borrado:		(bool)input["borrado"],
				calle:			(string)input["calle"],
				numero:			(string)input["numero"],
				fechaAlta:		(DateTime)input["fecha_alta"],
				nombreBarrio:	(string)input["nombre_barrio"],
				nombreContacto: string.Join(" ", (string)input["nombre_contacto"], (string)input["apellido_contacto"]),
				idBarrio:		(int)input["id_barrio"],
				idContacto:		(int)input["id_contacto"]
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

		public static void EliminarCliente(int id) {
			Datos datos = new Datos();
			string eliminacion = "UPDATE Clientes Set Borrado = 1 WHERE id_cliente = " + id;

			datos.Actualizar(eliminacion);
		}

		public static void InsertarCliente(Cliente cliente) {
			Datos datos = new Datos();
			string insercion = "INSERT INTO Clientes (cuit, razon_social, borrado, calle, numero, fecha_alta, id_barrio, id_contacto) VALUES ('" +
								cliente.Cuit.ToString() + "', '" + cliente.RazonSocial + "', 0, '" + cliente.Calle + "', '" + cliente.Numero.ToString() +
								"', GETDATE(), " + cliente.IdBarrio + ", " + cliente.IdContacto + ")";
			datos.Actualizar(insercion);
		}

		public static void ActualizarCliente(Cliente cliente) {
			Datos datos = new Datos();
			string actualizacion = "UPDATE Clientes SET cuit= '" + cliente.Cuit.ToString() + "', razon_social= '" + cliente.RazonSocial + "', calle= '" + cliente.Calle +
				"', numero= '" + cliente.Numero.ToString() +"', fecha_alta='" + cliente.FechaAlta.ToString("yyyy-MM-dd hh:mm:ss") + "', id_barrio= " + cliente.IdBarrio + ", id_contacto= " + cliente.IdContacto
				+ " WHERE id_cliente=" + cliente.Id;

			datos.Actualizar(actualizacion);
		}
	}
}
