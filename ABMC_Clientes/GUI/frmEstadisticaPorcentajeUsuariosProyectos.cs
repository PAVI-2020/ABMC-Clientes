using ABMC_Clientes.DataAccess;
using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace ABMC_Clientes.GUI {
	public partial class frmEstadisticaPorcentajeUsuariosProyectos : Form {
		public frmEstadisticaPorcentajeUsuariosProyectos() {
			InitializeComponent();
		}

		private void frmEstadisticaPorcentajeUsuariosProyectos_Load(object sender, EventArgs e) {
			Datos Odato = new Datos();

			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("PorcentajeProyectoUsuario", Odato.ConsultarTabla("P.descripcion, (CONVERT(float, COUNT(P.id_responsable)) / (SELECT(CONVERT(float, COUNT(*))) FROM Proyectos)) * 100 AS Porcentaje", "dbo.Proyectos P JOIN Usuarios U on (U.id_usuario = P.id_responsable) GROUP BY P.descripcion")));
			this.reportViewer1.RefreshReport();
		}
	}
}
