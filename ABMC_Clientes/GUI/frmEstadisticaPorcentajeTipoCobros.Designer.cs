namespace ABMC_Clientes.GUI {
	partial class frmEstadisticaPorcentajeTipoCobros {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadisticaPorcentajeTipoCobros));
			this.rpvPorcentajeTipoCobroFacturas = new Microsoft.Reporting.WinForms.ReportViewer();
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
			// rpvPorcentajeTipoCobroFacturas
			// 
			this.rpvPorcentajeTipoCobroFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rpvPorcentajeTipoCobroFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rpvPorcentajeTipoCobroFacturas.LocalReport.ReportEmbeddedResource = "ABMC_Clientes.Reportes.EstadisticasPorcentajeTipoDeCobro.rdlc";
			this.rpvPorcentajeTipoCobroFacturas.Location = new System.Drawing.Point(0, 0);
			this.rpvPorcentajeTipoCobroFacturas.Name = "rpvPorcentajeTipoCobroFacturas";
			this.rpvPorcentajeTipoCobroFacturas.ServerReport.BearerToken = null;
			this.rpvPorcentajeTipoCobroFacturas.Size = new System.Drawing.Size(679, 295);
			this.rpvPorcentajeTipoCobroFacturas.TabIndex = 0;
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
			this.gbFiltrarFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbFiltrarFechas.Location = new System.Drawing.Point(12, 301);
			this.gbFiltrarFechas.Name = "gbFiltrarFechas";
			this.gbFiltrarFechas.Size = new System.Drawing.Size(655, 109);
			this.gbFiltrarFechas.TabIndex = 5;
			this.gbFiltrarFechas.TabStop = false;
			this.gbFiltrarFechas.Text = "Filtrar por Fechas";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(301, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(15, 16);
			this.label1.TabIndex = 10;
			this.label1.Text = "y";
			// 
			// dtpFechaHasta
			// 
			this.dtpFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaHasta.Location = new System.Drawing.Point(322, 21);
			this.dtpFechaHasta.Name = "dtpFechaHasta";
			this.dtpFechaHasta.Size = new System.Drawing.Size(127, 22);
			this.dtpFechaHasta.TabIndex = 9;
			// 
			// btnFiltrar
			// 
			this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(209)))), ((int)(((byte)(29)))));
			this.btnFiltrar.FlatAppearance.BorderSize = 0;
			this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFiltrar.Image = global::ABMC_Clientes.Properties.Resources.icn_print;
			this.btnFiltrar.Location = new System.Drawing.Point(6, 49);
			this.btnFiltrar.Name = "btnFiltrar";
			this.btnFiltrar.Size = new System.Drawing.Size(54, 54);
			this.btnFiltrar.TabIndex = 8;
			this.btnFiltrar.UseVisualStyleBackColor = false;
			this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click_1);
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(44)))), ((int)(((byte)(27)))));
			this.btnExit.FlatAppearance.BorderSize = 0;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Image = global::ABMC_Clientes.Properties.Resources.icn_exit;
			this.btnExit.Location = new System.Drawing.Point(595, 49);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(54, 54);
			this.btnExit.TabIndex = 7;
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// dtpFechaDesde
			// 
			this.dtpFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaDesde.Location = new System.Drawing.Point(168, 21);
			this.dtpFechaDesde.Name = "dtpFechaDesde";
			this.dtpFechaDesde.Size = new System.Drawing.Size(127, 22);
			this.dtpFechaDesde.TabIndex = 1;
			// 
			// lblCiclos
			// 
			this.lblCiclos.AutoSize = true;
			this.lblCiclos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCiclos.Location = new System.Drawing.Point(5, 26);
			this.lblCiclos.Name = "lblCiclos";
			this.lblCiclos.Size = new System.Drawing.Size(157, 16);
			this.lblCiclos.TabIndex = 0;
			this.lblCiclos.Text = "Buscar Facturados entre:";
			// 
			// frmEstadisticaPorcentajeTipoCobros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(679, 422);
			this.Controls.Add(this.gbFiltrarFechas);
			this.Controls.Add(this.rpvPorcentajeTipoCobroFacturas);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmEstadisticaPorcentajeTipoCobros";
			this.Text = "Porcentaje de Tipos de Cobro de Facturas";
			this.Load += new System.EventHandler(this.frmEstadisticaPorcentajeTipoCobros_Load);
			this.gbFiltrarFechas.ResumeLayout(false);
			this.gbFiltrarFechas.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer rpvPorcentajeTipoCobroFacturas;
		private System.Windows.Forms.GroupBox gbFiltrarFechas;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpFechaHasta;
		private System.Windows.Forms.Button btnFiltrar;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.DateTimePicker dtpFechaDesde;
		private System.Windows.Forms.Label lblCiclos;
	}
}