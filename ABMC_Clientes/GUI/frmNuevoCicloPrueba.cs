using ABMC_Clientes.Business;
using ABMC_Clientes.Clases;
using ABMC_Clientes.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ABMC_Clientes.GUI {
	public partial class frmNuevoCicloPrueba : Form {
		public Usuario usuario;

		public frmNuevoCicloPrueba(Usuario usuario) {
			InitializeComponent();
			this.usuario = usuario;
			txtUsuario.Text = usuario.N_usuario;
			txtIdUsuario.Text = usuario.IdUsuario.ToString();
			CargarComboOptions("CasosDePrueba", "id_caso_prueba, titulo", cboCasoPrueba);
			CargarComboOptions("Usuarios", "id_usuario, usuario", cboCasoPrueba);
		}

		private void CalcularTotal() {
			float total = 0;
			foreach (DataGridViewRow row in grdDetalle.Rows) {
				total += float.Parse(row.Cells[3].Value.ToString());
			}

			txtTotal.Text = total.ToString();
		}

		private void ClearFields() {
			cboCasoPrueba.SelectedIndex = -1;
			cboUsrTestr.SelectedIndex = -1;
			txtCantidadHoras.Text = "";
			dtpFechaEjecucion.Value = DateTime.Today;
			grdDetalle.Rows.Clear();
		}


		private void btnSalir_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void btnAgregar_Click(object sender, EventArgs e) {
			if (txtNumeroCiclo.Text == "" ||
				txtNumeroPlanPrueba.Text == "" ||
				cboCasoPrueba.SelectedIndex == -1 ||
				cboUsrTestr.SelectedIndex == -1 ||
				txtCantidadHoras.Text == "") {
				MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK);
				return;
			}

			grdDetalle.Rows.Add(grdDetalle.Rows.Count + 1, txtNumeroPlanPrueba.Text, cboUsrTestr.SelectedValue, txtCantidadHoras.Text, dtpFechaEjecucion.Value.ToString(), cboCasoPrueba.SelectedValue);
			CalcularTotal();
			cboCasoPrueba.SelectedIndex = -1 ;
			cboUsrTestr.SelectedIndex = -1;
			txtCantidadHoras.Clear();
		}

		private void btnSolicitar_Click(object sender, EventArgs e) {

			List<CiclosPruebaDetalle> detalles = new List<CiclosPruebaDetalle>();
			if (grdDetalle.Rows.Count == 0) {
				MessageBox.Show("Agregue un ciclo de prueba previamente", "Error", MessageBoxButtons.OK);
				return;
			}

			foreach (DataGridViewRow dgrid in grdDetalle.Rows) {
				detalles.Add(new CiclosPruebaDetalle(0, 0, Convert.ToInt32(dgrid.Cells[5].Value), Convert.ToInt32(dgrid.Cells[2].Value), Convert.ToInt32(dgrid.Cells[3].Value), DateTime.Parse(dgrid.Cells[4].Value.ToString()), true, false));
			}

			CiclosPrueba ciclo = new CiclosPrueba(0, dtpInicioEjecucion.Value, dtpFinEjecucion.Value, usuario.IdUsuario, Convert.ToInt32(txtNumeroPlanPrueba.Text), Convert.ToInt32(txtNumeroPlanPrueba.Text), true, false);
			ciclo.Detalles = detalles.ToArray();
			CicloPruebaBusiness fbus = new CicloPruebaBusiness();
			fbus.CrearCiclo(ciclo);

			MessageBox.Show("El ciclo de prueba se ha solicitado correctamente.", "Solicitacion", MessageBoxButtons.OK);

			ClearFields();
		}

        private void label14_Click(object sender, EventArgs e)
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
