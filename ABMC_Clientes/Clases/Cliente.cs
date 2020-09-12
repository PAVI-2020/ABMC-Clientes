using System;

namespace ABMC_Clientes.Clases {
	public class Cliente {
		private int id;
		private int cuit;
		private string razonSocial;
		private bool borrado;
		private string calle;
		private int numero;
		private DateTime fechaAlta;
		private string nombreBarrio;
		private string nombreContacto;
		private int idBarrio;
		private int idContacto;

		public Cliente(int id, int cuit, string razonSocial, bool borrado, string calle, int numero, DateTime fechaAlta, string nombreBarrio, string nombreContacto, int idBarrio, int idContacto) {
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

		public int Id { get => id; set => id = value; }
		public int Cuit { get => cuit; set => cuit = value; }
		public string RazonSocial { get => razonSocial; set => razonSocial = value; }
		public bool Borrado { get => borrado; set => borrado = value; }
		public string Calle { get => calle; set => calle = value; }
		public int Numero { get => numero; set => numero = value; }
		public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
		public string Barrio { get => nombreBarrio; set => nombreBarrio = value; }
		public string Contacto { get => nombreContacto; set => nombreContacto = value; }
		public int IdBarrio { get => idBarrio; set => idBarrio = value; }
		public int IdContacto { get => idContacto; set => idContacto = value; }
	}
}
