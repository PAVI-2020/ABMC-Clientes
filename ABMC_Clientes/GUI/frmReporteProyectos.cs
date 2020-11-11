using ABMC_Clientes.Business;
using ABMC_Clientes.Clases;
using ABMC_Clientes.DataAccess;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ABMC_Clientes.GUI {
	public partial class frmReporteProyectos : Form {
		public frmReporteProyectos() {
			InitializeComponent();
		}

		private void frmReporteProyectos_Load(object sender, EventArgs e) {
			Verificador.CargarComboOptions("Usuarios WHERE borrado = 0", "id_usuario, usuario", cboUsuarios);

			Datos odato = new Datos();

			rpvProyectos.LocalReport.DataSources.Clear();
			rpvProyectos.LocalReport.DataSources.Add(new ReportDataSource("Proyectos", odato.ConsultarTabla("P.id_proyecto, P.id_producto, P.descripcion, P.version, P.alcance, P.id_responsable, U.usuario, P.borrado", "dbo.Proyectos P JOIN Usuarios U on (U.id_usuario = P.id_responsable)")));
			this.rpvProyectos.RefreshReport();
		}

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
			Datos oDat = new Datos();

			rpvProyectos.LocalReport.DataSources.Clear();
			rpvProyectos.LocalReport.DataSources.Add(new ReportDataSource("Proyectos", oDat.ConsultarTabla("P.id_proyecto, P.id_producto, P.descripcion, P.version, P.alcance, P.id_responsable, U.usuario, P.borrado", "dbo.Proyectos P JOIN Usuarios U on (U.id_usuario = P.id_responsable)", "P.borrado = 0 AND U.usuario = '" + cboUsuarios.Text + "'")));
			List<ReportParameter> parameters = new List<ReportParameter> { new ReportParameter("prFiltros", "Filtrado por el Usuario Responsable " + cboUsuarios.Text) };

			rpvProyectos.LocalReport.SetParameters(parameters);
			this.rpvProyectos.RefreshReport();
		}

        private void btnExit_Click(object sender, EventArgs e)
        {
			this.Close();
		}
    }
}
