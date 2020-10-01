namespace ABMC_Clientes.GUI {
	partial class frmMainMenu {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnAdmClientes = new System.Windows.Forms.Button();
			this.btnAdmContactos = new System.Windows.Forms.Button();
			this.btnAdmBarrios = new System.Windows.Forms.Button();
			this.btnAdmPruebas = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnTransaccion = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Image = global::ABMC_Clientes.Properties.Resources.BlackStarBanner;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(457, 135);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// btnAdmClientes
			// 
			this.btnAdmClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdmClientes.Location = new System.Drawing.Point(3, 3);
			this.btnAdmClientes.Name = "btnAdmClientes";
			this.btnAdmClientes.Size = new System.Drawing.Size(222, 27);
			this.btnAdmClientes.TabIndex = 1;
			this.btnAdmClientes.Text = "Administracion Clientes";
			this.btnAdmClientes.UseVisualStyleBackColor = true;
			this.btnAdmClientes.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnAdmContactos
			// 
			this.btnAdmContactos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdmContactos.Location = new System.Drawing.Point(3, 36);
			this.btnAdmContactos.Name = "btnAdmContactos";
			this.btnAdmContactos.Size = new System.Drawing.Size(222, 27);
			this.btnAdmContactos.TabIndex = 2;
			this.btnAdmContactos.Text = "Administracion Contactos";
			this.btnAdmContactos.UseVisualStyleBackColor = true;
			this.btnAdmContactos.Click += new System.EventHandler(this.btnAdmContactos_Click);
			// 
			// btnAdmBarrios
			// 
			this.btnAdmBarrios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdmBarrios.Location = new System.Drawing.Point(3, 69);
			this.btnAdmBarrios.Name = "btnAdmBarrios";
			this.btnAdmBarrios.Size = new System.Drawing.Size(222, 27);
			this.btnAdmBarrios.TabIndex = 3;
			this.btnAdmBarrios.Text = "Administracion Barrios";
			this.btnAdmBarrios.UseVisualStyleBackColor = true;
			this.btnAdmBarrios.Click += new System.EventHandler(this.btnAdmBarrios_Click);
			// 
			// btnAdmPruebas
			// 
			this.btnAdmPruebas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdmPruebas.Location = new System.Drawing.Point(3, 102);
			this.btnAdmPruebas.Name = "btnAdmPruebas";
			this.btnAdmPruebas.Size = new System.Drawing.Size(222, 27);
			this.btnAdmPruebas.TabIndex = 4;
			this.btnAdmPruebas.Text = "Administracion Pruebas";
			this.btnAdmPruebas.UseVisualStyleBackColor = true;
			this.btnAdmPruebas.Click += new System.EventHandler(this.btnAdmPruebas_Click);
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.Location = new System.Drawing.Point(231, 135);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(223, 27);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "Salir";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnTransaccion
			// 
			this.btnTransaccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnTransaccion.Location = new System.Drawing.Point(231, 3);
			this.btnTransaccion.Name = "btnTransaccion";
			this.btnTransaccion.Size = new System.Drawing.Size(223, 27);
			this.btnTransaccion.TabIndex = 6;
			this.btnTransaccion.Text = "Transaccion";
			this.btnTransaccion.UseVisualStyleBackColor = true;
			this.btnTransaccion.Click += new System.EventHandler(this.btnTransaccion_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.btnAdmClientes, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnExit, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.btnTransaccion, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnAdmContactos, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnAdmBarrios, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.btnAdmPruebas, 0, 3);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 141);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(457, 165);
			this.tableLayoutPanel1.TabIndex = 7;
			// 
			// frmMainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(456, 318);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(332, 325);
			this.Name = "frmMainMenu";
			this.Text = "Menu";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnAdmClientes;
		private System.Windows.Forms.Button btnAdmContactos;
		private System.Windows.Forms.Button btnAdmBarrios;
		private System.Windows.Forms.Button btnAdmPruebas;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnTransaccion;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}