using ABMC_Clientes.DataAccess;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ABMC_Clientes.GUI {
	public partial class frmEstadisticaCantidadRecaudadoUsuario : Form {
		public frmEstadisticaCantidadRecaudadoUsuario() {
			InitializeComponent();
		}

		private void frmEstadisticaCantidadRecaudadoUsuario_Load(object sender, EventArgs e) {
			Datos Odato = new Datos();

			rpvCantDineroPorUsuario.LocalReport.DataSources.Clear();
			rpvCantDineroPorUsuario.LocalReport.DataSources.Add(new ReportDataSource("CantidadDineroUusario", Odato.ConsultarTabla("U.usuario, SUM(FD.precio) as 'Total'", "dbo.FacturasDetalle FD JOIN Facturas F on(FD.id_factura = F.id_factura) JOIN Usuarios U on(U.id_usuario = F.id_usuario_creador)", "FD.borrado = 0 and F.borrado = 0 GROUP BY U.usuario")));
			this.rpvCantDineroPorUsuario.RefreshReport();
		}

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (dtpFechaHasta.Value < dtpFechaDesde.Value)
            {
                MessageBox.Show("Seleccione una fecha maxima mayor a la fecha minima");
                dtpFechaHasta.Value = DateTime.Today;
            }
            else
            {
                Datos oDat = new Datos();

                rpvCantDineroPorUsuario.LocalReport.DataSources.Clear();

               rpvCantDineroPorUsuario.LocalReport.DataSources.Add(new ReportDataSource("dstEstadisticas", oDat.ConsultarTabla("U.usuario, SUM(FD.precio) as 'Total'", "dbo.FacturasDetalle FD JOIN Facturas F on(FD.id_factura = F.id_factura) JOIN Usuarios U on(U.id_usuario = F.id_usuario_creador)", "FD.borrado = 0 and F.borrado = 0 AND F.fecha BETWEEN '" + dtpFechaDesde.Value.ToString("yyyy-MM-dd hh:mm:ss") + "' AND '" + dtpFechaHasta.Value.ToString("yyyy-MM-dd hh:mm:ss") + "' GROUP BY U.Usuario")));
               rpvCantDineroPorUsuario.RefreshReport();

                List<ReportParameter> parameters = new List<ReportParameter> { new ReportParameter("prFiltros", "Filtrado entre " + dtpFechaDesde.Value.ToString() + " y " + dtpFechaHasta.Value.ToString()) };

               rpvCantDineroPorUsuario.LocalReport.SetParameters(parameters);

                this.rpvCantDineroPorUsuario.RefreshReport();
            }
        }
    }
}
