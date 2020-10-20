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
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.dstGeneral = new ABMC_Clientes.Data_sets.dstGeneral();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dstGeneral)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "ABMC_Clientes.Reportes.ReporteProyectos.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(801, 301);
			this.reportViewer1.TabIndex = 0;
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
			this.groupBox1.Controls.Add(this.btnSalir);
			this.groupBox1.Controls.Add(this.btnImprimir);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 307);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(776, 131);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filtrar Proyectos";
			// 
			// btnSalir
			// 
			this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSalir.Location = new System.Drawing.Point(30, 94);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 31);
			this.btnSalir.TabIndex = 4;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			// 
			// btnImprimir
			// 
			this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnImprimir.Location = new System.Drawing.Point(659, 94);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(75, 31);
			this.btnImprimir.TabIndex = 3;
			this.btnImprimir.Text = "Filtrar";
			this.btnImprimir.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(214, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Filtrar Proyectos por Usuarios Responsables";
			// 
			// frmReporteProyectos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.reportViewer1);
			this.Name = "frmReporteProyectos";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.frmReporteProyectos_Load);
			((System.ComponentModel.ISupportInitialize)(this.dstGeneral)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private Data_sets.dstGeneral dstGeneral;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.Label label1;
	}
}