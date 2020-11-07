using ABMC_Clientes.Business;
using ABMC_Clientes.Clases;
using ABMC_Clientes.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ABMC_Clientes.GUI {
    public partial class frmFacturacion : Form {
        public Usuario usuario;

        private Dictionary<int, string> proyectosName;
        private Dictionary<int, string> productosName;
        private Dictionary<int, string> razonesSociales;

        public frmFacturacion(Usuario usuario) {
            InitializeComponent();
            CargarComboOptions("Proyectos", "id_proyecto, descripcion", cboProyecto);
            CargarComboOptions("Productos", "id_producto, nombre", cboProducto);
            CargarComboOptions("CiclosPrueba", "id_ciclo_prueba, fecha_inicio_ejecucion", cboCiclo);
            this.usuario = usuario;
            txtUsuario.Text = usuario.N_usuario;
        }

        

        private void CalcularTotal() {
            float total = 0;
            foreach (DataGridViewRow row in grdDetallesFactura.Rows) {
                total += float.Parse(row.Cells[3].Value.ToString());
            }

            txtTotal.Text = total.ToString();
        }

        private void ClearFields() {
            txtIdCliente.Text = "";
            cboTipoCobro.SelectedIndex = -1;
            txtPrecio.Text = "";
            txtNumeroFactura.Text = "";
            grdDetallesFactura.Rows.Clear();
        }

        private void cboTipoCobro_SelectedIndexChanged(object sender, EventArgs e) {
            cboProducto.Enabled = (cboTipoCobro.SelectedIndex == 0);
            cboProyecto.Enabled = (cboTipoCobro.SelectedIndex == 1);
            cboCiclo.Enabled = (cboTipoCobro.SelectedIndex == 2);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            CargarComboOptions("Proyectos", "id_proyecto, descripcion", cboProyecto);
            CargarComboOptions("Productos", "id_producto, nombre", cboProducto);
            CargarComboOptions("CiclosPrueba", "id_ciclo_prueba, fecha_inicio_ejecucion", cboCiclo);
            txtRazonSocial.Enabled = false;
            txtUsuario.Enabled = false;
            txtFecha.Text = DateTime.Now.ToString();
            txtFecha.Enabled = false;
        }

		private void btnAgregar_Click(object sender, EventArgs e) {
            string cobrado = "";
            if (
                (cboProducto.Enabled && cboProducto.SelectedIndex == -1) || 
                (cboProyecto.Enabled && cboProyecto.SelectedIndex == -1) || 
                (cboCiclo.Enabled && cboCiclo.SelectedIndex == -1) || 
                (txtPrecio.Text == "") ||
                (txtNumeroFactura.Text == "") ||
                (txtIdCliente.Text == "") ||
                (cboTipoCobro.SelectedIndex == -1)
                )
                {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK);
                return;
                }
            switch (cboTipoCobro.SelectedIndex) {
                case 0:
                    cobrado = cboProducto.SelectedValue.ToString();
                    break;
                case 1:
                    cobrado = cboProyecto.SelectedValue.ToString();
                    break;
                case 2:
                    cobrado = cboCiclo.SelectedValue.ToString();
                    break;
            }

            grdDetallesFactura.Rows.Add(grdDetallesFactura.Rows.Count + 1, cboTipoCobro.Text, cobrado, txtPrecio.Text);
            CalcularTotal();
            cboProducto.SelectedIndex = -1;
            cboProyecto.SelectedIndex = -1;
            cboCiclo.SelectedIndex = -1;

        }

		private void btnFacturar_Click(object sender, EventArgs e) {

            List<DetalleFactura> detalles = new List<DetalleFactura>();
            if (
                    grdDetallesFactura.Rows.Count == 0
               )
            {
                MessageBox.Show("Agregue una factura previamente", "Error", MessageBoxButtons.OK);
                return;
            }
            foreach (DataGridViewRow dgrid in grdDetallesFactura.Rows)
            {
                if ((string)dgrid.Cells[1].Value == "Por Producto") {
                    detalles.Add(new DetalleFactura(0, 0, Convert.ToInt32(dgrid.Cells[0].Value), Convert.ToInt32(dgrid.Cells[2].Value), -1, -1, Convert.ToDecimal(dgrid.Cells[3].Value), false));
                         }
                else if((string)dgrid.Cells[1].Value == "Por Proyecto")
                    {
                        detalles.Add(new DetalleFactura(0, 0, Convert.ToInt32(dgrid.Cells[0].Value), -1, Convert.ToInt32(dgrid.Cells[2].Value), -1, Convert.ToDecimal(dgrid.Cells[3].Value), false));
                    }

                else
                {
                    detalles.Add(new DetalleFactura(0, 0, Convert.ToInt32(dgrid.Cells[0].Value), -1,  -1, Convert.ToInt32(dgrid.Cells[2].Value), Convert.ToDecimal(dgrid.Cells[3].Value), false));
                }
            }

            
            Factura factura = new Factura(0, txtNumeroFactura.Text, Convert.ToInt32(txtIdCliente.Text), Convert.ToDateTime(txtFecha.Text), usuario.IdUsuario, false, txtRazonSocial.Text, txtUsuario.Text, detalles.ToArray());
            FacturaBusiness fbus = new FacturaBusiness();
            fbus.CrearFactura(factura);

            MessageBox.Show("La factura se ha realizado correctamente", "Facturacion", MessageBoxButtons.OK);

            ClearFields();
		}

		private void txtIdCliente_TextChanged(object sender, EventArgs e) {
            int id;
            if (int.TryParse(txtIdCliente.Text, out id) && razonesSociales.ContainsKey(id))
                txtRazonSocial.Text = razonesSociales[id];
            else
                txtRazonSocial.Text = "-";
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            grdDetallesFactura.Rows.Remove(grdDetallesFactura.SelectedRows[0]);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        public void CargarComboOptions(string tabla, string columnas, ComboBox cmb)
        {
            Datos datos = new Datos();

            DataTable table = datos.ConsultarTabla(columnas, tabla);
            cmb.DataSource = table;
            cmb.DisplayMember = table.Columns[1].ColumnName;
            cmb.ValueMember = table.Columns[0].ColumnName;

            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb.SelectedIndex = -1;
            cmb.SelectedValue = -1;
        }

    }
}
