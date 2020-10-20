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
	public partial class frmSeleccionEstadisticas : Form {
		public frmSeleccionEstadisticas() {
			InitializeComponent();
		}

		private void btnEstadisticaPorcentajeBarrios_Click(object sender, EventArgs e) {
			FormPorcClientesBarrio repo = new FormPorcClientesBarrio();
			repo.ShowDialog();
			Close();
		}

		private void btnCantHorasMes_Click(object sender, EventArgs e) {
			FormCantidadFacturadaMes repo = new FormCantidadFacturadaMes();
			repo.ShowDialog();
			Close();
		}

		private void btnHorasUsuarioTester_Click(object sender, EventArgs e) {
			frmEstadisticaCantHorasUsuarioTester repo = new frmEstadisticaCantHorasUsuarioTester();
			repo.ShowDialog();
			Close();
		}

		private void btnPorcentajeProyectosUsuario_Click(object sender, EventArgs e) {
			frmEstadisticaPorcentajeUsuariosProyectos repo = new frmEstadisticaPorcentajeUsuariosProyectos();
			repo.ShowDialog();
			Close();
		}

		private void button5_Click(object sender, EventArgs e) {
			frmEstadisticaCantidadRecaudadoUsuario repo = new frmEstadisticaCantidadRecaudadoUsuario();
			repo.ShowDialog();
			Close();
		}

		private void btnDistribucionFacturasporTipoDeCobro_Click(object sender, EventArgs e) {
			frmEstadisticaPorcentajeTipoCobros repo = new frmEstadisticaPorcentajeTipoCobros();
			repo.ShowDialog();
			Close();
		}
	}
}
