namespace ABMC_Clientes.GUI {
	partial class frmReportePlanesDePrueba {
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
			this.planesDePruebaTableAdapter = new ABMC_Clientes.Data_sets.dstGeneralTableAdapters.PlanesDePruebaTableAdapter();
			this.dstGeneral = new ABMC_Clientes.Data_sets.dstGeneral();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.cboUsuarios = new System.Windows.Forms.ComboBox();
			this.PlanesPruebaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			((System.ComponentModel.ISupportInitialize)(this.dstGeneral)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PlanesPruebaBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// planesDePruebaTableAdapter
			// 
			this.planesDePruebaTableAdapter.ClearBeforeFill = true;
			// 
			// dstGeneral
			// 
			this.dstGeneral.DataSetName = "dstGeneral";
			this.dstGeneral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Location = new System.Drawing.Point(12, 321);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(776, 117);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filtrar por fechas";
			// 
			// btnSalir
			// 
			this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSalir.Location = new System.Drawing.Point(3, 49);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(153, 40);
			this.btnSalir.TabIndex = 4;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnImprimir
			// 
			this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnImprimir.Location = new System.Drawing.Point(586, 49);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(175, 40);
			this.btnImprimir.TabIndex = 3;
			this.btnImprimir.Text = "Imprimir";
			this.btnImprimir.UseVisualStyleBackColor = true;
			this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(162, 3);
			this.label1.Margin = new System.Windows.Forms.Padding(3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(418, 40);
			this.label1.TabIndex = 1;
			this.label1.Text = "Buscar clientes creados entre";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.34899F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.65101F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
			this.tableLayoutPanel1.Controls.Add(this.btnSalir, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnImprimir, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.cboUsuarios, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 340);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(764, 92);
			this.tableLayoutPanel1.TabIndex = 6;
			// 
			// cboUsuarios
			// 
			this.cboUsuarios.DataSource = this.dstGeneral;
			this.cboUsuarios.DisplayMember = "PlanesDePrueba.usuario";
			this.cboUsuarios.FormattingEnabled = true;
			this.cboUsuarios.Location = new System.Drawing.Point(586, 3);
			this.cboUsuarios.Name = "cboUsuarios";
			this.cboUsuarios.Size = new System.Drawing.Size(121, 21);
			this.cboUsuarios.TabIndex = 5;
			// 
			// PlanesPruebaBindingSource
			// 
			this.PlanesPruebaBindingSource.DataMember = "PlanesDePrueba";
			this.PlanesPruebaBindingSource.DataSource = this.dstGeneral;
			// 
			// reportViewer1
			// 
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "ABMC_Clientes.Reportes.ReportesPlanesDePrueba.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(12, 12);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(776, 303);
			this.reportViewer1.TabIndex = 7;
			// 
			// frmReportePlanesDePrueba
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.reportViewer1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmReportePlanesDePrueba";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.frmReportePlanesDePrueba_Load);
			((System.ComponentModel.ISupportInitialize)(this.dstGeneral)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PlanesPruebaBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Data_sets.dstGeneralTableAdapters.PlanesDePruebaTableAdapter planesDePruebaTableAdapter;
		private Data_sets.dstGeneral dstGeneral;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ComboBox cboUsuarios;
		private System.Windows.Forms.BindingSource PlanesPruebaBindingSource;
		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
	}
}