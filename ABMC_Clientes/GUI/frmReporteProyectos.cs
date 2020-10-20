using ABMC_Clientes.Business;
using ABMC_Clientes.Clases;
using ABMC_Clientes.DataAccess;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMC_Clientes.GUI {
	public partial class frmReporteProyectos : Form {
		public frmReporteProyectos() {
			InitializeComponent();
		}

		private void frmReporteProyectos_Load(object sender, EventArgs e) {
			CargarCBO();

			Datos odato = new Datos();

			rpvProyectos.LocalReport.DataSources.Clear();
			rpvProyectos.LocalReport.DataSources.Add(new ReportDataSource("Proyectos", odato.ConsultarTabla("P.id_proyecto, P.id_producto, P.descripcion, P.version, P.alcance, P.id_responsable, U.usuario, P.borrado", "dbo.Proyectos P JOIN Usuarios U on (U.id_usuario = P.id_responsable)")));
			this.rpvProyectos.RefreshReport();
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

			rpvProyectos.LocalReport.DataSources.Clear();
			rpvProyectos.LocalReport.DataSources.Add(new ReportDataSource("Proyectos", oDat.ConsultarTabla("P.id_proyecto, P.id_producto, P.descripcion, P.version, P.alcance, P.id_responsable, U.usuario, P.borrado", "dbo.Proyectos P JOIN Usuarios U on (U.id_usuario = P.id_responsable)", "P.borrado = 0 AND U.usuario = '" + cboUsuarios.Text + "'")));
			List<ReportParameter> parameters = new List<ReportParameter> { new ReportParameter("prFiltros", "Filtrado por el Usuario Responsable " + cboUsuarios.Text)};

			rpvProyectos.LocalReport.SetParameters(parameters);
			this.rpvProyectos.RefreshReport();
		}
	}
}
