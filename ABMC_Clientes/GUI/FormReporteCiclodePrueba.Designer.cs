namespace ABMC_Clientes.GUI {
	partial class FormReporteCiclodePrueba {
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
			this.components = new System.ComponentModel.Container();
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteCiclodePrueba));
			this.gbFiltrarFechas = new System.Windows.Forms.GroupBox();
			this.btnFiltrar = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
			this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
			this.lblCiclos = new System.Windows.Forms.Label();
			this.dstGeneral = new ABMC_Clientes.Data_sets.dstGeneral();
			this.CicloPruebaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ciclosPruebaTableAdapter = new ABMC_Clientes.Data_sets.dstGeneralTableAdapters.CiclosPruebaTableAdapter();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.gbFiltrarFechas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dstGeneral)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CicloPruebaBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// gbFiltrarFechas
			// 
			this.gbFiltrarFechas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbFiltrarFechas.Controls.Add(this.btnFiltrar);
			this.gbFiltrarFechas.Controls.Add(this.btnExit);
			this.gbFiltrarFechas.Controls.Add(this.label2);
			this.gbFiltrarFechas.Controls.Add(this.dtpFechaHasta);
			this.gbFiltrarFechas.Controls.Add(this.dtpFechaDesde);
			this.gbFiltrarFechas.Controls.Add(this.lblCiclos);
			this.gbFiltrarFechas.Location = new System.Drawing.Point(12, 267);
			this.gbFiltrarFechas.Name = "gbFiltrarFechas";
			this.gbFiltrarFechas.Size = new System.Drawing.Size(674, 100);
			this.gbFiltrarFechas.TabIndex = 1;
			this.gbFiltrarFechas.TabStop = false;
			this.gbFiltrarFechas.Text = "Filtrar por Fechas";
			this.gbFiltrarFechas.Enter += new System.EventHandler(this.gbFiltrarFechas_Enter);
			// 
			// btnFiltrar
			// 
			this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFiltrar.Location = new System.Drawing.Point(548, 52);
			this.btnFiltrar.Name = "btnFiltrar";
			this.btnFiltrar.Size = new System.Drawing.Size(120, 38);
			this.btnFiltrar.TabIndex = 8;
			this.btnFiltrar.Text = "Filtrar";
			this.btnFiltrar.UseVisualStyleBackColor = true;
			this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnExit.Location = new System.Drawing.Point(17, 52);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(121, 38);
			this.btnExit.TabIndex = 7;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(357, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(12, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "y";
			// 
			// dtpFechaHasta
			// 
			this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaHasta.Location = new System.Drawing.Point(375, 27);
			this.dtpFechaHasta.Name = "dtpFechaHasta";
			this.dtpFechaHasta.Size = new System.Drawing.Size(150, 20);
			this.dtpFechaHasta.TabIndex = 2;
			// 
			// dtpFechaDesde
			// 
			this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaDesde.Location = new System.Drawing.Point(215, 26);
			this.dtpFechaDesde.Name = "dtpFechaDesde";
			this.dtpFechaDesde.Size = new System.Drawing.Size(136, 20);
			this.dtpFechaDesde.TabIndex = 1;
			// 
			// lblCiclos
			// 
			this.lblCiclos.AutoSize = true;
			this.lblCiclos.Location = new System.Drawing.Point(14, 32);
			this.lblCiclos.Name = "lblCiclos";
			this.lblCiclos.Size = new System.Drawing.Size(185, 13);
			this.lblCiclos.TabIndex = 0;
			this.lblCiclos.Text = "Buscar Ciclos de Pruba creados entre";
			// 
			// dstGeneral
			// 
			this.dstGeneral.DataSetName = "dstGeneral";
			this.dstGeneral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// CicloPruebaBindingSource
			// 
			this.CicloPruebaBindingSource.DataMember = "CiclosPrueba";
			this.CicloPruebaBindingSource.DataSource = this.dstGeneral;
			// 
			// ciclosPruebaTableAdapter
			// 
			this.ciclosPruebaTableAdapter.ClearBeforeFill = true;
			// 
			// reportViewer1
			// 
			this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			reportDataSource1.Name = "DataSet1";
			reportDataSource1.Value = this.CicloPruebaBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "ABMC_Clientes.Reportes.ReporteCicloPrueba.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(-3, -1);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(700, 262);
			this.reportViewer1.TabIndex = 2;
			// 
			// FormReporteCiclodePrueba
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(698, 379);
			this.Controls.Add(this.reportViewer1);
			this.Controls.Add(this.gbFiltrarFechas);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormReporteCiclodePrueba";
			this.Text = "Reporte Ciclo de Prueba";
			this.Load += new System.EventHandler(this.FormReporteCiclodePrueba_Load);
			this.gbFiltrarFechas.ResumeLayout(false);
			this.gbFiltrarFechas.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dstGeneral)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CicloPruebaBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox gbFiltrarFechas;
		private System.Windows.Forms.Label lblCiclos;
		private System.Windows.Forms.DateTimePicker dtpFechaHasta;
		private System.Windows.Forms.DateTimePicker dtpFechaDesde;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnFiltrar;
		private Data_sets.dstGeneral dstGeneral;
		private System.Windows.Forms.BindingSource CicloPruebaBindingSource;
		private Data_sets.dstGeneralTableAdapters.CiclosPruebaTableAdapter ciclosPruebaTableAdapter;
		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
	}
}