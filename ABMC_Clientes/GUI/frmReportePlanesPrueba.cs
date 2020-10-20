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

namespace ABMC_Clientes.GUI
{
    public partial class frmReportePlanesPrueba : Form
    {
        public frmReportePlanesPrueba()
        {
            InitializeComponent();
        }

        private void frmReportePlanesPrueba_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'dstGeneral.CiclosPruebaDetalle' table. You can move, or remove it, as needed.
            this.PlanesDePruebaTableAdapter.Fill(this.dstGeneral.CiclosPruebaDetalle);

            // TODO: This line of code loads data into the 'dstGeneral.CiclosPrueba' table. You can move, or remove it, as needed.
            this.PlanesDePruebaTableAdapter.Fill(this.dstGeneral.CiclosPruebaDetalle);
            this.reportViewer1.RefreshReport();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Datos oDat = new Datos();

           PlanesDePruebaBindingSource.DataSource = oDat.ConsultarTabla("P.id_plan_prueba, P.id_proyecta, P.nombre, U.usuario as 'Nombre de Responsable', P.descripcion",
                                                                       "PlanesDePrueba P Join Usuarios U on(P.id_responsable = U.id_usuario) ",
                                                                       "d.borrado = 0 AND U.usuario  = '" + cboUsuariosResponsables.SelectedItem  + "'");
            List<ReportParameter> parameters = new List<ReportParameter> { new ReportParameter("prFiltros", "Filtrado por el Usuario Responsable " + cboUsuariosResponsables.SelectedItem.ToString())};

            reportViewer1.LocalReport.SetParameters(parameters);
            this.reportViewer1.RefreshReport();
        }
    }
}
