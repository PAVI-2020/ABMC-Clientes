namespace ABMC_Clientes.GUI
{
    partial class frmSeleccionReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReporteClientes = new System.Windows.Forms.Button();
            this.btnReporteFacturas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReporteClientes
            // 
            this.btnReporteClientes.Location = new System.Drawing.Point(12, 25);
            this.btnReporteClientes.Name = "btnReporteClientes";
            this.btnReporteClientes.Size = new System.Drawing.Size(132, 23);
            this.btnReporteClientes.TabIndex = 0;
            this.btnReporteClientes.Text = "Reporte de clientes";
            this.btnReporteClientes.UseVisualStyleBackColor = true;
            this.btnReporteClientes.Click += new System.EventHandler(this.btnReporteClientes_Click);
            // 
            // btnReporteFacturas
            // 
            this.btnReporteFacturas.Location = new System.Drawing.Point(150, 25);
            this.btnReporteFacturas.Name = "btnReporteFacturas";
            this.btnReporteFacturas.Size = new System.Drawing.Size(132, 23);
            this.btnReporteFacturas.TabIndex = 1;
            this.btnReporteFacturas.Text = "Reporte de Facturas";
            this.btnReporteFacturas.UseVisualStyleBackColor = true;
            // 
            // frmSeleccionReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 121);
            this.Controls.Add(this.btnReporteFacturas);
            this.Controls.Add(this.btnReporteClientes);
            this.Name = "frmSeleccionReportes";
            this.Text = "Realizar un Reporte";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReporteClientes;
        private System.Windows.Forms.Button btnReporteFacturas;
    }
}