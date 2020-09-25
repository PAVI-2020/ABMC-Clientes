using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ABMC_Clientes.GUI {
    public partial class frmFacturacion : Form {
        private Dictionary<int, string> proyectosName;
        private Dictionary<int, string> productosName;

        public frmFacturacion() {
            InitializeComponent();
            proyectosName = FetchProyectosName();
            productosName = FetchProductosName();
        }

        private Dictionary<int, string> FetchProyectosName() {
            throw new NotImplementedException();
		}

        private Dictionary<int, string> FetchProductosName() {
            throw new NotImplementedException();
        }

        private void CalcularTotal() {
            float total = 0;
            foreach (DataGridViewRow row in grdDetallesFactura.Rows) {
                total += float.Parse(row.Cells[3].Value.ToString());
            }

            txtTotal.Text = total.ToString();
        }

        private void cboTipoCobro_SelectedIndexChanged(object sender, EventArgs e) {
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

		private void btnAgregar_Click(object sender, EventArgs e) {
            string cobrado = "";

            switch (cboTipoCobro.SelectedIndex) {
                case 0:
                    cobrado = txtIdProducto.Text;
                    break;
                case 1:
                    cobrado = txtIdProyecto.Text;
                    break;
                case 2:
                    cobrado = txtIdCiclo.Text;
                    break;
            }

            grdDetallesFactura.Rows.Add(grdDetallesFactura.Rows.Count + 1, cboTipoCobro.Text, cobrado, txtPrecio.Text);
            CalcularTotal();
		}

		private void btnFacturar_Click(object sender, EventArgs e) {

		}

		private void txtIdProyecto_TextChanged(object sender, EventArgs e) {
            int id;
            if (int.TryParse(txtIdProyecto.Text, out id))
                txtNombreProy.Text = proyectosName[id];
            else
                txtNombreProy.Text = "-";
		}

		private void txtIdProducto_TextChanged(object sender, EventArgs e) {
            int id;
            if (int.TryParse(txtIdProducto.Text, out id))
                txtNombreProd.Text = productosName[id];
            else
                txtNombreProd.Text = "-";
        }
	}
}
