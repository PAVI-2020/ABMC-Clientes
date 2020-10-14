namespace ABMC_Clientes.GUI {
	partial class FormReporteDetalleCiclo {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteDetalleCiclo));
			this.dstGeneral = new ABMC_Clientes.Data_sets.dstGeneral();
			this.gbFiltrarFechas = new System.Windows.Forms.GroupBox();
			this.btnFiltrar = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.dtpFechaCreacion = new System.Windows.Forms.DateTimePicker();
			this.lblCiclos = new System.Windows.Forms.Label();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.CiclosPruebaDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ciclosPruebaDetalleTableAdapter = new ABMC_Clientes.Data_sets.dstGeneralTableAdapters.CiclosPruebaDetalleTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dstGeneral)).BeginInit();
			this.gbFiltrarFechas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CiclosPruebaDetalleBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dstGeneral
			// 
			this.dstGeneral.DataSetName = "dstGeneral";
			this.dstGeneral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// gbFiltrarFechas
			// 
			this.gbFiltrarFechas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbFiltrarFechas.Controls.Add(this.btnFiltrar);
			this.gbFiltrarFechas.Controls.Add(this.btnExit);
			this.gbFiltrarFechas.Controls.Add(this.dtpFechaCreacion);
			this.gbFiltrarFechas.Controls.Add(this.lblCiclos);
			this.gbFiltrarFechas.Location = new System.Drawing.Point(10, 308);
			this.gbFiltrarFechas.Name = "gbFiltrarFechas";
			this.gbFiltrarFechas.Size = new System.Drawing.Size(625, 130);
			this.gbFiltrarFechas.TabIndex = 2;
			this.gbFiltrarFechas.TabStop = false;
			this.gbFiltrarFechas.Text = "Filtrar por Fechas";
			// 
			// btnFiltrar
			// 
			this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFiltrar.Location = new System.Drawing.Point(499, 82);
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
			this.btnExit.Location = new System.Drawing.Point(17, 82);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(121, 38);
			this.btnExit.TabIndex = 7;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// dtpFechaCreacion
			// 
			this.dtpFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaCreacion.Location = new System.Drawing.Point(373, 26);
			this.dtpFechaCreacion.Name = "dtpFechaCreacion";
			this.dtpFechaCreacion.Size = new System.Drawing.Size(127, 20);
			this.dtpFechaCreacion.TabIndex = 1;
			// 
			// lblCiclos
			// 
			this.lblCiclos.AutoSize = true;
			this.lblCiclos.Location = new System.Drawing.Point(114, 32);
			this.lblCiclos.Name = "lblCiclos";
			this.lblCiclos.Size = new System.Drawing.Size(229, 13);
			this.lblCiclos.TabIndex = 0;
			this.lblCiclos.Text = "Buscar Detalles de Ciclos de Pruba creados en";
			this.lblCiclos.Click += new System.EventHandler(this.lblCiclos_Click);
			// 
			// reportViewer1
			// 
			this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			reportDataSource1.Name = "DataSet1";
			reportDataSource1.Value = this.CiclosPruebaDetalleBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "ABMC_Clientes.Reportes.ReporteDetalleCicloPrueba.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(646, 302);
			this.reportViewer1.TabIndex = 3;
			// 
			// CiclosPruebaDetalleBindingSource
			// 
			this.CiclosPruebaDetalleBindingSource.DataMember = "CiclosPruebaDetalle";
			this.CiclosPruebaDetalleBindingSource.DataSource = this.dstGeneral;
			// 
			// ciclosPruebaDetalleTableAdapter
			// 
			this.ciclosPruebaDetalleTableAdapter.ClearBeforeFill = true;
			// 
			// FormReporteDetalleCiclo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(647, 450);
			this.Controls.Add(this.reportViewer1);
			this.Controls.Add(this.gbFiltrarFechas);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormReporteDetalleCiclo";
			this.Text = "Reporte Detalle Ciclo de Pruba";
			this.Load += new System.EventHandler(this.FormReporteDetalleCiclo_Load);
			((System.ComponentModel.ISupportInitialize)(this.dstGeneral)).EndInit();
			this.gbFiltrarFechas.ResumeLayout(false);
			this.gbFiltrarFechas.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CiclosPruebaDetalleBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Data_sets.dstGeneral dstGeneral;
		private System.Windows.Forms.GroupBox gbFiltrarFechas;
		private System.Windows.Forms.Button btnFiltrar;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.DateTimePicker dtpFechaCreacion;
		private System.Windows.Forms.Label lblCiclos;
		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource CiclosPruebaDetalleBindingSource;
		private Data_sets.dstGeneralTableAdapters.CiclosPruebaDetalleTableAdapter ciclosPruebaDetalleTableAdapter;
	}
}