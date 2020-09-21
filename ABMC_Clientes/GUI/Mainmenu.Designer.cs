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
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::ABMC_Clientes.Properties.Resources.BlackStarBanner;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(430, 135);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// btnAdmClientes
			// 
			this.btnAdmClientes.Location = new System.Drawing.Point(78, 152);
			this.btnAdmClientes.Name = "btnAdmClientes";
			this.btnAdmClientes.Size = new System.Drawing.Size(243, 23);
			this.btnAdmClientes.TabIndex = 1;
			this.btnAdmClientes.Text = "Administracion Clientes";
			this.btnAdmClientes.UseVisualStyleBackColor = true;
			this.btnAdmClientes.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnAdmContactos
			// 
			this.btnAdmContactos.Location = new System.Drawing.Point(78, 193);
			this.btnAdmContactos.Name = "btnAdmContactos";
			this.btnAdmContactos.Size = new System.Drawing.Size(243, 23);
			this.btnAdmContactos.TabIndex = 2;
			this.btnAdmContactos.Text = "Administracion Contactos";
			this.btnAdmContactos.UseVisualStyleBackColor = true;
			this.btnAdmContactos.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// btnAdmBarrios
			// 
			this.btnAdmBarrios.Location = new System.Drawing.Point(78, 233);
			this.btnAdmBarrios.Name = "btnAdmBarrios";
			this.btnAdmBarrios.Size = new System.Drawing.Size(243, 23);
			this.btnAdmBarrios.TabIndex = 3;
			this.btnAdmBarrios.Text = "Administracion Barrios";
			this.btnAdmBarrios.UseVisualStyleBackColor = true;
			this.btnAdmBarrios.Click += new System.EventHandler(this.btnAdmBarrios_Click);
			// 
			// btnAdmPruebas
			// 
			this.btnAdmPruebas.Location = new System.Drawing.Point(78, 271);
			this.btnAdmPruebas.Name = "btnAdmPruebas";
			this.btnAdmPruebas.Size = new System.Drawing.Size(243, 23);
			this.btnAdmPruebas.TabIndex = 4;
			this.btnAdmPruebas.Text = "Administracion Pruebas";
			this.btnAdmPruebas.UseVisualStyleBackColor = true;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(272, 325);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "Salir";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// frmMainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(403, 375);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnAdmPruebas);
			this.Controls.Add(this.btnAdmBarrios);
			this.Controls.Add(this.btnAdmContactos);
			this.Controls.Add(this.btnAdmClientes);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmMainMenu";
			this.Text = "Menu";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnAdmClientes;
		private System.Windows.Forms.Button btnAdmContactos;
		private System.Windows.Forms.Button btnAdmBarrios;
		private System.Windows.Forms.Button btnAdmPruebas;
		private System.Windows.Forms.Button btnExit;
	}
}