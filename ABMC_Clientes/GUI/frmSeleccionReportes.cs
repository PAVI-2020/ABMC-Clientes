using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMC_Clientes.GUI
{
    public partial class frmSeleccionReportes : Form
    {
        public frmSeleccionReportes()
        {
            InitializeComponent();
        }

        private void btnReporteClientes_Click(object sender, EventArgs e)
        {
            frmReporteClientes repo = new frmReporteClientes();
            repo.ShowDialog();
            this.Close();

        }
    }
}
