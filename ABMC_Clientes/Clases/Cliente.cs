using System;

namespace ABMC_Clientes.Clases {
	[SQLTable("Clientes")]
	[SQLSecondaryTable("Barrios", "Clientes.id_barrio = Barrios.id_barrio")]
	[SQLSecondaryTable("Contactos", "Clientes.id_contacto = Contactos.id_contacto")]
	public class Cliente {
		private int id;
		private string cuit;
		private string razonSocial;
		private string calle;
		private string numero;
		private DateTime fechaAlta;
		private int idBarrio;
		private int idContacto;
		private bool borrado;

		private string nombreBarrio;
		private string nombreContacto;

		public Cliente() {}

        public Cliente(int id, string cuit, string razonSocial, bool borrado, string calle, string numero, DateTime fechaAlta, string nombreBarrio, string nombreContacto, int idBarrio, int idContacto) {
			this.id = id;
			this.cuit = cuit;
			this.razonSocial = razonSocial;
			this.borrado = borrado;
			this.calle = calle;
			this.numero = numero;
			this.fechaAlta = fechaAlta;
			this.nombreBarrio = nombreBarrio;
			this.nombreContacto = nombreContacto;
			this.IdBarrio = idBarrio;
			this.IdContacto = idContacto;
		}

		[SQLPrimaryKey]
		[SQLField("id_cliente")]	public int Id { get => id; set => id = value; }
		[SQLField("cuit")]			public string Cuit { get => cuit; set => cuit = value; }
		[SQLField("razon_social")]	public string RazonSocial { get => razonSocial; set => razonSocial = value; }
		[SQLField("calle")]			public string Calle { get => calle; set => calle = value; }
		[SQLField("numero")]		public string Numero { get => numero; set => numero = value; }
		[SQLField("fecha_alta")]	public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
		[SQLField("id_barrio")]		public int IdBarrio { get => idBarrio; set => idBarrio = value; }
		[SQLField("id_contacto")]	public int IdContacto { get => idContacto; set => idContacto = value; }
		[SQLField("borrado")]		public bool Borrado { get => borrado; set => borrado = value; }

		[SQLSecondaryField("Barrios.nombre", "barrio")]		public string Barrio { get => nombreBarrio; set => nombreBarrio = value; }
		[SQLSecondaryField("Contactos.nombre + ' ' + Contactos.apellido", "contacto")]	public string Contacto { get => nombreContacto; set => nombreContacto = value; }
	}
}
