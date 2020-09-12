using ABMC_Clientes.Business;
using ABMC_Clientes.Clases;
using System.Windows.Forms;

namespace ABMC_Clientes {
	public partial class FormABMC : Form {
		public FormABMC() {
			InitializeComponent();
		}

		private void Form1_Shown(object sender, System.EventArgs e) {
			Habilitar(false);

			ClienteBusiness cliente = new ClienteBusiness();
			CargarGrilla(grdClientes, cliente.ConsultarClientes());
		}

		void Habilitar(bool estado) {
			txtCalle.Enabled = estado;
			txtCuit.Enabled = estado;
			txtId.Enabled = estado;
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
	}
}
