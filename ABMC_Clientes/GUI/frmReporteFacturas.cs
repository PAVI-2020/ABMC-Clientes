using System;
using System.Windows.Forms;
using ABMC_Clientes.DataAccess;

namespace ABMC_Clientes.GUI
{
    public partial class frmReporteFacturas : Form
    {
        public frmReporteFacturas()
        {
            InitializeComponent();
        }

        private void frmReporteFacturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dstGeneral.Facturas' Puede moverla o quitarla según sea necesario.
            this.facturasTableAdapter.Fill(this.dstGeneral.Facturas);

            this.reportViewer1.RefreshReport();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

                facturasBindingSource.DataSource = oDat.ConsultarTabla("f.id_factura, f.numero_factura, c.razon_social as cliente, f.fecha, u.usuario as usuario_creador, (SELECT SUM(precio) from FacturasDetalle fd where f.id_factura = fd.id_factura) as Total, f.borrado",
                                                                       "from Facturas f join Usuarios u on(f.id_usuario_creador = u.id_usuario) join clientes c on(f.id_cliente = c.id_cliente)",
                                                                       "WHERE f.borrado = 0 AND c.fecha_alta BETWEEN '" + dtpFechaDesde.Value.ToString("yyyy-MM-dd hh:mm:ss") + "' AND '" + dtpFechaHasta.Value.ToString("yyyy-MM-dd hh:mm:ss") + "'");
                this.reportViewer1.RefreshReport();
            }
        }

		private void btnSalir_Click(object sender, EventArgs e) {
            Close();
		}
	}
}
