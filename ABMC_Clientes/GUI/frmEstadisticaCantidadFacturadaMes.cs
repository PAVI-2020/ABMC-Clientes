using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABMC_Clientes.DataAccess;
using Microsoft.Reporting.WinForms;

namespace ABMC_Clientes.GUI
{
    public partial class frmEstadisticaCantidadFacturadaMes : Form
    {
        public frmEstadisticaCantidadFacturadaMes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Datos odato = new Datos();

            rpvCantidadMes.LocalReport.DataSources.Clear();
            rpvCantidadMes.LocalReport.DataSources.Add(new ReportDataSource("dstEstadisticas", odato.ConsultarTabla("DATENAME(MONTH, DATEADD(MONTH, Month(f.fecha)-1, '1900-01-01')) as  mes, YEAR(f.fecha) as año, SUM(d.precio) as cobrado", "Facturas f JOIN FacturasDetalle d on (d.id_factura = f.id_factura)", "f.borrado = 0 and d.borrado = 0 Group by MONTH(f.fecha), YEAR(f.fecha)")));
            rpvCantidadMes.RefreshReport();
            this.rpvCantidadMes.RefreshReport();

            this.rpvCantidadMes.RefreshReport();
            this.rpvCantidadMes.RefreshReport();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dtpFechaHasta.Value < dtpFechaDesde.Value)
            {
                MessageBox.Show("Seleccione una fecha maxima mayor a la fecha minima");
                dtpFechaHasta.Value = DateTime.Today;
            }
            else
            {
                Datos oDat = new Datos();

                rpvCantidadMes.LocalReport.DataSources.Clear();

                rpvCantidadMes.LocalReport.DataSources.Add(new ReportDataSource("dstEstadisticas", oDat.ConsultarTabla("DATENAME(MONTH, DATEADD(MONTH, Month(f.fecha)-1, '1900-01-01')) as  mes, YEAR(f.fecha) as año, SUM(d.precio) as cobrado", "Facturas f JOIN FacturasDetalle d on (d.id_factura = f.id_factura)", "f.borrado = 0 and d.borrado = 0 AND f.fecha BETWEEN '"+dtpFechaDesde.Value.ToString("yyyy-MM-dd hh:mm:ss") +"' AND '"+dtpFechaHasta.Value.ToString("yyyy-MM-dd hh:mm:ss") +"' Group by MONTH(f.fecha), YEAR(f.fecha)")));
                rpvCantidadMes.RefreshReport();

                List<ReportParameter> parameters = new List<ReportParameter> { new ReportParameter("prFiltros", "Filtrado entre " + dtpFechaDesde.Value.ToString() + " y " + dtpFechaHasta.Value.ToString()) };

                rpvCantidadMes.LocalReport.SetParameters(parameters);

                this.rpvCantidadMes.RefreshReport();
            }
        }
    }
}
