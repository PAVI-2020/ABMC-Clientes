using System;
using System.Windows.Forms;
using ABMC_Clientes.Business;
using ABMC_Clientes.Clases;

namespace ABMC_Clientes.GUI {
    public partial class frmABMCContactos : Form {
        ContactosBusiness cBus = new ContactosBusiness();

        enum State { None, Nuevo, Consultar }
        private State operacion;

        bool nuevo { get { return operacion == State.Nuevo; } }
        bool consultar { get { return operacion == State.Consultar; } }

        public frmABMCContactos() {
            InitializeComponent();
        }

        private void FormABMCContactos_Load(object sender, EventArgs e) {
            Habilitar(false);
            cargarGRD(grdContactos, cBus.Recuperar());
        }

        private void Habilitar(bool b) {
            txtApellido.Enabled = b;
            txtNombre.Enabled = b;
            txtMail.Enabled = b;
            txtId.Enabled = false;
            btnAceptar.Enabled = b;
            btnCancelar.Enabled = b;
            txtTelefono.Enabled = b;

            btnAgregarContacto.Enabled = btnEditarContacto.Enabled = btnEliminarContacto.Enabled = btnSalir.Enabled = btnConsultarContacto.Enabled = !b;
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            Habilitar(false);
            limpiarCampos();
            operacion = State.None;
        }

        private void limpiarCampos() {
            txtId.Text = txtNombre.Text = txtApellido.Text = txtMail.Text = txtTelefono.Text = "";
        }

        private void ActualizarCampos() {
            if (grdContactos.Rows.Count == 0 || grdContactos.SelectedRows.Count == 0)
                return;
            DataGridViewRow tabla = grdContactos.SelectedRows[0];
            txtId.Text = tabla.Cells[0].Value.ToString();
            txtNombre.Text = tabla.Cells[1].Value.ToString();
            txtApellido.Text = tabla.Cells[2].Value.ToString();
            txtMail.Text = tabla.Cells[3].Value.ToString();
            txtTelefono.Text = tabla.Cells[4].Value.ToString();
        }

        private void cargarGRD(DataGridView grilla, Contacto[] t) {
            grilla.Rows.Clear();
            for (int i = 0; i < t.Length; i++) {
                grilla.Rows.Add(t[i].Id_contacto, t[i].Nombre, t[i].Apellido, t[i].Email, t[i].Telefono);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAgregarContacto_Click(object sender, EventArgs e) {
            Habilitar(true);
            txtNombre.Focus();
            limpiarCampos();
            operacion = State.Nuevo;
        }

        private void grdContactos_SelectionChanged(object sender, EventArgs e) {
            ActualizarCampos();
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            if (nuevo) {
                if (txtApellido.Text == "" || txtMail.Text == "" || txtNombre.Text == "" || txtTelefono.Text == "") {
                    MessageBox.Show("Debe completar todos los campos", "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Focus();
                }
                else {
                    Contacto c = new Contacto(-1, txtNombre.Text, txtApellido.Text, txtMail.Text, txtTelefono.Text, false);
                    cBus.Insertar(c);
                    cargarGRD(grdContactos, cBus.Recuperar());
                }
            }
            else if (consultar) {
                Contacto c = new Contacto((txtId.Text=="") ? -1 : Convert.ToInt32(txtId.Text), txtNombre.Text, txtApellido.Text, txtMail.Text, txtTelefono.Text, false);
                // cargarGRD(grdContactos, cBus.Recuperar(c)); TODO: Filter
            }
            else {
                Contacto c = new Contacto(Convert.ToInt32(txtId.Text), txtNombre.Text, txtApellido.Text, txtMail.Text, txtTelefono.Text, false);
                cBus.Actualizar(c);
                cargarGRD(grdContactos, cBus.Recuperar());
            }

            operacion = State.None;
            Habilitar(false);
            ActualizarCampos();
        }

        private void btnEditarContacto_Click(object sender, EventArgs e) {
            Habilitar(true);
            txtNombre.Focus();
        }

        private void btnConsultarContacto_Click(object sender, EventArgs e) {
            Habilitar(true);
            txtId.Enabled = true;
            operacion = State.Consultar;
        }

        private void btnEliminarContacto_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Desea eliminar el contacto" + txtNombre.Text + " " + txtApellido.Text, "Eliminar contacto", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK) {
                cBus.Eliminar(Convert.ToInt32(txtId.Text));
                cargarGRD(grdContactos, cBus.Recuperar());
            }
        }
    }
}
