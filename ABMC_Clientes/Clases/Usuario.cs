namespace ABMC_Clientes.Clases {
	[SQLTable("Usuarios")]
	public class Usuario {
		private int idUsuario;
		private string n_usuario;
		private string password;
		private string mail;
		private string estado;
		private int idPerfil;
		private bool borrado;

		[SQLPrimaryKey]
		[SQLField("id_usuario")]	public int IdUsuario { get => idUsuario; set => idUsuario = value; }
		[SQLField("usuario")]		public string N_usuario { get => n_usuario; set => n_usuario = value; }
		[SQLField("password")]		public string Password { get => password; set => password = value; }
		[SQLField("email")]			public string Mail { get => mail; set => mail = value; }
		[SQLField("id_perfil")]		public int IdPerfil { get => idPerfil; set => idPerfil = value; }
		[SQLField("estado")]		public string Estado { get => estado; set => estado = value; }
		[SQLField("borrado")]		public bool Borrado { get => borrado; set => borrado = value; }
	}
}
