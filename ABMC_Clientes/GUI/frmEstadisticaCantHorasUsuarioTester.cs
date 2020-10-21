using ABMC_Clientes.DataAccess;
using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace ABMC_Clientes.GUI {
	public partial class frmEstadisticaCantHorasUsuarioTester : Form {
		public frmEstadisticaCantHorasUsuarioTester() {
			InitializeComponent();
		}

		private void frmEstadisticaCantHorasUsuarioTester_Load(object sender, EventArgs e) {
			Datos Odato = new Datos();

			rpvCantHorasUsuario.LocalReport.DataSources.Clear();
			rpvCantHorasUsuario.LocalReport.DataSources.Add(new ReportDataSource("HorasPorUsuarioTester", Odato.ConsultarTabla("U.usuario, SUM(C.cantidad_horas) AS 'Total_horas'", " CiclosPruebaDetalle C JOIN Usuarios U on (C.id_usuario_tester = U.id_usuario)", "C.borrado = 0 GROUP BY U.usuario")));
			rpvCantHorasUsuario.RefreshReport();
		}
	}
}
