using ABMC_Clientes.Clases;
using System;
using System.Data;
using System.Linq;

namespace ABMC_Clientes.DataAccess {
	public class ClienteDatos : ObjetoDatos<Cliente> {
		public Cliente[] RecuperarClienteFiltrado(int id = -1, string cuit = "", string razonSocial = "", string calle = "", string numero = "", DateTime fechaAlta = default(DateTime), int idBarrio = -1, int idContacto = -1) {
			string consultaSQL = "C.id_cliente, C.cuit, C.razon_social, C.borrado, C.calle, C.numero, C.fecha_alta, Co.nombre as 'nombre_contacto', Co.apellido as 'apellido_contacto', B.nombre as 'nombre_barrio', B.id_barrio, C.id_contacto";
			string tablasConsulta = "Clientes C JOIN Contactos Co ON (C.id_contacto = Co.id_contacto) JOIN Barrios B ON (B.id_barrio = C.id_barrio)";
			string[] condiciones = {
				((id != -1)             ? "C.id_cliente="   + id.ToString()                 : ""),
				((cuit != "")           ? "C.cuit='"        + cuit                  + "'"   : ""),
				((razonSocial != "")    ? "C.razon_social='"+ razonSocial           + "'"   : ""),
				((calle != "")          ? "C.calle='"       + calle                 + "'"   : ""),
				((numero != "")         ? "C.numero='"      + numero.ToString()     + "'"   : ""),
				((idBarrio != -1)       ? "C.id_barrio="    + idBarrio.ToString()           : ""),
				((idContacto != -1)     ? "C.id_contacto="  + idContacto.ToString()         : ""),
				((fechaAlta != default(DateTime)) ? "C.fecha_alta='" + fechaAlta.ToString("yyyy-MM-dd hh:mm:ss") + "'" : ""),
				"C.borrado=0"
			};

			condiciones = condiciones.Where(x => !string.IsNullOrEmpty(x)).ToArray();

			string condicion = string.Join(" AND ", condiciones);

			Datos datos = new Datos();
			DataTable tablas = datos.ConsultarTabla(consultaSQL, tablasConsulta, condicion);

			if (tablas.Rows.Count <= 0)
				return null;

			return BatchConvertir(tablas);
		}
	}
}
