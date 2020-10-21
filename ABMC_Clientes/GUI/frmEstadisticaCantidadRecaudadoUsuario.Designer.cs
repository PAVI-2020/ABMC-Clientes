namespace ABMC_Clientes.GUI {
	partial class frmEstadisticaCantidadRecaudadoUsuario {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadisticaCantidadRecaudadoUsuario));
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.gbFiltrarFechas = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
			this.btnFiltrar = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
			this.lblCiclos = new System.Windows.Forms.Label();
			this.gbFiltrarFechas.SuspendLayout();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "ABMC_Clientes.Reportes.EstadisticaCantidadRecaudadaporUsuario.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(802, 320);
			this.reportViewer1.TabIndex = 0;
			// 
			// gbFiltrarFechas
			// 
			this.gbFiltrarFechas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbFiltrarFechas.Controls.Add(this.label1);
			this.gbFiltrarFechas.Controls.Add(this.dtpFechaHasta);
			this.gbFiltrarFechas.Controls.Add(this.btnFiltrar);
			this.gbFiltrarFechas.Controls.Add(this.btnExit);
			this.gbFiltrarFechas.Controls.Add(this.dtpFechaDesde);
			this.gbFiltrarFechas.Controls.Add(this.lblCiclos);
			this.gbFiltrarFechas.Location = new System.Drawing.Point(12, 326);
			this.gbFiltrarFechas.Name = "gbFiltrarFechas";
			this.gbFiltrarFechas.Size = new System.Drawing.Size(776, 112);
			this.gbFiltrarFechas.TabIndex = 3;
			this.gbFiltrarFechas.TabStop = false;
			this.gbFiltrarFechas.Text = "Filtrar por Fechas";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(291, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(12, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "y";
			// 
			// dtpFechaHasta
			// 
			this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaHasta.Location = new System.Drawing.Point(326, 26);
			this.dtpFechaHasta.Name = "dtpFechaHasta";
			this.dtpFechaHasta.Size = new System.Drawing.Size(127, 20);
			this.dtpFechaHasta.TabIndex = 9;
			// 
			// btnFiltrar
			// 
			this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFiltrar.Location = new System.Drawing.Point(650, 64);
			this.btnFiltrar.Name = "btnFiltrar";
			this.btnFiltrar.Size = new System.Drawing.Size(120, 38);
			this.btnFiltrar.TabIndex = 8;
			this.btnFiltrar.Text = "Filtrar";
			this.btnFiltrar.UseVisualStyleBackColor = true;
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnExit.Location = new System.Drawing.Point(17, 64);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(121, 38);
			this.btnExit.TabIndex = 7;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			// 
			// dtpFechaDesde
			// 
			this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaDesde.Location = new System.Drawing.Point(138, 26);
			this.dtpFechaDesde.Name = "dtpFechaDesde";
			this.dtpFechaDesde.Size = new System.Drawing.Size(127, 20);
			this.dtpFechaDesde.TabIndex = 1;
			// 
			// lblCiclos
			// 
			this.lblCiclos.AutoSize = true;
			this.lblCiclos.Location = new System.Drawing.Point(6, 32);
			this.lblCiclos.Name = "lblCiclos";
			this.lblCiclos.Size = new System.Drawing.Size(126, 13);
			this.lblCiclos.TabIndex = 0;
			this.lblCiclos.Text = "Buscar Facturados entre:";
			// 
			// frmEstadisticaCantidadRecaudadoUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.gbFiltrarFechas);
			this.Controls.Add(this.reportViewer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmEstadisticaCantidadRecaudadoUsuario";
			this.Text = "Estadisitca Cantidad de Dinero Recaudado por usuario Responsable";
			this.Load += new System.EventHandler(this.frmEstadisticaCantidadRecaudadoUsuario_Load);
			this.gbFiltrarFechas.ResumeLayout(false);
			this.gbFiltrarFechas.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.GroupBox gbFiltrarFechas;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpFechaHasta;
		private System.Windows.Forms.Button btnFiltrar;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.DateTimePicker dtpFechaDesde;
		private System.Windows.Forms.Label lblCiclos;
	}
}