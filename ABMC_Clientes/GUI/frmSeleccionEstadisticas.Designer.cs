namespace ABMC_Clientes.GUI {
	partial class frmSeleccionEstadisticas {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeleccionEstadisticas));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDistribucionFacturasporTipoDeCobro = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnPorcentajeProyectosUsuario = new System.Windows.Forms.Button();
            this.btnHorasUsuarioTester = new System.Windows.Forms.Button();
            this.btnCantHorasMes = new System.Windows.Forms.Button();
            this.btnEstadisticaPorcentajeBarrios = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnDistribucionFacturasporTipoDeCobro, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnPorcentajeProyectosUsuario, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnHorasUsuarioTester, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCantHorasMes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEstadisticaPorcentajeBarrios, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(536, 198);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnDistribucionFacturasporTipoDeCobro
            // 
            this.btnDistribucionFacturasporTipoDeCobro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDistribucionFacturasporTipoDeCobro.Location = new System.Drawing.Point(271, 135);
            this.btnDistribucionFacturasporTipoDeCobro.Name = "btnDistribucionFacturasporTipoDeCobro";
            this.btnDistribucionFacturasporTipoDeCobro.Size = new System.Drawing.Size(262, 60);
            this.btnDistribucionFacturasporTipoDeCobro.TabIndex = 5;
            this.btnDistribucionFacturasporTipoDeCobro.Text = "Distribución de Facturas por Tipo de Cobro";
            this.btnDistribucionFacturasporTipoDeCobro.UseVisualStyleBackColor = true;
            this.btnDistribucionFacturasporTipoDeCobro.Click += new System.EventHandler(this.btnDistribucionFacturasporTipoDeCobro_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(3, 135);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(262, 60);
            this.button5.TabIndex = 4;
            this.button5.Text = "Cantidad Dinero Facturado por Usuario Responsable";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnPorcentajeProyectosUsuario
            // 
            this.btnPorcentajeProyectosUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPorcentajeProyectosUsuario.Location = new System.Drawing.Point(271, 69);
            this.btnPorcentajeProyectosUsuario.Name = "btnPorcentajeProyectosUsuario";
            this.btnPorcentajeProyectosUsuario.Size = new System.Drawing.Size(262, 60);
            this.btnPorcentajeProyectosUsuario.TabIndex = 3;
            this.btnPorcentajeProyectosUsuario.Text = "Porcentaje de Proyectos por Usuario";
            this.btnPorcentajeProyectosUsuario.UseVisualStyleBackColor = true;
            this.btnPorcentajeProyectosUsuario.Click += new System.EventHandler(this.btnPorcentajeProyectosUsuario_Click);
            // 
            // btnHorasUsuarioTester
            // 
            this.btnHorasUsuarioTester.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHorasUsuarioTester.Location = new System.Drawing.Point(3, 69);
            this.btnHorasUsuarioTester.Name = "btnHorasUsuarioTester";
            this.btnHorasUsuarioTester.Size = new System.Drawing.Size(262, 60);
            this.btnHorasUsuarioTester.TabIndex = 2;
            this.btnHorasUsuarioTester.Text = "Cantidad Horas por Usuario Tester";
            this.btnHorasUsuarioTester.UseVisualStyleBackColor = true;
            this.btnHorasUsuarioTester.Click += new System.EventHandler(this.btnHorasUsuarioTester_Click);
            // 
            // btnCantHorasMes
            // 
            this.btnCantHorasMes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCantHorasMes.Location = new System.Drawing.Point(271, 3);
            this.btnCantHorasMes.Name = "btnCantHorasMes";
            this.btnCantHorasMes.Size = new System.Drawing.Size(262, 60);
            this.btnCantHorasMes.TabIndex = 1;
            this.btnCantHorasMes.Text = "Cantidad Horas Facturadas por Mes";
            this.btnCantHorasMes.UseVisualStyleBackColor = true;
            this.btnCantHorasMes.Click += new System.EventHandler(this.btnCantHorasMes_Click);
            // 
            // btnEstadisticaPorcentajeBarrios
            // 
            this.btnEstadisticaPorcentajeBarrios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEstadisticaPorcentajeBarrios.Location = new System.Drawing.Point(3, 3);
            this.btnEstadisticaPorcentajeBarrios.Name = "btnEstadisticaPorcentajeBarrios";
            this.btnEstadisticaPorcentajeBarrios.Size = new System.Drawing.Size(262, 60);
            this.btnEstadisticaPorcentajeBarrios.TabIndex = 0;
            this.btnEstadisticaPorcentajeBarrios.Text = "Porcentaje Clientes por Barrio";
            this.btnEstadisticaPorcentajeBarrios.UseVisualStyleBackColor = true;
            this.btnEstadisticaPorcentajeBarrios.Click += new System.EventHandler(this.btnEstadisticaPorcentajeBarrios_Click);
            // 
            // frmSeleccionEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 199);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSeleccionEstadisticas";
            this.Text = "Seleccion Estadísticas";
            this.Load += new System.EventHandler(this.frmSeleccionEstadisticas_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnDistribucionFacturasporTipoDeCobro;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button btnPorcentajeProyectosUsuario;
		private System.Windows.Forms.Button btnHorasUsuarioTester;
		private System.Windows.Forms.Button btnCantHorasMes;
		private System.Windows.Forms.Button btnEstadisticaPorcentajeBarrios;
	}
}