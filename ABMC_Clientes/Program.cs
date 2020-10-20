using ABMC_Clientes;
using System;
using System.Windows.Forms;
using ABMC_Clientes.GUI;

namespace ABMC_Clientes {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormLogin());
		}
	}
}
