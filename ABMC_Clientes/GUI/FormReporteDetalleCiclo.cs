using ABMC_Clientes.DataAccess;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ABMC_Clientes.GUI {
	public partial class FormReporteDetalleCiclo : Form {
		public FormReporteDetalleCiclo() {
			InitializeComponent();
		}

		private void FormReporteDetalleCiclo_Load(object sender, EventArgs e) {
			// TODO: This line of code loads data into the 'dstGeneral.CiclosPruebaDetalle' table. You can move, or remove it, as needed.
			this.ciclosPruebaDetalleTableAdapter.Fill(this.dstGeneral.CiclosPruebaDetalle);
			dtpFechaDesde.Value = DateTime.Today;

			// TODO: This line of code loads data into the 'dstGeneral.CiclosPrueba' table. You can move, or remove it, as needed.
			this.ciclosPruebaDetalleTableAdapter.Fill(this.dstGeneral.CiclosPruebaDetalle);
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

				CiclosPruebaDetalleBindingSource.DataSource = oDat.ConsultarTabla("d.id_ciclo_prueba_detalle, d.id_ciclo_prueba, C.titulo, U.usuario as 'Usuario Tester', d.cantidad_horas, d.fecha_ejecucion, d.aceptado",
																		   "CiclosPruebaDetalle d Join CasosDePrueba C on(c.id_caso_prueba = d.id_caso_prueba) Join Usuarios U on(c.id_usuario_tester = U.id_usuario)",
																		   "d.borrado = 0 AND d.fecha_ejecucion  BETWEEN '" + dtpFechaDesde.Value.ToString("yyyy-MM-dd hh:mm:ss") + "' AND '" + dtpFechaHasta.Value.ToString("yyyy-MM-dd hh:mm:ss") + "'");
					List<ReportParameter> parameters = new List<ReportParameter> { new ReportParameter("prFiltros", "Filtrado entre " + dtpFechaDesde.Value.ToString() + " y " + dtpFechaHasta.Value.ToString()) };

				reportViewer1.LocalReport.SetParameters(parameters);
				this.reportViewer1.RefreshReport();
			}
		}
	}
}
