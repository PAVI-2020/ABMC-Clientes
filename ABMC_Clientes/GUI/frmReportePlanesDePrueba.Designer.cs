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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportePlanesDePrueba));
            this.rpvPlanesDePrueba = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PlanesDePrueba = new ABMC_Clientes.Data_sets.dstGeneral();
            this.planesDePruebaTableAdapter = new ABMC_Clientes.Data_sets.dstGeneralTableAdapters.PlanesDePruebaTableAdapter();
            this.planesDePruebaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbFiltrarFechas = new System.Windows.Forms.GroupBox();
            this.cboUsuarios = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCiclos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlanesDePrueba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesDePruebaBindingSource)).BeginInit();
            this.gbFiltrarFechas.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpvPlanesDePrueba
            // 
            this.rpvPlanesDePrueba.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rpvPlanesDePrueba.LocalReport.ReportEmbeddedResource = "ABMC_Clientes.Reportes.ReportesPlanesDePrueba.rdlc";
            this.rpvPlanesDePrueba.Location = new System.Drawing.Point(0, 0);
            this.rpvPlanesDePrueba.Name = "rpvPlanesDePrueba";
            this.rpvPlanesDePrueba.ServerReport.BearerToken = null;
            this.rpvPlanesDePrueba.Size = new System.Drawing.Size(800, 321);
            this.rpvPlanesDePrueba.TabIndex = 7;
            // 
            // PlanesDePrueba
            // 
            this.PlanesDePrueba.DataSetName = "PlanesDePrueba";
            this.PlanesDePrueba.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planesDePruebaTableAdapter
            // 
            this.planesDePruebaTableAdapter.ClearBeforeFill = true;
            // 
            // planesDePruebaBindingSource
            // 
            this.planesDePruebaBindingSource.DataMember = "PlanesDePrueba";
            this.planesDePruebaBindingSource.DataSource = this.PlanesDePrueba;
            // 
            // gbFiltrarFechas
            // 
            this.gbFiltrarFechas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltrarFechas.Controls.Add(this.cboUsuarios);
            this.gbFiltrarFechas.Controls.Add(this.btnFiltrar);
            this.gbFiltrarFechas.Controls.Add(this.btnExit);
            this.gbFiltrarFechas.Controls.Add(this.lblCiclos);
            this.gbFiltrarFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltrarFechas.Location = new System.Drawing.Point(12, 327);
            this.gbFiltrarFechas.Name = "gbFiltrarFechas";
            this.gbFiltrarFechas.Size = new System.Drawing.Size(776, 111);
            this.gbFiltrarFechas.TabIndex = 8;
            this.gbFiltrarFechas.TabStop = false;
            this.gbFiltrarFechas.Text = "Filtrar por Usuario";
            // 
            // cboUsuarios
            // 
            this.cboUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboUsuarios.FormattingEnabled = true;
            this.cboUsuarios.Location = new System.Drawing.Point(562, 18);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(208, 24);
            this.cboUsuarios.TabIndex = 9;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(209)))), ((int)(((byte)(29)))));
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Image = global::ABMC_Clientes.Properties.Resources.icn_print;
            this.btnFiltrar.Location = new System.Drawing.Point(6, 51);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(54, 54);
            this.btnFiltrar.TabIndex = 8;
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(44)))), ((int)(((byte)(27)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::ABMC_Clientes.Properties.Resources.icn_exit;
            this.btnExit.Location = new System.Drawing.Point(716, 51);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(54, 54);
            this.btnExit.TabIndex = 7;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCiclos
            // 
            this.lblCiclos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCiclos.AutoSize = true;
            this.lblCiclos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiclos.Location = new System.Drawing.Point(383, 21);
            this.lblCiclos.Name = "lblCiclos";
            this.lblCiclos.Size = new System.Drawing.Size(173, 16);
            this.lblCiclos.TabIndex = 0;
            this.lblCiclos.Text = "Buscar planes creados por:";
            // 
            // frmReportePlanesDePrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbFiltrarFechas);
            this.Controls.Add(this.rpvPlanesDePrueba);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportePlanesDePrueba";
            this.Text = "Reporte Planes de Prueba por Usuario";
            this.Load += new System.EventHandler(this.frmReportePlanesDePrueba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlanesDePrueba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesDePruebaBindingSource)).EndInit();
            this.gbFiltrarFechas.ResumeLayout(false);
            this.gbFiltrarFechas.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private Microsoft.Reporting.WinForms.ReportViewer rpvPlanesDePrueba;
		private Data_sets.dstGeneral PlanesDePrueba;
		private Data_sets.dstGeneralTableAdapters.PlanesDePruebaTableAdapter planesDePruebaTableAdapter;
		private System.Windows.Forms.BindingSource planesDePruebaBindingSource;
		private System.Windows.Forms.GroupBox gbFiltrarFechas;
		private System.Windows.Forms.Button btnFiltrar;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label lblCiclos;
		private System.Windows.Forms.ComboBox cboUsuarios;
	}
}