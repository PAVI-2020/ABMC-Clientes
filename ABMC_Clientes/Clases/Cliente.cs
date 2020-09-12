using ABMC_Clientes.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMC_Clientes.Clases {
	public class Cliente {
		private Datos obd = new Datos();

		private int id;
		private int cuit;
		private string razonSocial;
		private bool borrado;
		private string calle;
		private int numero;
		private DateTime fechaAlta;
		private int idBarrio;
		private int idContacto;

		public Cliente(int id, int cuit, string razonSocial, bool borrado, string calle, int numero, DateTime fechaAlta, int idBarrio, int idContacto) {
			this.id = id;
			this.cuit = cuit;
			this.razonSocial = razonSocial;
			this.borrado = borrado;
			this.calle = calle;
			this.numero = numero;
			this.fechaAlta = fechaAlta;
			this.idBarrio = idBarrio;
			this.idContacto = idContacto;
		}

		public DataTable RecuperarCliente() {
			string consultaSQL = "SELECT C.id_cliente, C.cuit, C.razon_social, C.borrado, C.calle, C.numero, C.fecha_alta, Co.nombre as 'nombre_contacto', B.nombre as 'nombre_barrio'";
			string tablasConsulta = "Clientes C JOIN Contactos Co ON (C.id_contacto == Co.id_contacto) JOIN Barrios B ON (B.id_barrio == C.id_barrio)";
			string condicion = "B.id_producto=";
			DataTable tablas = obd.ConsultarTabla(consultaSQL, tablasConsulta, condicion);

			if (tablas.Rows.Count <= 0)
				return null;

			return tablas;
		}

		public DataTable RecuperarClienteFiltrado(int id = -1, int cuit = -1, string razonSocial = "", string calle = "", int numero = -1, DateTime fechaAlta = default(DateTime), int idBarrio = -1, int idContacto = -1) {
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

			DataTable tablas = obd.ConsultarTabla(consultaSQL, tablasConsulta, condicion);

			if (tablas.Rows.Count <= 0)
				return null;

			return tablas;
		}

		public int Id { get => id; set => id = value; }
		public int Cuit { get => cuit; set => cuit = value; }
		public string RazonSocial { get => razonSocial; set => razonSocial = value; }
		public bool Borrado { get => borrado; set => borrado = value; }
		public string Calle { get => calle; set => calle = value; }
		public int Numero { get => numero; set => numero = value; }
		public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
		public int IdBarrio { get => idBarrio; set => idBarrio = value; }
		public int IdContacto { get => idContacto; set => idContacto = value; }
	}
}
