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

		private void pictureBox1_Click(object sender, EventArgs e) {

		}

		private void button1_Click(object sender, EventArgs e) {
			FormABMC abmcClientes = new FormABMC();
			abmcClientes.Show();
		}

		private void button1_Click_1(object sender, EventArgs e) {

		}

		private void btnAdmBarrios_Click(object sender, EventArgs e) {
			frmABMCBarrios abmcBarrios = new frmABMCBarrios();
			abmcBarrios.Show();
		}

		private void btnExit_Click(object sender, EventArgs e) {
			this.Close();
		}
	}
}
