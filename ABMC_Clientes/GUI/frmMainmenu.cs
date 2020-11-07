using ABMC_Clientes.Business;
using ABMC_Clientes.Clases;
using System;
using System.Windows.Forms;

namespace ABMC_Clientes.GUI {
	public partial class frmMainMenu : Form {
		Usuario usuario;

		public frmMainMenu() {
			InitializeComponent();
		}

		private Usuario LogUser() {
			Usuario currentUsuario = this.usuario;
			
			if (currentUsuario == null) {
				frmLogin login = new frmLogin();

				switch (login.ShowDialog())
                {
					case DialogResult.OK: currentUsuario = login.usuario;
						break;

					case DialogResult.Cancel: Close();
						break;

					default: return null;
				}
				

			}
			return currentUsuario;
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
			frmABMCPruebas abmcPruebas = new frmABMCPruebas();
			abmcPruebas.ShowDialog();
		}

		private void btnExit_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void btnAdmContactos_Click(object sender, EventArgs e) {
			frmABMCContactos abmcContactos = new frmABMCContactos();
			abmcContactos.ShowDialog();
		}

		private void btnTransaccion_Click(object sender, EventArgs e) {
			frmFacturacion fact = new frmFacturacion(usuario);
			fact.ShowDialog();
		}

		private void btnSolicitarCicloPrueba_Click(object sender, EventArgs e) {
			frmNuevoCicloPrueba cic = new frmNuevoCicloPrueba(usuario);
			cic.ShowDialog();
		}

		private void btnReportes_Click(object sender, EventArgs e) {
			frmSeleccionReportes selec = new frmSeleccionReportes();
			selec.ShowDialog();
        }

		private void frmMainMenu_Load(object sender, EventArgs e) {
			usuario = LogUser();
			while (usuario == null) {
				MessageBox.Show("Acceso denegado");
				usuario = LogUser();
			}
		}

		private void btnEstadisticas_Click(object sender, EventArgs e) {
			frmSeleccionEstadisticas frmEs = new frmSeleccionEstadisticas();
			frmEs.ShowDialog();
		}
	}
}
