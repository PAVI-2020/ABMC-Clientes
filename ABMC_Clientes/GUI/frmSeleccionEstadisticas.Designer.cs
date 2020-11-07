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
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.btnDistribucionFacturasporTipoDeCobro, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.button5, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.btnPorcentajeProyectosUsuario, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnHorasUsuarioTester, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnCantHorasMes, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnEstadisticaPorcentajeBarrios, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 9);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(521, 181);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// btnDistribucionFacturasporTipoDeCobro
			// 
			this.btnDistribucionFacturasporTipoDeCobro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDistribucionFacturasporTipoDeCobro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(148)))), ((int)(((byte)(209)))));
			this.btnDistribucionFacturasporTipoDeCobro.FlatAppearance.BorderSize = 0;
			this.btnDistribucionFacturasporTipoDeCobro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDistribucionFacturasporTipoDeCobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDistribucionFacturasporTipoDeCobro.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnDistribucionFacturasporTipoDeCobro.Location = new System.Drawing.Point(263, 123);
			this.btnDistribucionFacturasporTipoDeCobro.Name = "btnDistribucionFacturasporTipoDeCobro";
			this.btnDistribucionFacturasporTipoDeCobro.Size = new System.Drawing.Size(255, 55);
			this.btnDistribucionFacturasporTipoDeCobro.TabIndex = 5;
			this.btnDistribucionFacturasporTipoDeCobro.Text = "Distribución de Facturas por Tipo de Cobro";
			this.btnDistribucionFacturasporTipoDeCobro.UseVisualStyleBackColor = false;
			this.btnDistribucionFacturasporTipoDeCobro.Click += new System.EventHandler(this.btnDistribucionFacturasporTipoDeCobro_Click);
			// 
			// button5
			// 
			this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(148)))), ((int)(((byte)(209)))));
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.button5.Location = new System.Drawing.Point(3, 123);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(254, 55);
			this.button5.TabIndex = 4;
			this.button5.Text = "Cantidad Dinero Facturado por Usuario Responsable";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// btnPorcentajeProyectosUsuario
			// 
			this.btnPorcentajeProyectosUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPorcentajeProyectosUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(148)))), ((int)(((byte)(209)))));
			this.btnPorcentajeProyectosUsuario.FlatAppearance.BorderSize = 0;
			this.btnPorcentajeProyectosUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPorcentajeProyectosUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPorcentajeProyectosUsuario.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnPorcentajeProyectosUsuario.Location = new System.Drawing.Point(263, 63);
			this.btnPorcentajeProyectosUsuario.Name = "btnPorcentajeProyectosUsuario";
			this.btnPorcentajeProyectosUsuario.Size = new System.Drawing.Size(255, 54);
			this.btnPorcentajeProyectosUsuario.TabIndex = 3;
			this.btnPorcentajeProyectosUsuario.Text = "Porcentaje de Proyectos por Usuario";
			this.btnPorcentajeProyectosUsuario.UseVisualStyleBackColor = false;
			this.btnPorcentajeProyectosUsuario.Click += new System.EventHandler(this.btnPorcentajeProyectosUsuario_Click);
			// 
			// btnHorasUsuarioTester
			// 
			this.btnHorasUsuarioTester.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnHorasUsuarioTester.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(148)))), ((int)(((byte)(209)))));
			this.btnHorasUsuarioTester.FlatAppearance.BorderSize = 0;
			this.btnHorasUsuarioTester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHorasUsuarioTester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHorasUsuarioTester.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnHorasUsuarioTester.Location = new System.Drawing.Point(3, 63);
			this.btnHorasUsuarioTester.Name = "btnHorasUsuarioTester";
			this.btnHorasUsuarioTester.Size = new System.Drawing.Size(254, 54);
			this.btnHorasUsuarioTester.TabIndex = 2;
			this.btnHorasUsuarioTester.Text = "Cantidad Horas por Usuario Tester";
			this.btnHorasUsuarioTester.UseVisualStyleBackColor = false;
			this.btnHorasUsuarioTester.Click += new System.EventHandler(this.btnHorasUsuarioTester_Click);
			// 
			// btnCantHorasMes
			// 
			this.btnCantHorasMes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCantHorasMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(148)))), ((int)(((byte)(209)))));
			this.btnCantHorasMes.FlatAppearance.BorderSize = 0;
			this.btnCantHorasMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCantHorasMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCantHorasMes.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnCantHorasMes.Location = new System.Drawing.Point(263, 3);
			this.btnCantHorasMes.Name = "btnCantHorasMes";
			this.btnCantHorasMes.Size = new System.Drawing.Size(255, 54);
			this.btnCantHorasMes.TabIndex = 1;
			this.btnCantHorasMes.Text = "Cantidad Horas Facturadas por Mes";
			this.btnCantHorasMes.UseVisualStyleBackColor = false;
			this.btnCantHorasMes.Click += new System.EventHandler(this.btnCantHorasMes_Click);
			// 
			// btnEstadisticaPorcentajeBarrios
			// 
			this.btnEstadisticaPorcentajeBarrios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEstadisticaPorcentajeBarrios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(148)))), ((int)(((byte)(209)))));
			this.btnEstadisticaPorcentajeBarrios.FlatAppearance.BorderSize = 0;
			this.btnEstadisticaPorcentajeBarrios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEstadisticaPorcentajeBarrios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEstadisticaPorcentajeBarrios.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnEstadisticaPorcentajeBarrios.Location = new System.Drawing.Point(3, 3);
			this.btnEstadisticaPorcentajeBarrios.Name = "btnEstadisticaPorcentajeBarrios";
			this.btnEstadisticaPorcentajeBarrios.Size = new System.Drawing.Size(254, 54);
			this.btnEstadisticaPorcentajeBarrios.TabIndex = 0;
			this.btnEstadisticaPorcentajeBarrios.Text = "Porcentaje Clientes por Barrio";
			this.btnEstadisticaPorcentajeBarrios.UseVisualStyleBackColor = false;
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