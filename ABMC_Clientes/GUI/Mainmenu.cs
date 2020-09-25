using ABMC_Clientes.Clases;
using System;
using System.Windows.Forms;

namespace ABMC_Clientes.GUI {
	public partial class frmMainMenu : Form {
		private Usuario currentUsuario;

		public frmMainMenu() {
			InitializeComponent();
		}

		private void LogUser() {
			if (currentUsuario == null) {
				FormLogin login = new FormLogin();
				if (login.ShowDialog() == DialogResult.OK)
					currentUsuario = login.usuario;
			}
		}

		private void button1_Click(object sender, EventArgs e) {
			FormABMC abmcClientes = new FormABMC();
			abmcClientes.ShowDialog();
		}

		private void btnAdmBarrios_Click(object sender, EventArgs e) {
			frmABMCBarrios abmcBarrios = new frmABMCBarrios();
			abmcBarrios.ShowDialog();
		}

		private void btnAdmPruebas_Click(object sender, EventArgs e) {
			FormABMCPruebas abmcPruebas = new FormABMCPruebas();
			abmcPruebas.ShowDialog();
		}

		private void btnExit_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void btnAdmContactos_Click(object sender, EventArgs e) {
			FormABMCContactos abmcContactos = new FormABMCContactos();
			abmcContactos.ShowDialog();
		}

		private void btnTransaccion_Click(object sender, EventArgs e) {
			LogUser();
			frmFacturacion fact = new frmFacturacion();
			fact.ShowDialog();			
		}
	}
}
