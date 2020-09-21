namespace ABMC_Clientes.GUI {
	partial class FormABMCPruebas {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormABMCPruebas));
			this.btnConsultar = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtIdResponsable = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtIdProyecto = new System.Windows.Forms.TextBox();
			this.txtIdPrueba = new System.Windows.Forms.TextBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.grdPruebas = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Id_proyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdPruebas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnConsultar
			// 
			this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnConsultar.Location = new System.Drawing.Point(255, 382);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(75, 45);
			this.btnConsultar.TabIndex = 74;
			this.btnConsultar.Text = "Consultar prueba";
			this.btnConsultar.UseVisualStyleBackColor = true;
			this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(536, 24);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 13);
			this.label6.TabIndex = 69;
			this.label6.Text = "Descripcion:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(335, 149);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 13);
			this.label4.TabIndex = 67;
			this.label4.Text = "Id Responsable:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(368, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 13);
			this.label3.TabIndex = 66;
			this.label3.Text = "Nombre:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(351, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 13);
			this.label2.TabIndex = 65;
			this.label2.Text = "Id Proyecto:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(359, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 64;
			this.label1.Text = "Id Prueba:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtIdResponsable
			// 
			this.txtIdResponsable.Location = new System.Drawing.Point(421, 146);
			this.txtIdResponsable.Name = "txtIdResponsable";
			this.txtIdResponsable.Size = new System.Drawing.Size(181, 20);
			this.txtIdResponsable.TabIndex = 62;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(421, 105);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(181, 20);
			this.txtNombre.TabIndex = 61;
			// 
			// txtIdProyecto
			// 
			this.txtIdProyecto.Location = new System.Drawing.Point(421, 63);
			this.txtIdProyecto.Name = "txtIdProyecto";
			this.txtIdProyecto.Size = new System.Drawing.Size(53, 20);
			this.txtIdProyecto.TabIndex = 60;
			// 
			// txtIdPrueba
			// 
			this.txtIdPrueba.Location = new System.Drawing.Point(421, 21);
			this.txtIdPrueba.Name = "txtIdPrueba";
			this.txtIdPrueba.Size = new System.Drawing.Size(53, 20);
			this.txtIdPrueba.TabIndex = 59;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnCancelar.Location = new System.Drawing.Point(478, 382);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 45);
			this.btnCancelar.TabIndex = 57;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnAceptar
			// 
			this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnAceptar.Location = new System.Drawing.Point(397, 382);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 45);
			this.btnAceptar.TabIndex = 56;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnEliminar.Location = new System.Drawing.Point(174, 382);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 45);
			this.btnEliminar.TabIndex = 55;
			this.btnEliminar.Text = "Eliminar Prueba";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnEditar.Location = new System.Drawing.Point(93, 382);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(75, 45);
			this.btnEditar.TabIndex = 54;
			this.btnEditar.Text = "Editar Prueba";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAgregar.Location = new System.Drawing.Point(12, 382);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 45);
			this.btnAgregar.TabIndex = 53;
			this.btnAgregar.Text = "Agregar Prueba";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnSalir.Location = new System.Drawing.Point(748, 382);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 45);
			this.btnSalir.TabIndex = 58;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.grdPruebas);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 172);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(811, 204);
			this.groupBox1.TabIndex = 52;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Clientes";
			// 
			// grdPruebas
			// 
			this.grdPruebas.AllowUserToAddRows = false;
			this.grdPruebas.AllowUserToDeleteRows = false;
			this.grdPruebas.AllowUserToResizeRows = false;
			this.grdPruebas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdPruebas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdPruebas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Id_proyecto,
            this.nombre,
            this.id_responsable,
            this.descripcion});
			this.grdPruebas.Location = new System.Drawing.Point(6, 19);
			this.grdPruebas.MultiSelect = false;
			this.grdPruebas.Name = "grdPruebas";
			this.grdPruebas.RowHeadersVisible = false;
			this.grdPruebas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdPruebas.Size = new System.Drawing.Size(799, 179);
			this.grdPruebas.TabIndex = 0;
			this.grdPruebas.SelectionChanged += new System.EventHandler(this.grdPruebas_SelectionChanged);
			// 
			// Id
			// 
			this.Id.FillWeight = 200F;
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.Width = 50;
			// 
			// Id_proyecto
			// 
			this.Id_proyecto.HeaderText = "Id_proyecto";
			this.Id_proyecto.Name = "Id_proyecto";
			this.Id_proyecto.Width = 110;
			// 
			// nombre
			// 
			this.nombre.HeaderText = "Nombre";
			this.nombre.Name = "nombre";
			this.nombre.Width = 150;
			// 
			// id_responsable
			// 
			this.id_responsable.FillWeight = 200F;
			this.id_responsable.HeaderText = "Id responsable";
			this.id_responsable.Name = "id_responsable";
			this.id_responsable.Width = 200;
			// 
			// descripcion
			// 
			this.descripcion.HeaderText = "Descripcion";
			this.descripcion.Name = "descripcion";
			this.descripcion.Width = 250;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(317, 154);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 76;
			this.pictureBox1.TabStop = false;
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDescripcion.Location = new System.Drawing.Point(608, 21);
			this.txtDescripcion.Multiline = true;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(215, 145);
			this.txtDescripcion.TabIndex = 77;
			// 
			// FormABMCPruebas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(828, 451);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnConsultar);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtIdResponsable);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtIdProyecto);
			this.Controls.Add(this.txtIdPrueba);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormABMCPruebas";
			this.Text = "ABMC Pruebas";
			this.Shown += new System.EventHandler(this.Form1_Shown);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdPruebas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtIdResponsable;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtIdProyecto;
		private System.Windows.Forms.TextBox txtIdPrueba;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView grdPruebas;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id_proyecto;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_responsable;
		private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
	}
}