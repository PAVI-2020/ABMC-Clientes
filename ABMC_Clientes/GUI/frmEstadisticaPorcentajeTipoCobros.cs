using ABMC_Clientes.DataAccess;
using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace ABMC_Clientes.GUI {
	public partial class frmEstadisticaPorcentajeTipoCobros : Form {
		public frmEstadisticaPorcentajeTipoCobros() {
			InitializeComponent();
		}

		private void frmEstadisticaPorcentajeTipoCobros_Load(object sender, EventArgs e) {
			Datos Odato = new Datos();

			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("PorcentajeTipoCobro", Odato.ConsultarTabla("(CONVERT(float,COUNT(id_ciclo_prueba))/(CONVERT(float,COUNT(*)))) as 'ciclos', (CONVERT(float,COUNT(id_producto))/(CONVERT(float,COUNT(*)))) as productos, (CONVERT(float,COUNT(id_proyecto))/(CONVERT(float,COUNT(*)))) as proyectos", "FacturasDetalle F")));
			this.reportViewer1.RefreshReport();
		}

		private void btnFiltrar_Click(object sender, EventArgs e) {

		}
	}
}
