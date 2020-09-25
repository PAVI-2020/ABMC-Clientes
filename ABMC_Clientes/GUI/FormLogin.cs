using ABMC_Clientes.Business;
using ABMC_Clientes.Clases;
using System;
using System.Windows.Forms;

namespace ABMC_Clientes.GUI {
	public partial class FormLogin : Form {
		public Usuario usuario;

		public FormLogin() {
			InitializeComponent();
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void btnOK_Click(object sender, EventArgs e) {
			UsuarioBusiness bus = new UsuarioBusiness();
			usuario = bus.ValidarUsuario(txtUsuario.Text, txtPass.Text);
			if (usuario == null) {
				MessageBox.Show("Usuario o contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
