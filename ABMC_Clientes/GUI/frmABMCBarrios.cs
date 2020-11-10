using System;
using System.Windows.Forms;
using ABMC_Clientes.Business;
using ABMC_Clientes.Clases;

namespace ABMC_Clientes.GUI {
	public partial class frmABMCBarrios : Form {
		enum State { None, Nuevo, Consultar }
		private State operacion;

		bool nuevo { get { return operacion == State.Nuevo; } }
		bool consultar { get { return operacion == State.Consultar; } }

		Verificador verificador = new Verificador();
		
		public frmABMCBarrios() {
			InitializeComponent();
		}

		private void Form1_Shown(object sender, System.EventArgs e) {
			Habilitar(false);
			RefreshData();
			ActualizarCampos();
			verificador.Agregar("nombre", txtNombre);
		}

		void RefreshData() {
			BarrioBusiness barrio = new BarrioBusiness();
			Barrio[] barrios = barrio.ConsultarBarrios();
			grdBarrios.Rows.Clear();
			CargarGrilla(grdBarrios, barrios);
		}
		
		void Habilitar(bool estado) {
			txtiD.Enabled = false;
			txtNombre.Enabled = estado;
			btnAceptar.Enabled = estado;
			btnCancelar.Enabled = estado;
		

			btnAgregar.Enabled = !estado;
			btnEditar.Enabled = !estado;
			btnEliminar.Enabled = !estado;
			btnConsultar.Enabled = !estado;
		}

		void CargarGrilla(DataGridView grid, Barrio[] datos) {
			grid.Rows.Clear();
			if (datos == null)
				return;
			foreach (Barrio b in datos) {
				grid.Rows.Add(
					b.Id_barrio, b.Nombre);
			}
		}

		private void ActualizarCampos() {
			if (grdBarrios.Rows.Count == 0 || grdBarrios.SelectedRows.Count == 0)
				return;
			DataGridViewRow tabla = grdBarrios.SelectedRows[0];
			txtiD.Text = tabla.Cells[0].Value.ToString();
			txtNombre.Text = tabla.Cells[1].Value.ToString();
		}

		public void Limpiar() {
			txtiD.Text = "";
			txtNombre.Text = "";
		}

		private void grdBarrios_SelectionChanged(object sender, EventArgs e) {
			this.ActualizarCampos();
		}

		private void btnAceptar_Click(object sender, EventArgs e) {
			if (nuevo) {
				if (verificador.Verificar())
					AgregarBarrio();
			} else if (consultar) {
				ConsultarBarrios();
			} else {
				if (verificador.Verificar())
					ActualizarBarrio();
			}

			Habilitar(false);
		}

		private void btnAtras_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void btnEliminar_Click(object sender, EventArgs e) {
			if (MessageBox.Show("¿Desea eliminar el Barrio de id " + txtiD.Text + "?", "Eliminando Barrio", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK) {
				BarrioBusiness oBarrioBusiness = new BarrioBusiness();

				oBarrioBusiness.Eliminar(int.Parse(txtiD.Text));
				RefreshData();
				Habilitar(false);
			}
		}

		private void btnAgregar_Click(object sender, EventArgs e) {
			this.Habilitar(true);
			operacion = State.Nuevo;
			this.Limpiar();
			this.txtNombre.Focus();
		}

		private void btnEditar_Click(object sender, EventArgs e) {
			this.Habilitar(true);
			operacion = State.None;
		}

		void AgregarBarrio() {
			BarrioBusiness bBusiness = new BarrioBusiness();
			if (txtNombre.Text == "" ) {

				MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK);
				txtiD.Focus();
				return;
			}

			Barrio barrio = new Barrio {
				Id_barrio = 0,
				Nombre = txtNombre.Text,
				Borrado = false
			};

			bBusiness.Insertar(barrio);
			RefreshData();
		}

		void ConsultarBarrios() {
			BarrioBusiness bBusiness = new BarrioBusiness();
			CargarGrilla(grdBarrios, bBusiness.ConsultarBarriosFiltrado(
					id_barrio: txtiD.Text == "" ? -1 : int.Parse(txtiD.Text),
					nombre: txtNombre.Text));
		}

		void ActualizarBarrio() {
			BarrioBusiness bBusiness = new BarrioBusiness();
			Barrio barrio = new Barrio {
				Id_barrio = int.Parse(txtiD.Text),
				Nombre = txtNombre.Text,
				Borrado = false
			};
			bBusiness.ActualizarBarrio(barrio);
			RefreshData();
		}

		private void btnConsultar_Click(object sender, EventArgs e) {
			Habilitar(true);
			txtiD.Enabled = true;
			operacion = State.Consultar;
		}

		private void btnCancelar_Click(object sender, EventArgs e) {
			Limpiar();
			Habilitar(false);
			operacion = State.None;
		}

    }
}
