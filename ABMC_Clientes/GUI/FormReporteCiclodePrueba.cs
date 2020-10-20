using ABMC_Clientes.DataAccess;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ABMC_Clientes.GUI {
	public partial class FormReporteCiclodePrueba : Form {
		public FormReporteCiclodePrueba() {
			InitializeComponent();
		}

		private void FormReporteCiclodePrueba_Load(object sender, EventArgs e) {
			// TODO: This line of code loads data into the 'dstGeneral.CiclosPrueba' table. You can move, or remove it, as needed.
			this.ciclosPruebaTableAdapter.Fill(this.dstGeneral.CiclosPrueba);
			this.reportViewer1.RefreshReport();
		}

		private void btnExit_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void btnFiltrar_Click(object sender, EventArgs e) {
			if (dtpFechaHasta.Value < dtpFechaDesde.Value) {
				MessageBox.Show("Seleccione una fecha maxima mayor a la fecha minima");
				dtpFechaHasta.Value = DateTime.Today;
			} else {
				Datos oDat = new Datos();

				CicloPruebaBindingSource.DataSource = oDat.ConsultarTabla("c.id_ciclo_prueba, c.fecha_inicio_ejecucion, c.fecha_fin_ejecucion, U.usuario, P.nombre, c.aceptado",
																	   "CiclosPrueba c Join PlanesDePrueba P on(c.id_plan_prueba = P.id_plan_prueba) Join Usuarios U on(c.id_responsable = U.id_usuario)",
																	   "c.borrado = 0 AND c.fecha_inicio_ejecucion BETWEEN '" + dtpFechaDesde.Value.ToString("yyyy-MM-dd hh:mm:ss") + "' AND '" + dtpFechaHasta.Value.ToString("yyyy-MM-dd hh:mm:ss") + "'");
				List<ReportParameter> parameters = new List<ReportParameter> { new ReportParameter("prFiltros", "Filtrado entre " + dtpFechaDesde.Value.ToString() + " y " + dtpFechaHasta.Value.ToString()) };

				reportViewer1.LocalReport.SetParameters(parameters);
				this.reportViewer1.RefreshReport();
			}
		}

		private void gbFiltrarFechas_Enter(object sender, EventArgs e) {

		}
	}
}
