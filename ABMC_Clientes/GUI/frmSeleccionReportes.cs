using System;
using System.Windows.Forms;

namespace ABMC_Clientes.GUI {
    public partial class frmSeleccionReportes : Form {
        public frmSeleccionReportes() {
            InitializeComponent();
        }

        private void btnReporteClientes_Click(object sender, EventArgs e) {
            frmReporteClientes repo = new frmReporteClientes();
            repo.ShowDialog();
        }

		private void btnReporteCiclos_Click(object sender, EventArgs e) {
           frmReporteCiclodePrueba repo = new frmReporteCiclodePrueba();
            repo.ShowDialog();
        }

		private void btnReporteFacturas_Click(object sender, EventArgs e) {
            frmReporteFacturas repo = new frmReporteFacturas();
            repo.ShowDialog();
		}

		private void btnDetalleCiclo_Click(object sender, EventArgs e) {
           frmReporteDetalleCiclo repo = new frmReporteDetalleCiclo();
           repo.ShowDialog();
        }

		private void btnReportesPlanDePrueba_Click(object sender, EventArgs e) {
            frmReportePlanesDePrueba repo = new frmReportePlanesDePrueba();
            repo.ShowDialog();
        }

		private void btnReporteProyectos_Click(object sender, EventArgs e) {
            frmReporteProyectos repo = new frmReporteProyectos();
            repo.ShowDialog();
        }
	}
}
