namespace ABMC_Clientes.GUI {
	partial class frmABMCBarrios {
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnAtras = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.grdBarrios = new System.Windows.Forms.DataGridView();
			this.IDBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblId = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.txtiD = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdBarrios)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::ABMC_Clientes.Properties.Resources.BlackStarBanner;
			this.pictureBox1.Location = new System.Drawing.Point(12, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(294, 150);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// btnAtras
			// 
			this.btnAtras.Location = new System.Drawing.Point(494, 376);
			this.btnAtras.Name = "btnAtras";
			this.btnAtras.Size = new System.Drawing.Size(75, 49);
			this.btnAtras.TabIndex = 1;
			this.btnAtras.Text = "Atras";
			this.btnAtras.UseVisualStyleBackColor = true;
			this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(183, 294);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 36);
			this.btnCancelar.TabIndex = 2;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(48, 294);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 36);
			this.btnAceptar.TabIndex = 3;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(12, 376);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(66, 49);
			this.btnAgregar.TabIndex = 4;
			this.btnAgregar.Text = "Agregar Barrio";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(83, 376);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(66, 49);
			this.btnEliminar.TabIndex = 5;
			this.btnEliminar.Text = "Eliminar Barrio";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(155, 376);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(66, 49);
			this.btnEditar.TabIndex = 6;
			this.btnEditar.Text = "Editar Barrio";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnConsultar
			// 
			this.btnConsultar.Location = new System.Drawing.Point(227, 376);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(66, 49);
			this.btnConsultar.TabIndex = 7;
			this.btnConsultar.Text = "Consultar Barrio";
			this.btnConsultar.UseVisualStyleBackColor = true;
			this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
			// 
			// grdBarrios
			// 
			this.grdBarrios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdBarrios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDBarrio,
            this.Nombre});
			this.grdBarrios.Location = new System.Drawing.Point(326, 13);
			this.grdBarrios.MultiSelect = false;
			this.grdBarrios.Name = "grdBarrios";
			this.grdBarrios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdBarrios.Size = new System.Drawing.Size(243, 317);
			this.grdBarrios.TabIndex = 8;
			this.grdBarrios.SelectionChanged += new System.EventHandler(this.grdBarrios_SelectionChanged);
			// 
			// IDBarrio
			// 
			this.IDBarrio.HeaderText = "IDBarrio";
			this.IDBarrio.Name = "IDBarrio";
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Location = new System.Drawing.Point(83, 177);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(18, 13);
			this.lblId.TabIndex = 9;
			this.lblId.Text = "ID";
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(57, 214);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(44, 13);
			this.lblNombre.TabIndex = 10;
			this.lblNombre.Text = "Nombre";
			// 
			// txtiD
			// 
			this.txtiD.Location = new System.Drawing.Point(107, 174);
			this.txtiD.Name = "txtiD";
			this.txtiD.Size = new System.Drawing.Size(100, 20);
			this.txtiD.TabIndex = 11;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(107, 211);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(100, 20);
			this.txtNombre.TabIndex = 12;
			// 
			// frmABMCBarrios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(581, 436);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtiD);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.lblId);
			this.Controls.Add(this.grdBarrios);
			this.Controls.Add(this.btnConsultar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAtras);
			this.Controls.Add(this.pictureBox1);
			this.Name = "frmABMCBarrios";
			this.Text = "ABMC Barrios";
			this.Shown += new System.EventHandler(this.Form1_Shown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdBarrios)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnAtras;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.DataGridView grdBarrios;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDBarrio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.TextBox txtiD;
		private System.Windows.Forms.TextBox txtNombre;
	}
}