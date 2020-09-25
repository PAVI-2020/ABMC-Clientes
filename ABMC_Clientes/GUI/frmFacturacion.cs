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
    public partial class frmFacturacion : Form
    {
        public frmFacturacion()
        {
            InitializeComponent();
        }

        private void cboTipoCobro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdProducto.Enabled = (cboTipoCobro.SelectedIndex == 0);
            txtIdProyecto.Enabled = (cboTipoCobro.SelectedIndex == 1);
            txtIdCiclo.Enabled = (cboTipoCobro.SelectedIndex == 2);

            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            txtNombreProd.Enabled = false;
            txtNombreProy.Enabled = false;
            txtRazonSocial.Enabled = false;
            txtUsuario.Enabled = false;
            txtFecha.Text = DateTime.Now.ToString();
            txtFecha.Enabled = false;
        }
    }
}
