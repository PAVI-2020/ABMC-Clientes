namespace ABMC_Clientes.GUI {
	partial class frmReporteProyectos {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteProyectos));
			this.rpvProyectos = new Microsoft.Reporting.WinForms.ReportViewer();
			this.Proyectos = new ABMC_Clientes.Data_sets.dstGeneral();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSalir = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.cboUsuarios = new System.Windows.Forms.ComboBox();
			this.proyectosTableAdapter = new ABMC_Clientes.Data_sets.dstGeneralTableAdapters.ProyectosTableAdapter();
			this.ProyectosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.Proyectos)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ProyectosBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// rpvProyectos
			// 
			this.rpvProyectos.LocalReport.ReportEmbeddedResource = "ABMC_Clientes.Reportes.ReporteProyectos.rdlc";
			this.rpvProyectos.Location = new System.Drawing.Point(0, 0);
			this.rpvProyectos.Name = "rpvProyectos";
			this.rpvProyectos.ServerReport.BearerToken = null;
			this.rpvProyectos.Size = new System.Drawing.Size(801, 301);
			this.rpvProyectos.TabIndex = 0;
			// 
			// Proyectos
			// 
			this.Proyectos.DataSetName = "Proyectos";
			this.Proyectos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.tableLayoutPanel1);
			this.groupBox1.Location = new System.Drawing.Point(12, 307);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(776, 131);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filtrar Proyectos";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.34899F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.65101F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
			this.tableLayoutPanel1.Controls.Add(this.btnSalir, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnImprimir, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.cboUsuarios, 2, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 33);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(764, 92);
			this.tableLayoutPanel1.TabIndex = 7;
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
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(162, 3);
			this.label1.Margin = new System.Windows.Forms.Padding(3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(416, 40);
			this.label1.TabIndex = 1;
			this.label1.Text = "Filtrar Proyectos por Usuarios Responsables";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// btnImprimir
			// 
			this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnImprimir.Location = new System.Drawing.Point(584, 49);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(177, 40);
			this.btnImprimir.TabIndex = 3;
			this.btnImprimir.Text = "Imprimir";
			this.btnImprimir.UseVisualStyleBackColor = true;
			this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
			// 
			// cboUsuarios
			// 
			this.cboUsuarios.FormattingEnabled = true;
			this.cboUsuarios.Location = new System.Drawing.Point(584, 3);
			this.cboUsuarios.Name = "cboUsuarios";
			this.cboUsuarios.Size = new System.Drawing.Size(121, 21);
			this.cboUsuarios.TabIndex = 5;
			// 
			// proyectosTableAdapter
			// 
			this.proyectosTableAdapter.ClearBeforeFill = true;
			// 
			// ProyectosBindingSource
			// 
			this.ProyectosBindingSource.DataMember = "Proyectos";
			this.ProyectosBindingSource.DataSource = this.Proyectos;
			// 
			// frmReporteProyectos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.rpvProyectos);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmReporteProyectos";
			this.Text = "Reporte Proyectos por Usuario";
			this.Load += new System.EventHandler(this.frmReporteProyectos_Load);
			((System.ComponentModel.ISupportInitialize)(this.Proyectos)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ProyectosBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer rpvProyectos;
		private Data_sets.dstGeneral Proyectos;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.ComboBox cboUsuarios;
		private Data_sets.dstGeneralTableAdapters.ProyectosTableAdapter proyectosTableAdapter;
		private System.Windows.Forms.BindingSource ProyectosBindingSource;
	}
}