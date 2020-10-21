using ABMC_Clientes.DataAccess;
using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace ABMC_Clientes.GUI {
	public partial class frmEstadisticaCantidadRecaudadoUsuario : Form {
		public frmEstadisticaCantidadRecaudadoUsuario() {
			InitializeComponent();
		}

		private void frmEstadisticaCantidadRecaudadoUsuario_Load(object sender, EventArgs e) {
			Datos Odato = new Datos();

			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("CantidadDineroUusario", Odato.ConsultarTabla("U.usuario, SUM(FD.precio) as 'Total'", "dbo.FacturasDetalle FD JOIN Facturas F on(FD.id_factura = F.id_factura) JOIN Usuarios U on(U.id_usuario = F.id_usuario_creador) GROUP BY U.usuario")));
			this.reportViewer1.RefreshReport();
		}
	}
}
