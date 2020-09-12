using ABMC_Clientes.Business;
using ABMC_Clientes.Clases;
using System;
using System.Windows.Forms;

namespace ABMC_Cliente {
    public partial class FormABMC : Form {
        public FormABMC() {
            InitializeComponent();
        }

		private void btnSalir_Click(object sender, EventArgs e) {
            Close();
		}

		private void FormABMC_Load(object sender, EventArgs e) {
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
	}
}
