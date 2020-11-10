using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ABMC_Clientes.DataAccess;
using Microsoft.Reporting.WinForms;

namespace ABMC_Clientes.GUI
{
    public partial class frmEstadisticaPorcClientesBarrio : Form
    {
        public frmEstadisticaPorcClientesBarrio()
        {
            InitializeComponent();
        }

        private void FormPorcClientesBarrio_Load(object sender, EventArgs e)
        {
            Datos odato = new Datos();

            rpvPorcClientes.LocalReport.DataSources.Clear();
            rpvPorcClientes.LocalReport.DataSources.Add(new ReportDataSource("dstEstadisticas", odato.ConsultarTabla("b.Nombre, (CONVERT(float, COUNT(c.id_cliente)) / (SELECT(CONVERT(float, COUNT(*))) FROM Clientes WHERE borrado = 0)) * 100 AS Porcentaje", "Clientes c JOIN Barrios b on(c.id_barrio = b.id_barrio)", "c.borrado = 0 and b.borrado = 0 GROUP BY b.nombre")));
            rpvPorcClientes.RefreshReport();
        }

		private void btnFiltrar_Click(object sender, EventArgs e) {
            if (dtpFechaHasta.Value < dtpFechaDesde.Value) {
                MessageBox.Show("Seleccione una fecha maxima mayor a la fecha minima");
                dtpFechaHasta.Value = DateTime.Today;
            } else {
                Datos oDat = new Datos();

                rpvPorcClientes.LocalReport.DataSources.Clear();

                rpvPorcClientes.LocalReport.DataSources.Add(new ReportDataSource("dstEstadisticas", oDat.ConsultarTabla("b.Nombre, (CONVERT(float, COUNT(c.id_cliente)) / (SELECT(CONVERT(float, COUNT(*))) FROM Clientes WHERE borrado = 0)) * 100 AS Porcentaje", "Clientes c JOIN Barrios b on(c.id_barrio = b.id_barrio)", "c.borrado = 0 and b.borrado = 0 AND fecha_alta BETWEEN '" + dtpFechaDesde.Value.ToString("yyyy-MM-dd hh:mm:ss") + "' AND '" + dtpFechaHasta.Value.ToString("yyyy-MM-dd hh:mm:ss") + "' GROUP BY b.nombre")));
                rpvPorcClientes.RefreshReport();

                List<ReportParameter> parameters = new List<ReportParameter> { new ReportParameter("prFiltros", "Filtrado entre " + dtpFechaDesde.Value.ToString() + " y " + dtpFechaHasta.Value.ToString()) };

                rpvPorcClientes.LocalReport.SetParameters(parameters);

                this.rpvPorcClientes.RefreshReport();
            }
        }

		private void btnExit_Click(object sender, EventArgs e) {
            Close();
		}
	}
}
