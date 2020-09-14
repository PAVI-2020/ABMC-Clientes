namespace ABMC_Clientes {
	partial class FormABMC {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormABMC));
			this.btnConsultar = new System.Windows.Forms.Button();
			this.cboContacto = new System.Windows.Forms.ComboBox();
			this.cboBarrio = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.txtCalle = new System.Windows.Forms.TextBox();
			this.txtRazonSocial = new System.Windows.Forms.TextBox();
			this.txtCuit = new System.Windows.Forms.TextBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha_alta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Razon_Social = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.grdClientes = new System.Windows.Forms.DataGridView();
			this.btnSalir = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnConsultar
			// 
			this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnConsultar.Location = new System.Drawing.Point(255, 383);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(75, 45);
			this.btnConsultar.TabIndex = 49;
			this.btnConsultar.Text = "Consultar Cliente";
			this.btnConsultar.UseVisualStyleBackColor = true;
			this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
			// 
			// cboContacto
			// 
			this.cboContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cboContacto.FormattingEnabled = true;
			this.cboContacto.Location = new System.Drawing.Point(816, 105);
			this.cboContacto.Name = "cboContacto";
			this.cboContacto.Size = new System.Drawing.Size(121, 21);
			this.cboContacto.TabIndex = 48;
			// 
			// cboBarrio
			// 
			this.cboBarrio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cboBarrio.FormattingEnabled = true;
			this.cboBarrio.Location = new System.Drawing.Point(816, 63);
			this.cboBarrio.Name = "cboBarrio";
			this.cboBarrio.Size = new System.Drawing.Size(121, 21);
			this.cboBarrio.TabIndex = 47;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(606, 150);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(47, 13);
			this.label8.TabIndex = 46;
			this.label8.Text = "Número:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(758, 109);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 13);
			this.label7.TabIndex = 45;
			this.label7.Text = "Contacto: ";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(774, 67);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 13);
			this.label6.TabIndex = 44;
			this.label6.Text = "Barrio: ";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(738, 25);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 13);
			this.label5.TabIndex = 43;
			this.label5.Text = "Fecha de Alta:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(382, 150);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 13);
			this.label4.TabIndex = 42;
			this.label4.Text = "Calle:";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(346, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 13);
			this.label3.TabIndex = 41;
			this.label3.Text = "Razón social:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(389, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(28, 13);
			this.label2.TabIndex = 40;
			this.label2.Text = "Cuit:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(363, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 39;
			this.label1.Text = "Id Cliente:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNumero
			// 
			this.txtNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNumero.Location = new System.Drawing.Point(655, 147);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(100, 20);
			this.txtNumero.TabIndex = 38;
			// 
			// txtCalle
			// 
			this.txtCalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCalle.Location = new System.Drawing.Point(421, 147);
			this.txtCalle.Name = "txtCalle";
			this.txtCalle.Size = new System.Drawing.Size(170, 20);
			this.txtCalle.TabIndex = 36;
			// 
			// txtRazonSocial
			// 
			this.txtRazonSocial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtRazonSocial.Location = new System.Drawing.Point(423, 106);
			this.txtRazonSocial.Name = "txtRazonSocial";
			this.txtRazonSocial.Size = new System.Drawing.Size(230, 20);
			this.txtRazonSocial.TabIndex = 35;
			// 
			// txtCuit
			// 
			this.txtCuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCuit.Location = new System.Drawing.Point(423, 64);
			this.txtCuit.Name = "txtCuit";
			this.txtCuit.Size = new System.Drawing.Size(113, 20);
			this.txtCuit.TabIndex = 34;
			// 
			// txtId
			// 
			this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtId.Location = new System.Drawing.Point(423, 22);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(53, 20);
			this.txtId.TabIndex = 33;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnCancelar.Location = new System.Drawing.Point(555, 383);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 45);
			this.btnCancelar.TabIndex = 31;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnAceptar.Location = new System.Drawing.Point(474, 383);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 45);
			this.btnAceptar.TabIndex = 30;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnEliminar.Location = new System.Drawing.Point(174, 383);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 45);
			this.btnEliminar.TabIndex = 29;
			this.btnEliminar.Text = "Eliminar Cliente";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnEditar.Location = new System.Drawing.Point(93, 383);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(75, 45);
			this.btnEditar.TabIndex = 28;
			this.btnEditar.Text = "Editar Cliente";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAgregar.Location = new System.Drawing.Point(12, 383);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 45);
			this.btnAgregar.TabIndex = 27;
			this.btnAgregar.Text = "Agregar Cliente";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// Contacto
			// 
			this.Contacto.HeaderText = "Contacto";
			this.Contacto.Name = "Contacto";
			this.Contacto.Width = 150;
			// 
			// Barrio
			// 
			this.Barrio.HeaderText = "Barrio";
			this.Barrio.Name = "Barrio";
			this.Barrio.Width = 115;
			// 
			// Fecha_alta
			// 
			this.Fecha_alta.HeaderText = "Fecha de alta";
			this.Fecha_alta.Name = "Fecha_alta";
			this.Fecha_alta.Width = 150;
			// 
			// Numero
			// 
			this.Numero.HeaderText = "Numero";
			this.Numero.Name = "Numero";
			// 
			// Calle
			// 
			this.Calle.HeaderText = "Calle";
			this.Calle.Name = "Calle";
			// 
			// Razon_Social
			// 
			this.Razon_Social.HeaderText = "Razon Social";
			this.Razon_Social.Name = "Razon_Social";
			this.Razon_Social.Width = 150;
			// 
			// Cuit
			// 
			this.Cuit.HeaderText = "Cuit";
			this.Cuit.Name = "Cuit";
			// 
			// Id
			// 
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.Width = 50;
			// 
			// grdClientes
			// 
			this.grdClientes.AllowUserToAddRows = false;
			this.grdClientes.AllowUserToDeleteRows = false;
			this.grdClientes.AllowUserToResizeRows = false;
			this.grdClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Cuit,
            this.Razon_Social,
            this.Calle,
            this.Numero,
            this.Fecha_alta,
            this.Barrio,
            this.Contacto});
			this.grdClientes.Location = new System.Drawing.Point(6, 19);
			this.grdClientes.MultiSelect = false;
			this.grdClientes.Name = "grdClientes";
			this.grdClientes.RowHeadersVisible = false;
			this.grdClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdClientes.Size = new System.Drawing.Size(918, 179);
			this.grdClientes.TabIndex = 0;
			this.grdClientes.SelectionChanged += new System.EventHandler(this.grdClientes_SelectionChanged);
			// 
			// btnSalir
			// 
			this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSalir.Location = new System.Drawing.Point(859, 383);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 45);
			this.btnSalir.TabIndex = 32;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.grdClientes);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 173);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(930, 204);
			this.groupBox1.TabIndex = 26;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Clientes";
			// 
			// dtpFecha
			// 
			this.dtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpFecha.CustomFormat = "yyyy-MM-dd hh:mm:ss";
			this.dtpFecha.Location = new System.Drawing.Point(816, 22);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(121, 20);
			this.dtpFecha.TabIndex = 50;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 13);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(328, 154);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 51;
			this.pictureBox1.TabStop = false;
			// 
			// FormABMC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(962, 439);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.btnConsultar);
			this.Controls.Add(this.cboContacto);
			this.Controls.Add(this.cboBarrio);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.txtCalle);
			this.Controls.Add(this.txtRazonSocial);
			this.Controls.Add(this.txtCuit);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormABMC";
			this.Text = "ABMC";
			this.Shown += new System.EventHandler(this.Form1_Shown);
			((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.ComboBox cboContacto;
		private System.Windows.Forms.ComboBox cboBarrio;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.TextBox txtCalle;
		private System.Windows.Forms.TextBox txtRazonSocial;
		private System.Windows.Forms.TextBox txtCuit;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Contacto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_alta;
		private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
		private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
		private System.Windows.Forms.DataGridViewTextBoxColumn Razon_Social;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cuit;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridView grdClientes;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}