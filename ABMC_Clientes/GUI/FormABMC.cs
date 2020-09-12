using ABMC_Clientes.Business;
using ABMC_Clientes.Clases;
using System;
using System.Data;
using System.Windows.Forms;

namespace ABMC_Clientes {
	public partial class FormABMC : Form {
		public FormABMC() {
			InitializeComponent();
		}

		bool nuevo = false;

		private void Form1_Shown(object sender, System.EventArgs e) {
			Habilitar(false);

			ClienteBusiness cliente = new ClienteBusiness();
			
				CargarGrilla(grdClientes, cliente.ConsultarClientes());
		}

		void Habilitar(bool estado) {
			txtCalle.Enabled = estado;
			txtCuit.Enabled = estado;
			txtId.Enabled = false;
			txtFecha.Enabled = false;
			txtNumero.Enabled = estado;
			txtRazonSocial.Enabled = estado;
			btnAceptar.Enabled = estado;
			btnCancelar.Enabled = estado;
			cboBarrio.Enabled = estado;
			cboContacto.Enabled = estado;

			btnAgregar.Enabled = !estado;
			btnEditar.Enabled = !estado;
			btnEliminar.Enabled = !estado;
			btnConsultar.Enabled = !estado;
		}

		void CargarGrilla(DataGridView grid, Cliente[] datos) {
			foreach (Cliente c in datos) {
				grid.Rows.Add(
					c.Id, c.Cuit, c.RazonSocial, c.Calle, c.Numero, c.FechaAlta, c.Barrio, c.Contacto);
			}
		}

		private void btnSalir_Click(object sender, System.EventArgs e) {
			Close();
		}

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
			if (MessageBox.Show("¿Desea eliminar el cliente de cuit"+cboContacto.SelectedText+"?", "Eliminando usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
				Cliente cliente = new Cliente
				{
					Id = int.Parse(txtId.Text),
					Cuit = txtCuit.Text,
					RazonSocial = txtRazonSocial.Text,
					Calle = txtCalle.Text,
					Numero = txtNumero.Text,
					FechaAlta = DateTime.Parse(txtFecha.Text),
					Barrio = cboBarrio.Text,
					IdBarrio = (int)cboBarrio.SelectedValue,
					Contacto = cboContacto.Text,
					IdContacto = (int)cboContacto.SelectedValue,

				};

				ClienteBusiness oClienteBusiness = new ClienteBusiness();

				oClienteBusiness.Eliminar(cliente);
            }
        }

        private void label7_Click(object sender, System.EventArgs e)
        {

        }

		private void ActualizarCampos()
        {
			DataGridViewRow tabla = new DataGridViewRow();
			tabla = grdClientes.SelectedRows[0];
			txtId.Text = tabla.Cells[0].Value.ToString();
			txtCuit.Text = tabla.Cells[1].Value.ToString();
			txtRazonSocial.Text = tabla.Cells[2].Value.ToString();
			txtCalle.Text = tabla.Cells[3].Value.ToString();
			txtNumero.Text = tabla.Cells[4].Value.ToString();
			txtFecha.Text = tabla.Cells[5].Value.ToString();
			cboBarrio.SelectedText = tabla.Cells[6].Value.ToString();
			cboContacto.SelectedText = tabla.Cells[7].Value.ToString();

		}

		private void FormABMC_Load(object sender, System.EventArgs e)
		{
			this.dtpFecha.Visible = false;
        }

        private void grdClientes_SelectionChanged(object sender, EventArgs e)
        {
			this.ActualizarCampos();
        }

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			this.Habilitar(true);
			this.nuevo = true;
			this.limpiar();
			this.txtCuit.Focus();
			this.txtFecha.Text = DateTime.Today.ToString();
			this.txtFecha.Enabled = false;

        }

		public void limpiar()
        {
			txtId.Text = "";
			txtCuit.Text = "";
			txtCalle.Text = "";
			txtRazonSocial.Text = "";
			txtFecha.Text = "";
			txtNumero.Text = "";
			cboBarrio.SelectedIndex = -1;
			cboContacto.SelectedIndex = -1;

		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			Cliente cliente = new Cliente
			{
				Id = int.Parse(txtId.Text),
				Cuit = txtCuit.Text,
				RazonSocial = txtRazonSocial.Text,
				Calle = txtCalle.Text,
				Numero = txtNumero.Text,
				FechaAlta = DateTime.Today,
				Barrio = cboBarrio.Text,
				IdBarrio = (int)cboBarrio.SelectedValue,
				Contacto = cboContacto.Text,
				IdContacto = (int)cboContacto.SelectedValue,

			};

			ClienteBusiness cBusiness = new ClienteBusiness();

			if (nuevo)
			{
				if (txtId.Text == "" || txtCuit.Text == "" || txtCalle.Text == "" || txtRazonSocial.Text == "" || txtFecha.Text == "" || txtNumero.Text == "" || cboBarrio.SelectedIndex == -1 || cboContacto.SelectedIndex == -1)
				{
					MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK);
					txtId.Focus();
					return;
				}

				
				cBusiness.Insertar(cliente);

			}

            else
            {
				cliente.FechaAlta = dtpFecha.Value;
				cBusiness.ActualizarUsuario(cliente);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
			this.Habilitar(true);
			this.txtFecha.Visible = false;
			this.dtpFecha.Visible = true;
		}
    }
}
