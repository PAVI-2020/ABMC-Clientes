using ABMC_Clientes.Business;
using ABMC_Clientes.Clases;
using ABMC_Clientes.DataAccess;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ABMC_Clientes.GUI {
	public partial class frmReportePlanesDePrueba : Form {
		public frmReportePlanesDePrueba() {
			InitializeComponent();
		}

		private void frmReportePlanesDePrueba_Load(object sender, EventArgs e) {
			CargarCBO();

			Datos odato = new Datos();

			rpvPlanesDePrueba.LocalReport.DataSources.Clear();
			rpvPlanesDePrueba.LocalReport.DataSources.Add(new ReportDataSource("PlanesDePrueba", odato.ConsultarTabla("P.id_plan_prueba, P.id_proyecto, P.nombre, P.id_responsable, U.usuario, P.descripcion, P.borrado ", "dbo.PlanesDePrueba P JOIN Usuarios U on (U.id_usuario = P.id_responsable)")));
			this.rpvPlanesDePrueba.RefreshReport();
		}

		void CargarCBO() {
			UsuarioBusiness usuarioBusiness = new UsuarioBusiness();
			foreach (Usuario u in usuarioBusiness.Recuperar()) {
				cboUsuarios.Items.Add(u.N_usuario);
			}
		}

		private void btnSalir_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void btnImprimir_Click(object sender, EventArgs e) {
			Datos oDat = new Datos();

			rpvPlanesDePrueba.LocalReport.DataSources.Clear();
			rpvPlanesDePrueba.LocalReport.DataSources.Add(new ReportDataSource("PlanesDePrueba", oDat.ConsultarTabla("P.id_plan_prueba, P.id_proyecto, P.nombre, P.id_responsable, U.usuario, P.descripcion, P.borrado ", "dbo.PlanesDePrueba P JOIN Usuarios U on (U.id_usuario = P.id_responsable)", "P.borrado = 0 AND U.usuario = '" + cboUsuarios.Text + "'")));
			List<ReportParameter> parameters = new List<ReportParameter> { new ReportParameter("prFiltros", "Filtrado por el Usuario Responsable " + cboUsuarios.Text)};

			rpvPlanesDePrueba.LocalReport.SetParameters(parameters);
			this.rpvPlanesDePrueba.RefreshReport();
		}
	}
}
