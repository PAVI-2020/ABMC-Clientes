using System;
using System.Windows.Forms;

namespace ABMC_Clientes.GUI {
	public partial class frmSeleccionEstadisticas : Form {
		public frmSeleccionEstadisticas() {
			InitializeComponent();
		}

		private void btnEstadisticaPorcentajeBarrios_Click(object sender, EventArgs e) {
			FormPorcClientesBarrio repo = new FormPorcClientesBarrio();
			repo.ShowDialog();
		}

		private void btnCantHorasMes_Click(object sender, EventArgs e) {
			FormCantidadFacturadaMes repo = new FormCantidadFacturadaMes();
			repo.ShowDialog();
		}

		private void btnHorasUsuarioTester_Click(object sender, EventArgs e) {
			frmEstadisticaCantHorasUsuarioTester repo = new frmEstadisticaCantHorasUsuarioTester();
			repo.ShowDialog();
		}

		private void btnPorcentajeProyectosUsuario_Click(object sender, EventArgs e) {
			frmEstadisticaPorcentajeUsuariosProyectos repo = new frmEstadisticaPorcentajeUsuariosProyectos();
			repo.ShowDialog();
		}

		private void button5_Click(object sender, EventArgs e) {
			frmEstadisticaCantidadRecaudadoUsuario repo = new frmEstadisticaCantidadRecaudadoUsuario();
			repo.ShowDialog();
		}

		private void btnDistribucionFacturasporTipoDeCobro_Click(object sender, EventArgs e) {
			frmEstadisticaPorcentajeTipoCobros repo = new frmEstadisticaPorcentajeTipoCobros();
			repo.ShowDialog();
		}
	}
}
