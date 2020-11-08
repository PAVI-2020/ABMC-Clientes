using ABMC_Clientes.Clases;
using System;
using System.Data;
using System.Linq;

namespace ABMC_Clientes.DataAccess {
	public class ClienteDatos : ObjetoDatos<Cliente> {
		public Cliente[] RecuperarClienteFiltrado(int id = -1, string cuit = "", string razonSocial = "", string calle = "", string numero = "", DateTime fechaAlta = default(DateTime), int idBarrio = -1, int idContacto = -1) {
			string consultaSQL = "Clientes.id_cliente, Clientes.cuit, Clientes.razon_social, Clientes.calle, Clientes.numero, Clientes.fecha_alta, Clientes.id_barrio, Clientes.id_contacto, Clientes.borrado, Barrios.nombre as 'barrio', Contactos.nombre + ' ' + Contactos.apellido as 'contacto'";
			string tablasConsulta = "Clientes JOIN Contactos ON (Clientes.id_contacto = Contactos.id_contacto) JOIN Barrios ON (Barrios.id_barrio = Clientes.id_barrio)";
			string[] condiciones = {
				((id != -1)             ? "Clientes.id_cliente="   + id.ToString()                 : ""),
				((cuit != "")           ? "Clientes.cuit='"        + cuit                  + "'"   : ""),
				((razonSocial != "")    ? "Clientes.razon_social='"+ razonSocial           + "'"   : ""),
				((calle != "")          ? "Clientes.calle='"       + calle                 + "'"   : ""),
				((numero != "")         ? "Clientes.numero='"      + numero.ToString()     + "'"   : ""),
				((idBarrio != -1)       ? "Clientes.id_barrio="    + idBarrio.ToString()           : ""),
				((idContacto != -1)     ? "Clientes.id_contacto="  + idContacto.ToString()         : ""),
				((fechaAlta != default(DateTime)) ? "Clientes.fecha_alta='" + fechaAlta.ToString("yyyy-MM-dd hh:mm:ss") + "'" : ""),
				"Clientes.borrado=0"
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
