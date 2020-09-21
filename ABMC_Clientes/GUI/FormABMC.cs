using ABMC_Clientes.Business;
using ABMC_Clientes.Clases;
using ABMC_Clientes.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ABMC_Clientes {
	public partial class FormABMC : Form {
		enum State { None, Nuevo, Consultar }
		private State operacion;

		bool nuevo { get { return operacion == State.Nuevo; } }
		bool consultar { get { return operacion == State.Consultar; } }

		public FormABMC() {
			InitializeComponent();
		}

		private void Form1_Shown(object sender, System.EventArgs e) {
			Habilitar(false);
			RefreshData();
			ActualizarCampos();
		}

		void RefreshData() {
			ClienteBusiness cliente = new ClienteBusiness();
			Cliente[] clientes = cliente.ConsultarClientes();
			grdClientes.Rows.Clear();
			CargarGrilla(grdClientes, clientes);
			CargarComboOptions("Barrios", "id_barrio, nombre", cboBarrio);
			CargarComboOptions("Contactos", "id_contacto, nombre + ' ' + apellido", cboContacto);
		}

		void Habilitar(bool estado) {
			txtCalle.Enabled = estado;
			txtCuit.Enabled = estado;
			txtId.Enabled = false;
			dtpFecha.Enabled = false;
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
			grid.Rows.Clear();
			if (datos == null)
				return;
			foreach (Cliente c in datos) {
				grid.Rows.Add(
					c.Id, c.Cuit, c.RazonSocial, c.Calle, c.Numero, c.FechaAlta, c.Barrio, c.Contacto);
			}
		}

		private void ActualizarCampos() {
			if (grdClientes.Rows.Count == 0 || grdClientes.SelectedRows.Count == 0)
				return;
			DataGridViewRow tabla = grdClientes.SelectedRows[0];
			txtId.Text = tabla.Cells[0].Value.ToString();
			txtCuit.Text = tabla.Cells[1].Value.ToString();
			txtRazonSocial.Text = tabla.Cells[2].Value.ToString();
			txtCalle.Text = tabla.Cells[3].Value.ToString();
			txtNumero.Text = tabla.Cells[4].Value.ToString();
			dtpFecha.Value = (DateTime)tabla.Cells[5].Value;
			cboBarrio.SelectedIndex = cboBarrio.FindStringExact(tabla.Cells[6].Value.ToString());
			cboContacto.SelectedIndex = cboContacto.FindStringExact(tabla.Cells[7].Value.ToString());
		}

		public void Limpiar() {
			txtId.Text = "";
			txtCuit.Text = "";
			txtCalle.Text = "";
			txtRazonSocial.Text = "";
			txtNumero.Text = "";
			cboBarrio.SelectedIndex = -1;
			cboContacto.SelectedIndex = -1;

		}

		public void CargarComboOptions(string tabla, string columnas, ComboBox cmb) {
			Datos datos = new Datos();

			DataTable table = datos.ConsultarTabla(columnas, tabla);
			cmb.DataSource = table;
			cmb.DisplayMember = table.Columns[1].ColumnName;
			cmb.ValueMember = table.Columns[0].ColumnName;

			cmb.DropDownStyle = ComboBoxStyle.DropDownList;
			cmb.SelectedIndex = -1;
			cmb.SelectedValue = -1;
		}

		private void btnSalir_Click(object sender, System.EventArgs e) {
			Close();
		}

		private void btnEliminar_Click(object sender, System.EventArgs e) {
			if (MessageBox.Show("¿Desea eliminar el cliente de id " + txtId.Text + "?", "Eliminando usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK) {
				ClienteBusiness oClienteBusiness = new ClienteBusiness();

				oClienteBusiness.Eliminar(int.Parse(txtId.Text));
				RefreshData();
				Habilitar(false);
			}
		}

		private void grdClientes_SelectionChanged(object sender, EventArgs e) {
			this.ActualizarCampos();
        }

		private void btnAgregar_Click(object sender, EventArgs e) {
			this.Habilitar(true);
			operacion = State.Nuevo;
			this.Limpiar();
			this.txtCuit.Focus();
        }

		private void btnAceptar_Click(object sender, EventArgs e) {
			if (nuevo) {
				AgregarCliente();
			} else if (consultar) {
				ConsultarClientes();
			}
			else {
				ActualizarCliente();
            }

			Habilitar(false);
		}

		void AgregarCliente() {
			ClienteBusiness cBusiness = new ClienteBusiness();
			if (txtCuit.Text == "" || txtCalle.Text == "" || txtRazonSocial.Text == "" ||
				txtNumero.Text == "" || cboBarrio.SelectedIndex == -1 || cboContacto.SelectedIndex == -1) {

				MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK);
				txtId.Focus();
				return;
			}

			Cliente cliente = new Cliente {
				Id = 0,
				Cuit = txtCuit.Text,
				RazonSocial = txtRazonSocial.Text,
				Calle = txtCalle.Text,
				Numero = txtNumero.Text,
				FechaAlta = DateTime.Today,
				Barrio = cboBarrio.Text,
				IdBarrio = (int)cboBarrio.SelectedValue,
				Contacto = cboContacto.Text,
				IdContacto = (int)cboContacto.SelectedValue,
				Borrado = false
			};

			cBusiness.Insertar(cliente);
			RefreshData();
		}

		void ConsultarClientes() {
			ClienteBusiness cBusiness = new ClienteBusiness();
			CargarGrilla(grdClientes, cBusiness.ConsultarClientesFiltrado(
					id: txtId.Text == "" ? -1 : int.Parse(txtId.Text),
					cuit: txtCuit.Text,
					razonSocial: txtRazonSocial.Text,
					calle: txtCalle.Text,
					numero: txtNumero.Text,
					idBarrio: cboBarrio.SelectedIndex == -1 ? -1 :(int)cboBarrio.SelectedValue,
					idContacto: cboContacto.SelectedIndex == -1 ? -1 : (int)cboContacto.SelectedValue
					));
		}

		void ActualizarCliente() {
			ClienteBusiness cBusiness = new ClienteBusiness();
			Cliente cliente = new Cliente {
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
				Borrado = false
			};

			cliente.FechaAlta = dtpFecha.Value;
			cBusiness.ActualizarUsuario(cliente);
			RefreshData();
		}

        private void btnEditar_Click(object sender, EventArgs e) {
			this.Habilitar(true);
			operacion = State.None;
		}

		private void btnConsultar_Click(object sender, EventArgs e) {
			Habilitar(true);
			txtId.Enabled = true;
			operacion = State.Consultar;
		}

		private void btnCancelar_Click(object sender, EventArgs e) {
			Limpiar();
			Habilitar(false);
			operacion = State.None;
		}
	}
}
