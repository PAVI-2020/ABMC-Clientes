using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMC_Clientes.GUI
{
    public partial class frmSeleccionReportes : Form
    {
        public frmSeleccionReportes()
        {
            InitializeComponent();
        }

        private void btnReporteClientes_Click(object sender, EventArgs e)
        {
            frmReporteClientes repo = new frmReporteClientes();
            repo.ShowDialog();
            this.Close();

        }

		private void btnReporteCiclos_Click(object sender, EventArgs e) {
           FormReporteCiclodePrueba repo = new FormReporteCiclodePrueba();
            repo.ShowDialog();
            this.Close();
        }

		private void btnReporteFacturas_Click(object sender, EventArgs e) {
            frmReporteFacturas repo = new frmReporteFacturas();
            repo.ShowDialog();
            Close();
		}

		private void btnDetalleCiclo_Click(object sender, EventArgs e) {
           FormReporteDetalleCiclo repo = new FormReporteDetalleCiclo();
            repo.ShowDialog();
            Close();
        }

		private void btnReportesPlanDePrueba_Click(object sender, EventArgs e) {
            frmReportePlanesDePrueba repo = new frmReportePlanesDePrueba();
            repo.ShowDialog();
            Close();
        }

		private void btnReporteProyectos_Click(object sender, EventArgs e) {
            frmReporteProyectos repo = new frmReporteProyectos();
            repo.ShowDialog();
            Close();
        }

		private void frmSeleccionReportes_Load(object sender, EventArgs e) {

		}
	}
}
