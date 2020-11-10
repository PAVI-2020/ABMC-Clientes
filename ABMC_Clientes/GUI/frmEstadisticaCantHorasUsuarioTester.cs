using ABMC_Clientes.DataAccess;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ABMC_Clientes.GUI {
	public partial class frmEstadisticaCantHorasUsuarioTester : Form {
		public frmEstadisticaCantHorasUsuarioTester() {
			InitializeComponent();
		}

		private void frmEstadisticaCantHorasUsuarioTester_Load(object sender, EventArgs e) {
			Datos Odato = new Datos();

			rpvCantHorasUsuario.LocalReport.DataSources.Clear();
			rpvCantHorasUsuario.LocalReport.DataSources.Add(new ReportDataSource("dstEstadistica", Odato.ConsultarTabla("U.usuario, SUM(C.cantidad_horas) AS 'Total_horas'", " CiclosPruebaDetalle C JOIN Usuarios U on (C.id_usuario_tester = U.id_usuario)", "C.borrado = 0 GROUP BY U.usuario")));
			rpvCantHorasUsuario.RefreshReport();
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

                    rpvCantHorasUsuario.LocalReport.DataSources.Clear();

                    rpvCantHorasUsuario.LocalReport.DataSources.Add(new ReportDataSource("dstEstadistica", oDat.ConsultarTabla("U.usuario, SUM(C.cantidad_horas) AS 'Total_horas'", " CiclosPruebaDetalle C JOIN Usuarios U on (C.id_usuario_tester = U.id_usuario)", "C.borrado = 0  AND C.fecha_ejecucion BETWEEN '" + dtpFechaDesde.Value.ToString("yyyy-MM-dd hh:mm:ss") + "' AND '" + dtpFechaHasta.Value.ToString("yyyy-MM-dd hh:mm:ss") + "' GROUP BY U.usuario")));
                    rpvCantHorasUsuario.RefreshReport();

                    List<ReportParameter> parameters = new List<ReportParameter> { new ReportParameter("prFiltros", "Filtrado entre " + dtpFechaDesde.Value.ToString() + " y " + dtpFechaHasta.Value.ToString()) };

                   rpvCantHorasUsuario.LocalReport.SetParameters(parameters);

                    this.rpvCantHorasUsuario.RefreshReport();
                }
            }

		private void btnExit_Click(object sender, EventArgs e) {
            Close();
		}
	}
}
