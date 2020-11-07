using ABMC_Clientes.DataAccess;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ABMC_Clientes.GUI {
	public partial class frmEstadisticaPorcentajeTipoCobros : Form {
		public frmEstadisticaPorcentajeTipoCobros() {
			InitializeComponent();
		}

		private void frmEstadisticaPorcentajeTipoCobros_Load(object sender, EventArgs e) {
			Datos Odato = new Datos();

			rpvPorcentajeTipoCobroFacturas.LocalReport.DataSources.Clear();
			rpvPorcentajeTipoCobroFacturas.LocalReport.DataSources.Add(new ReportDataSource("PorcentajeTipoCobro", Odato.ConsultarTabla("(CONVERT(float,COUNT(id_ciclo_prueba))/(CONVERT(float,COUNT(*)))) as 'ciclos', (CONVERT(float,COUNT(id_producto))/(CONVERT(float,COUNT(*)))) as productos, (CONVERT(float,COUNT(id_proyecto))/(CONVERT(float,COUNT(*)))) as proyectos", "FacturasDetalle F JOIN Facturas Fa on (F.id_factura = Fa.id_factura)")));
			this.rpvPorcentajeTipoCobroFacturas.RefreshReport();
		}

		private void btnFiltrar_Click(object sender, EventArgs e) {
            if (dtpFechaHasta.Value < dtpFechaDesde.Value)
            {
                MessageBox.Show("Seleccione una fecha maxima mayor a la fecha minima");
                dtpFechaHasta.Value = DateTime.Today;
            }
            else
            {
                Datos oDat = new Datos();

                rpvPorcentajeTipoCobroFacturas.LocalReport.DataSources.Clear();

                rpvPorcentajeTipoCobroFacturas.LocalReport.DataSources.Add(new ReportDataSource("dstEstadisticas", oDat.ConsultarTabla("(CONVERT(float,COUNT(id_ciclo_prueba))/(CONVERT(float,COUNT(*)))) as 'ciclos', (CONVERT(float,COUNT(id_producto))/(CONVERT(float,COUNT(*)))) as productos, (CONVERT(float,COUNT(id_proyecto))/(CONVERT(float,COUNT(*)))) as proyectos", "FacturasDetalle F JOIN Facturas Fa on (F.id_factura = Fa.id_factura)", "F.borrado = 0 AND Fa.borrado = 0 AND Fa.fecha BETWEEN '" + dtpFechaDesde.Value.ToString("yyyy-MM-dd hh:mm:ss") + "' AND '" + dtpFechaHasta.Value.ToString("yyyy-MM-dd hh:mm:ss")+"'")));
                rpvPorcentajeTipoCobroFacturas.RefreshReport();

                List<ReportParameter> parameters = new List<ReportParameter> { new ReportParameter("prFiltros", "Filtrado entre " + dtpFechaDesde.Value.ToString() + " y " + dtpFechaHasta.Value.ToString()) };

                rpvPorcentajeTipoCobroFacturas.LocalReport.SetParameters(parameters);

                this.rpvPorcentajeTipoCobroFacturas.RefreshReport();
            }
        }
	}
}
