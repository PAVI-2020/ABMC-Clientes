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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeleccionReportes));
			this.btnReporteClientes = new System.Windows.Forms.Button();
			this.btnReporteFacturas = new System.Windows.Forms.Button();
			this.btnReporteCiclos = new System.Windows.Forms.Button();
			this.btnDetalleCiclo = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnReportesPlanDePrueba = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnReporteClientes
			// 
			this.btnReporteClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReporteClientes.Location = new System.Drawing.Point(3, 3);
			this.btnReporteClientes.Name = "btnReporteClientes";
			this.btnReporteClientes.Size = new System.Drawing.Size(252, 63);
			this.btnReporteClientes.TabIndex = 0;
			this.btnReporteClientes.Text = "Reporte de Clientes";
			this.btnReporteClientes.UseVisualStyleBackColor = true;
			this.btnReporteClientes.Click += new System.EventHandler(this.btnReporteClientes_Click);
			// 
			// btnReporteFacturas
			// 
			this.btnReporteFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReporteFacturas.Location = new System.Drawing.Point(261, 3);
			this.btnReporteFacturas.Name = "btnReporteFacturas";
			this.btnReporteFacturas.Size = new System.Drawing.Size(252, 63);
			this.btnReporteFacturas.TabIndex = 1;
			this.btnReporteFacturas.Text = "Reporte de Facturas";
			this.btnReporteFacturas.UseVisualStyleBackColor = true;
			this.btnReporteFacturas.Click += new System.EventHandler(this.btnReporteFacturas_Click);
			// 
			// btnReporteCiclos
			// 
			this.btnReporteCiclos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReporteCiclos.Location = new System.Drawing.Point(3, 72);
			this.btnReporteCiclos.Name = "btnReporteCiclos";
			this.btnReporteCiclos.Size = new System.Drawing.Size(252, 63);
			this.btnReporteCiclos.TabIndex = 2;
			this.btnReporteCiclos.Text = "Reporte de Ciclos de Prueba";
			this.btnReporteCiclos.UseVisualStyleBackColor = true;
			this.btnReporteCiclos.Click += new System.EventHandler(this.btnReporteCiclos_Click);
			// 
			// btnDetalleCiclo
			// 
			this.btnDetalleCiclo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDetalleCiclo.Location = new System.Drawing.Point(261, 72);
			this.btnDetalleCiclo.Name = "btnDetalleCiclo";
			this.btnDetalleCiclo.Size = new System.Drawing.Size(252, 63);
			this.btnDetalleCiclo.TabIndex = 3;
			this.btnDetalleCiclo.Text = "Reporte de Detalles de Ciclos de Prueba";
			this.btnDetalleCiclo.UseVisualStyleBackColor = true;
			this.btnDetalleCiclo.Click += new System.EventHandler(this.btnDetalleCiclo_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.btnReporteClientes, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnDetalleCiclo, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnReporteCiclos, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnReporteFacturas, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnReportesPlanDePrueba, 1, 2);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 9);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(516, 202);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// btnReportesPlanDePrueba
			// 
			this.btnReportesPlanDePrueba.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReportesPlanDePrueba.Location = new System.Drawing.Point(261, 141);
			this.btnReportesPlanDePrueba.Name = "btnReportesPlanDePrueba";
			this.btnReportesPlanDePrueba.Size = new System.Drawing.Size(252, 58);
			this.btnReportesPlanDePrueba.TabIndex = 4;
			this.btnReportesPlanDePrueba.Text = "Reporte de Plan de Prueba";
			this.btnReportesPlanDePrueba.UseVisualStyleBackColor = true;
			this.btnReportesPlanDePrueba.Click += new System.EventHandler(this.btnReportesPlanDePrueba_Click);
			// 
			// frmSeleccionReportes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 220);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmSeleccionReportes";
			this.Text = "Realizar un Reporte";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReporteClientes;
        private System.Windows.Forms.Button btnReporteFacturas;
		private System.Windows.Forms.Button btnReporteCiclos;
		private System.Windows.Forms.Button btnDetalleCiclo;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnReportesPlanDePrueba;
	}
}