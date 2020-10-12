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

namespace ABMC_Clientes.GUI
{
    public partial class frmReporteClientes : Form
    {
        public frmReporteClientes()
        {
            InitializeComponent();
        }

        private void frmReporteClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dstGeneral.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.dstGeneral.Clientes);

            this.reportViewer1.RefreshReport();
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
        
                clientesBindingSource.DataSource = oDat.ConsultarTabla("c.id_cliente, c.razon_social, c.cuit, c.calle, c.numero, c.fecha_alta, b.nombre as Barrio, Co.nombre + ' ' + Co.apellido as Contacto",
                                                                       "Clientes c Join Barrios b on(c.id_barrio = b.id_barrio) Join Contactos Co on(Co.id_contacto = c.id_contacto)",
                                                                       "borrado = 0 AND c.fecha_alta BETWEEN '" + dtpFechaDesde.Value.ToString("yyyy-MM-dd hh:mm:ss") + "' AND '" + dtpFechaHasta.Value.ToString("yyyy-MM-dd hh:mm:ss") + "'");
                this.reportViewer1.RefreshReport();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
