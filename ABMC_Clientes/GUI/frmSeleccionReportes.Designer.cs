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
			this.btnReporteCiclos = new System.Windows.Forms.Button();
			this.btnDetalleCiclo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnReporteClientes
			// 
			this.btnReporteClientes.Location = new System.Drawing.Point(12, 25);
			this.btnReporteClientes.Name = "btnReporteClientes";
			this.btnReporteClientes.Size = new System.Drawing.Size(132, 56);
			this.btnReporteClientes.TabIndex = 0;
			this.btnReporteClientes.Text = "Reporte de clientes";
			this.btnReporteClientes.UseVisualStyleBackColor = true;
			this.btnReporteClientes.Click += new System.EventHandler(this.btnReporteClientes_Click);
			// 
			// btnReporteFacturas
			// 
			this.btnReporteFacturas.Location = new System.Drawing.Point(218, 25);
			this.btnReporteFacturas.Name = "btnReporteFacturas";
			this.btnReporteFacturas.Size = new System.Drawing.Size(132, 56);
			this.btnReporteFacturas.TabIndex = 1;
			this.btnReporteFacturas.Text = "Reporte de Facturas";
			this.btnReporteFacturas.UseVisualStyleBackColor = true;
			this.btnReporteFacturas.Click += new System.EventHandler(this.btnReporteFacturas_Click);
			// 
			// btnReporteCiclos
			// 
			this.btnReporteCiclos.Location = new System.Drawing.Point(12, 108);
			this.btnReporteCiclos.Name = "btnReporteCiclos";
			this.btnReporteCiclos.Size = new System.Drawing.Size(132, 56);
			this.btnReporteCiclos.TabIndex = 2;
			this.btnReporteCiclos.Text = "Reporte de Ciclos de Prueba";
			this.btnReporteCiclos.UseVisualStyleBackColor = true;
			this.btnReporteCiclos.Click += new System.EventHandler(this.btnReporteCiclos_Click);
			// 
			// btnDetalleCiclo
			// 
			this.btnDetalleCiclo.Location = new System.Drawing.Point(218, 108);
			this.btnDetalleCiclo.Name = "btnDetalleCiclo";
			this.btnDetalleCiclo.Size = new System.Drawing.Size(132, 56);
			this.btnDetalleCiclo.TabIndex = 3;
			this.btnDetalleCiclo.Text = "Reporte de Detalles de Ciclos de Prueba";
			this.btnDetalleCiclo.UseVisualStyleBackColor = true;
			this.btnDetalleCiclo.Click += new System.EventHandler(this.btnDetalleCiclo_Click);
			// 
			// frmSeleccionReportes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(362, 182);
			this.Controls.Add(this.btnDetalleCiclo);
			this.Controls.Add(this.btnReporteCiclos);
			this.Controls.Add(this.btnReporteFacturas);
			this.Controls.Add(this.btnReporteClientes);
			this.Name = "frmSeleccionReportes";
			this.Text = "Realizar un Reporte";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReporteClientes;
        private System.Windows.Forms.Button btnReporteFacturas;
		private System.Windows.Forms.Button btnReporteCiclos;
		private System.Windows.Forms.Button btnDetalleCiclo;
	}
}