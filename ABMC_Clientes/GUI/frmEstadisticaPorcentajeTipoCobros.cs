using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMC_Clientes.GUI {
	public partial class frmEstadisticaPorcentajeTipoCobros : Form {
		public frmEstadisticaPorcentajeTipoCobros() {
			InitializeComponent();
		}

		private void frmEstadisticaPorcentajeTipoCobros_Load(object sender, EventArgs e) {

			this.reportViewer1.RefreshReport();
		}
	}
}
