namespace ABMC_Clientes.GUI {
	partial class frmEstadisticaCantHorasUsuarioTester {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadisticaCantHorasUsuarioTester));
			this.rpvCantHorasUsuario = new Microsoft.Reporting.WinForms.ReportViewer();
			this.SuspendLayout();
			// 
			// rpvCantHorasUsuario
			// 
			this.rpvCantHorasUsuario.LocalReport.ReportEmbeddedResource = "ABMC_Clientes.Reportes.EstadisticaCantidadHorasporUsuarioTester.rdlc";
			this.rpvCantHorasUsuario.Location = new System.Drawing.Point(0, 0);
			this.rpvCantHorasUsuario.Name = "rpvCantHorasUsuario";
			this.rpvCantHorasUsuario.ServerReport.BearerToken = null;
			this.rpvCantHorasUsuario.Size = new System.Drawing.Size(800, 451);
			this.rpvCantHorasUsuario.TabIndex = 0;
			// 
			// frmEstadisticaCantHorasUsuarioTester
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.rpvCantHorasUsuario);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmEstadisticaCantHorasUsuarioTester";
			this.Text = "Estadistica Cantidad de Horas por Usuario Tester";
			this.Load += new System.EventHandler(this.frmEstadisticaCantHorasUsuarioTester_Load);
			this.ResumeLayout(false);

		}

		#endregion
		private Microsoft.Reporting.WinForms.ReportViewer rpvCantHorasUsuario;
	}
}