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
        Verificador verificadorDetalle = new Verificador();
        Verificador verificadorFactura = new Verificador();

        public frmFacturacion(Usuario usuario) {
            InitializeComponent();
            cboCiclo.Enabled = false;
            cboProducto.Enabled = false;
            cboProyecto.Enabled = false;
            Verificador.CargarComboOptions("Clientes", "id_cliente, razon_social", cboCliente);
            Verificador.CargarComboOptions("Proyectos", "id_proyecto, descripcion", cboProyecto);
            Verificador.CargarComboOptions("Productos", "id_producto, nombre", cboProducto);
            Verificador.CargarComboOptions("CiclosPrueba", "id_ciclo_prueba, fecha_inicio_ejecucion", cboCiclo);
            this.usuario = usuario;
            txtUsuario.Text = usuario.N_usuario;

            verificadorDetalle.Agregar("Precio", txtPrecio);
            verificadorDetalle.Agregar("Tipo Cobro", cboTipoCobro);

            verificadorFactura.Agregar("Numero Factura", txtNumeroFactura);
            verificadorFactura.Agregar("Cliente", cboCliente);
        }

        private void CalcularTotal() {
            float total = 0;
            foreach (DataGridViewRow row in grdDetallesFactura.Rows) {
                total += float.Parse(row.Cells[3].Value.ToString());
            }

            txtTotal.Text = total.ToString();
        }

        private void ClearFields() {
            cboCliente.SelectedIndex = -1;
            cboTipoCobro.SelectedIndex = -1;
            txtPrecio.Text = "";
            txtNumeroFactura.Text = "";
            grdDetallesFactura.Rows.Clear();
            cboCiclo.Enabled = false;
            cboProducto.Enabled = false;
            cboProyecto.Enabled = false;

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
            Verificador.CargarComboOptions("Clientes Where borrado = 0", "id_cliente, razon_social", cboCliente);
            Verificador.CargarComboOptions("Proyectos Where borrado = 0", "id_proyecto, descripcion", cboProyecto);
            Verificador.CargarComboOptions("Productos Where borrado = 0", "id_producto, nombre", cboProducto);
            Verificador.CargarComboOptions("CiclosPrueba Where borrado = 0", "id_ciclo_prueba, fecha_inicio_ejecucion", cboCiclo);
            txtUsuario.Enabled = false;
            txtFecha.Text = DateTime.Now.ToString();
            txtFecha.Enabled = false;
        }

		private void btnAgregar_Click(object sender, EventArgs e) {
            string cobrado = "";
            if ((cboProducto.Enabled && cboProducto.SelectedIndex == -1) ||
                (cboProyecto.Enabled && cboProyecto.SelectedIndex == -1) ||
                (cboCiclo.Enabled && cboCiclo.SelectedIndex == -1)) {
                MessageBox.Show("Seleccione el item a cobrar.", "Error", MessageBoxButtons.OK);
                return;
            } else if (verificadorDetalle.Verificar()) {
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

        }

		private void btnFacturar_Click(object sender, EventArgs e) {

            List<DetalleFactura> detalles = new List<DetalleFactura>();
            if (grdDetallesFactura.Rows.Count == 0) {
                MessageBox.Show("Agregue una factura previamente", "Error", MessageBoxButtons.OK);
                return;
            } else if (verificadorFactura.Verificar()) {
                foreach (DataGridViewRow dgrid in grdDetallesFactura.Rows) {
                    if ((string)dgrid.Cells[1].Value == "Por Producto") {
                        detalles.Add(new DetalleFactura(0, 0, Convert.ToInt32(dgrid.Cells[0].Value), Convert.ToInt32(dgrid.Cells[2].Value), -1, -1, Convert.ToDecimal(dgrid.Cells[3].Value), false));
                    } else if ((string)dgrid.Cells[1].Value == "Por Proyecto") {
                        detalles.Add(new DetalleFactura(0, 0, Convert.ToInt32(dgrid.Cells[0].Value), -1, Convert.ToInt32(dgrid.Cells[2].Value), -1, Convert.ToDecimal(dgrid.Cells[3].Value), false));
                    } else {
                        detalles.Add(new DetalleFactura(0, 0, Convert.ToInt32(dgrid.Cells[0].Value), -1, -1, Convert.ToInt32(dgrid.Cells[2].Value), Convert.ToDecimal(dgrid.Cells[3].Value), false));
                    }
                }

                Factura factura = new Factura(0, txtNumeroFactura.Text, Convert.ToInt32(cboCliente.SelectedValue), Convert.ToDateTime(txtFecha.Text), usuario.IdUsuario, false, cboCliente.SelectedText, txtUsuario.Text, detalles.ToArray());
                FacturaBusiness fbus = new FacturaBusiness();
                fbus.CrearFactura(factura);

                MessageBox.Show("La factura se ha realizado correctamente", "Facturacion", MessageBoxButtons.OK);

                ClearFields();
            }
		}

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            grdDetallesFactura.Rows.Remove(grdDetallesFactura.SelectedRows[0]);
        }

    }
}
