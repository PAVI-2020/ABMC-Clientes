namespace ABMC_Clientes.GUI {
	partial class frmNuevoCicloPrueba {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoCicloPrueba));
			this.gbCicloPrueba = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtNumeroPlanPrueba = new System.Windows.Forms.TextBox();
			this.dtpFinEjecucion = new System.Windows.Forms.DateTimePicker();
			this.dtpInicioEjecucion = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtIdUsuario = new System.Windows.Forms.TextBox();
			this.txtNumeroCiclo = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dtpFechaEjecucion = new System.Windows.Forms.DateTimePicker();
			this.btnQuitar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.txtCantidadHoras = new System.Windows.Forms.TextBox();
			this.txtIdUsuarioTester = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.grdDetalle = new System.Windows.Forms.DataGridView();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnSolicitar = new System.Windows.Forms.Button();
			this.txtIdCasoPrueba = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.IDDetalleCicloPrueba = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IDCasodePrueba = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IDUsuarioTester = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CantidadHoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FechaEjecucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IdCasoPrueba = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gbCicloPrueba.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
			this.SuspendLayout();
			// 
			// gbCicloPrueba
			// 
			this.gbCicloPrueba.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbCicloPrueba.Controls.Add(this.label7);
			this.gbCicloPrueba.Controls.Add(this.txtNumeroPlanPrueba);
			this.gbCicloPrueba.Controls.Add(this.dtpFinEjecucion);
			this.gbCicloPrueba.Controls.Add(this.dtpInicioEjecucion);
			this.gbCicloPrueba.Controls.Add(this.label5);
			this.gbCicloPrueba.Controls.Add(this.label1);
			this.gbCicloPrueba.Controls.Add(this.txtUsuario);
			this.gbCicloPrueba.Controls.Add(this.label6);
			this.gbCicloPrueba.Controls.Add(this.label2);
			this.gbCicloPrueba.Controls.Add(this.txtIdUsuario);
			this.gbCicloPrueba.Controls.Add(this.txtNumeroCiclo);
			this.gbCicloPrueba.Controls.Add(this.label4);
			this.gbCicloPrueba.Controls.Add(this.label3);
			this.gbCicloPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbCicloPrueba.Location = new System.Drawing.Point(12, 12);
			this.gbCicloPrueba.Name = "gbCicloPrueba";
			this.gbCicloPrueba.Size = new System.Drawing.Size(565, 129);
			this.gbCicloPrueba.TabIndex = 12;
			this.gbCicloPrueba.TabStop = false;
			this.gbCicloPrueba.Text = "Ciclo de Prueba";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(274, 91);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(135, 13);
			this.label7.TabIndex = 15;
			this.label7.Text = "Numero de Plan de Prueba";
			// 
			// txtNumeroPlanPrueba
			// 
			this.txtNumeroPlanPrueba.Location = new System.Drawing.Point(413, 88);
			this.txtNumeroPlanPrueba.Name = "txtNumeroPlanPrueba";
			this.txtNumeroPlanPrueba.Size = new System.Drawing.Size(100, 20);
			this.txtNumeroPlanPrueba.TabIndex = 16;
			// 
			// dtpFinEjecucion
			// 
			this.dtpFinEjecucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFinEjecucion.Location = new System.Drawing.Point(413, 49);
			this.dtpFinEjecucion.Name = "dtpFinEjecucion";
			this.dtpFinEjecucion.Size = new System.Drawing.Size(100, 20);
			this.dtpFinEjecucion.TabIndex = 14;
			// 
			// dtpInicioEjecucion
			// 
			this.dtpInicioEjecucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpInicioEjecucion.Location = new System.Drawing.Point(413, 23);
			this.dtpInicioEjecucion.Name = "dtpInicioEjecucion";
			this.dtpInicioEjecucion.Size = new System.Drawing.Size(100, 20);
			this.dtpInicioEjecucion.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(305, 51);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Fecha Fin Ejecución";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(34, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Usuario Responsable";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Enabled = false;
			this.txtUsuario.Location = new System.Drawing.Point(147, 22);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(100, 20);
			this.txtUsuario.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(295, 25);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(115, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Fecha Inicio Ejecución";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(5, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Numero de Ciclo de Prueba";
			// 
			// txtIdUsuario
			// 
			this.txtIdUsuario.Enabled = false;
			this.txtIdUsuario.Location = new System.Drawing.Point(147, 48);
			this.txtIdUsuario.Name = "txtIdUsuario";
			this.txtIdUsuario.Size = new System.Drawing.Size(45, 20);
			this.txtIdUsuario.TabIndex = 8;
			// 
			// txtNumeroCiclo
			// 
			this.txtNumeroCiclo.Location = new System.Drawing.Point(146, 88);
			this.txtNumeroCiclo.Name = "txtNumeroCiclo";
			this.txtNumeroCiclo.Size = new System.Drawing.Size(100, 20);
			this.txtNumeroCiclo.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(125, 51);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(16, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Id";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(76, 51);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Usuario  -";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.txtIdCasoPrueba);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.dtpFechaEjecucion);
			this.groupBox2.Controls.Add(this.btnQuitar);
			this.groupBox2.Controls.Add(this.btnAgregar);
			this.groupBox2.Controls.Add(this.txtCantidadHoras);
			this.groupBox2.Controls.Add(this.txtIdUsuarioTester);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Location = new System.Drawing.Point(12, 147);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(565, 163);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Detalle Ciclo de Prueba";
			// 
			// dtpFechaEjecucion
			// 
			this.dtpFechaEjecucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaEjecucion.Location = new System.Drawing.Point(413, 29);
			this.dtpFechaEjecucion.Name = "dtpFechaEjecucion";
			this.dtpFechaEjecucion.Size = new System.Drawing.Size(100, 20);
			this.dtpFechaEjecucion.TabIndex = 16;
			// 
			// btnQuitar
			// 
			this.btnQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnQuitar.Location = new System.Drawing.Point(15, 117);
			this.btnQuitar.Name = "btnQuitar";
			this.btnQuitar.Size = new System.Drawing.Size(102, 40);
			this.btnQuitar.TabIndex = 15;
			this.btnQuitar.Text = "Quitar";
			this.btnQuitar.UseVisualStyleBackColor = true;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAgregar.Location = new System.Drawing.Point(450, 117);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(104, 40);
			this.btnAgregar.TabIndex = 14;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// txtCantidadHoras
			// 
			this.txtCantidadHoras.Location = new System.Drawing.Point(413, 59);
			this.txtCantidadHoras.Name = "txtCantidadHoras";
			this.txtCantidadHoras.Size = new System.Drawing.Size(47, 20);
			this.txtCantidadHoras.TabIndex = 11;
			// 
			// txtIdUsuarioTester
			// 
			this.txtIdUsuarioTester.Location = new System.Drawing.Point(145, 55);
			this.txtIdUsuarioTester.Name = "txtIdUsuarioTester";
			this.txtIdUsuarioTester.Size = new System.Drawing.Size(47, 20);
			this.txtIdUsuarioTester.TabIndex = 8;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(315, 62);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(95, 13);
			this.label12.TabIndex = 7;
			this.label12.Text = "Cantidad de Horas";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(53, 57);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(88, 13);
			this.label10.TabIndex = 5;
			this.label10.Text = "Id Usuario Tester";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(320, 32);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(87, 13);
			this.label9.TabIndex = 4;
			this.label9.Text = "Fecha Ejecución";
			// 
			// grdDetalle
			// 
			this.grdDetalle.AllowUserToAddRows = false;
			this.grdDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDDetalleCicloPrueba,
            this.IDCasodePrueba,
            this.IDUsuarioTester,
            this.CantidadHoras,
            this.FechaEjecucion,
            this.IdCasoPrueba});
			this.grdDetalle.Location = new System.Drawing.Point(12, 316);
			this.grdDetalle.Name = "grdDetalle";
			this.grdDetalle.RowHeadersVisible = false;
			this.grdDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdDetalle.Size = new System.Drawing.Size(554, 150);
			this.grdDetalle.TabIndex = 14;
			this.grdDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// txtTotal
			// 
			this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTotal.Location = new System.Drawing.Point(436, 472);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.ReadOnly = true;
			this.txtTotal.Size = new System.Drawing.Size(130, 20);
			this.txtTotal.TabIndex = 17;
			this.txtTotal.Text = "0";
			this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label14
			// 
			this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(335, 475);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(95, 13);
			this.label14.TabIndex = 16;
			this.label14.Text = "Cantidad de Horas";
			// 
			// btnSalir
			// 
			this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSalir.Location = new System.Drawing.Point(378, 498);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(91, 34);
			this.btnSalir.TabIndex = 19;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnSolicitar
			// 
			this.btnSolicitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSolicitar.Location = new System.Drawing.Point(475, 498);
			this.btnSolicitar.Name = "btnSolicitar";
			this.btnSolicitar.Size = new System.Drawing.Size(91, 34);
			this.btnSolicitar.TabIndex = 18;
			this.btnSolicitar.Text = "Solicitar";
			this.btnSolicitar.UseVisualStyleBackColor = true;
			this.btnSolicitar.Click += new System.EventHandler(this.btnSolicitar_Click);
			// 
			// txtIdCasoPrueba
			// 
			this.txtIdCasoPrueba.Location = new System.Drawing.Point(145, 29);
			this.txtIdCasoPrueba.Name = "txtIdCasoPrueba";
			this.txtIdCasoPrueba.Size = new System.Drawing.Size(47, 20);
			this.txtIdCasoPrueba.TabIndex = 18;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(44, 32);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(95, 13);
			this.label11.TabIndex = 17;
			this.label11.Text = "Id Caso de Prueba";
			// 
			// IDDetalleCicloPrueba
			// 
			this.IDDetalleCicloPrueba.HeaderText = "ID Detalle Ciclo de Prueba";
			this.IDDetalleCicloPrueba.Name = "IDDetalleCicloPrueba";
			// 
			// IDCasodePrueba
			// 
			this.IDCasodePrueba.HeaderText = "ID Caso de Prueba";
			this.IDCasodePrueba.Name = "IDCasodePrueba";
			// 
			// IDUsuarioTester
			// 
			this.IDUsuarioTester.HeaderText = "ID Usuario Tester";
			this.IDUsuarioTester.Name = "IDUsuarioTester";
			// 
			// CantidadHoras
			// 
			this.CantidadHoras.HeaderText = "Cantidad Horas";
			this.CantidadHoras.Name = "CantidadHoras";
			// 
			// FechaEjecucion
			// 
			this.FechaEjecucion.HeaderText = "Fecha Ejecucion";
			this.FechaEjecucion.Name = "FechaEjecucion";
			// 
			// IdCasoPrueba
			// 
			this.IdCasoPrueba.HeaderText = "Id Caso de Prueba";
			this.IdCasoPrueba.Name = "IdCasoPrueba";
			// 
			// frmNuevoCicloPrueba
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(578, 544);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnSolicitar);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.grdDetalle);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.gbCicloPrueba);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmNuevoCicloPrueba";
			this.Text = "Solicitar Ciclo de Prueba";
			this.gbCicloPrueba.ResumeLayout(false);
			this.gbCicloPrueba.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gbCicloPrueba;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtIdUsuario;
		private System.Windows.Forms.TextBox txtNumeroCiclo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtNumeroPlanPrueba;
		private System.Windows.Forms.DateTimePicker dtpFinEjecucion;
		private System.Windows.Forms.DateTimePicker dtpInicioEjecucion;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DateTimePicker dtpFechaEjecucion;
		private System.Windows.Forms.Button btnQuitar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.TextBox txtCantidadHoras;
		private System.Windows.Forms.TextBox txtIdUsuarioTester;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DataGridView grdDetalle;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnSolicitar;
		private System.Windows.Forms.TextBox txtIdCasoPrueba;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDDetalleCicloPrueba;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDCasodePrueba;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDUsuarioTester;
		private System.Windows.Forms.DataGridViewTextBoxColumn CantidadHoras;
		private System.Windows.Forms.DataGridViewTextBoxColumn FechaEjecucion;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdCasoPrueba;
	}
}