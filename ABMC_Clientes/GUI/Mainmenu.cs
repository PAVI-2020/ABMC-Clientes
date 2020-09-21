using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMC_Clientes.GUI {
	public partial class frmMainMenu : Form {
		public frmMainMenu() {
			InitializeComponent();
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

        private void btnAdmContactos_Click(object sender, EventArgs e)
        {
			FormABMCContactos abmcContactos = new FormABMCContactos();
			abmcContactos.ShowDialog();
        }
    }
}
