using ABMC_Clientes.Business;
using ABMC_Clientes.Clases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ABMC_Clientes.GUI {
	public partial class frmNuevoCicloPrueba : Form {
		public Usuario usuario;
		Verificador verificadorDetalle = new Verificador();
		Verificador verificadorCiclo = new Verificador();

		public frmNuevoCicloPrueba(Usuario usuario) {
			InitializeComponent();
			this.usuario = usuario;
			txtUsuario.Text = usuario.N_usuario;
			txtIdUsuario.Text = usuario.IdUsuario.ToString();
			Verificador.CargarComboOptions("Usuarios Where borrado = 0", "id_usuario, usuario", cboUsrTestr);
			Verificador.CargarComboOptions("PlanesDePrueba Where borrado = 0", "id_plan_prueba, nombre", cboPlanPrueba);
			verificadorDetalle.Agregar("Caso de Prueba", cboCasoPrueba);
			verificadorDetalle.Agregar("Usuario Tester", cboUsrTestr);
			verificadorDetalle.Agregar("Cantidad Horas", txtCantidadHoras);

			verificadorCiclo.Agregar("Nombre Plan de Prueba", cboPlanPrueba);

			ActualizarCboCasoPrueba();
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
			if (verificadorDetalle.Verificar()) {
				grdDetalle.Rows.Add(grdDetalle.Rows.Count + 1, cboPlanPrueba.SelectedValue, cboUsrTestr.SelectedValue, txtCantidadHoras.Text, dtpFechaEjecucion.Value.ToString(), cboCasoPrueba.SelectedValue);
				CalcularTotal();
				cboCasoPrueba.SelectedIndex = -1;
				cboUsrTestr.SelectedIndex = -1;
				txtCantidadHoras.Clear();
			}
		}

		private void btnSolicitar_Click(object sender, EventArgs e) {
			if (verificadorCiclo.Verificar() && dtpFinEjecucion.Value > dtpInicioEjecucion.Value) {
				List<CiclosPruebaDetalle> detalles = new List<CiclosPruebaDetalle>();
				if (grdDetalle.Rows.Count == 0) {
					MessageBox.Show("Agregue un ciclo de prueba previamente", "Error", MessageBoxButtons.OK);
					return;
				}

				foreach (DataGridViewRow dgrid in grdDetalle.Rows) {
					detalles.Add(new CiclosPruebaDetalle(0, 0, Convert.ToInt32(dgrid.Cells[5].Value), Convert.ToInt32(dgrid.Cells[2].Value), Convert.ToInt32(dgrid.Cells[3].Value), DateTime.Parse(dgrid.Cells[4].Value.ToString()), true, false));
				}

				CiclosPrueba ciclo = new CiclosPrueba(0, dtpInicioEjecucion.Value, dtpFinEjecucion.Value, usuario.IdUsuario, usuario.IdUsuario, (int)cboPlanPrueba.SelectedValue, true, false);
				ciclo.Detalles = detalles.ToArray();
				CicloPruebaBusiness fbus = new CicloPruebaBusiness();
				fbus.CrearCiclo(ciclo);

				MessageBox.Show("El ciclo de prueba se ha solicitado correctamente.", "Solicitacion", MessageBoxButtons.OK);

				ClearFields();
			}
		}

		public void ActualizarCboCasoPrueba() {
			cboCasoPrueba.Enabled = cboPlanPrueba.SelectedIndex != -1;
			
			if (cboPlanPrueba.SelectedValue != null)
				Verificador.CargarComboOptions("CasosDePrueba Where borrado = 0 AND id_plan_prueba=" + cboPlanPrueba.SelectedValue, "id_caso_prueba, titulo", cboCasoPrueba);
		}

		private void cboPlanPrueba_SelectedIndexChanged(object sender, EventArgs e) {
			ActualizarCboCasoPrueba();
		}
	}
}
