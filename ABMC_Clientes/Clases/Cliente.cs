using System;

namespace ABMC_Clientes.Clases {
	public class Cliente {
		private int id;
		private string cuit;
		private string razonSocial;
		private int borrado;
		private string calle;
		private string numero;
		private DateTime fechaAlta;
		private string nombreBarrio;
		private string nombreContacto;
		private int idBarrio;
		private int idContacto;

        public Cliente()
        {
        }

        public Cliente(int id, string cuit, string razonSocial, int borrado, string calle, string numero, DateTime fechaAlta, string nombreBarrio, string nombreContacto, int idBarrio, int idContacto) {
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
		public string Cuit { get => cuit; set => cuit = value; }
		public string RazonSocial { get => razonSocial; set => razonSocial = value; }
		public int Borrado { get => borrado; set => borrado = value; }
		public string Calle { get => calle; set => calle = value; }
		public string Numero { get => numero; set => numero = value; }
		public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
		public string Barrio { get => nombreBarrio; set => nombreBarrio = value; }
		public string Contacto { get => nombreContacto; set => nombreContacto = value; }
		public int IdBarrio { get => idBarrio; set => idBarrio = value; }
		public int IdContacto { get => idContacto; set => idContacto = value; }
	}
}
