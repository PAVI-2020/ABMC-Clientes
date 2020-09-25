namespace ABMC_Clientes.GUI
{
    partial class frmFacturacion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturacion));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtNumeroFactura = new System.Windows.Forms.TextBox();
			this.txtIdCliente = new System.Windows.Forms.TextBox();
			this.txtRazonSocial = new System.Windows.Forms.TextBox();
			this.txtFecha = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.txtIdCiclo = new System.Windows.Forms.TextBox();
			this.txtNombreProd = new System.Windows.Forms.TextBox();
			this.txtNombreProy = new System.Windows.Forms.TextBox();
			this.txtIdProducto = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtIdProyecto = new System.Windows.Forms.TextBox();
			this.cboTipoCobro = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.grdDetallesFactura = new System.Windows.Forms.DataGridView();
			this.noOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TipoCobro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IdCobrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label14 = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.btnFacturar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDetallesFactura)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(188, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Usuario";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(136, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Numero de factura";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(136, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Cliente";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(213, 82);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(16, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Id";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(288, 82);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Razon social";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(192, 104);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(37, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Fecha";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(235, 24);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(100, 20);
			this.txtUsuario.TabIndex = 6;
			// 
			// txtNumeroFactura
			// 
			this.txtNumeroFactura.Location = new System.Drawing.Point(235, 50);
			this.txtNumeroFactura.Name = "txtNumeroFactura";
			this.txtNumeroFactura.Size = new System.Drawing.Size(100, 20);
			this.txtNumeroFactura.TabIndex = 7;
			// 
			// txtIdCliente
			// 
			this.txtIdCliente.Location = new System.Drawing.Point(235, 75);
			this.txtIdCliente.Name = "txtIdCliente";
			this.txtIdCliente.Size = new System.Drawing.Size(45, 20);
			this.txtIdCliente.TabIndex = 8;
			// 
			// txtRazonSocial
			// 
			this.txtRazonSocial.Location = new System.Drawing.Point(360, 79);
			this.txtRazonSocial.Name = "txtRazonSocial";
			this.txtRazonSocial.Size = new System.Drawing.Size(148, 20);
			this.txtRazonSocial.TabIndex = 9;
			// 
			// txtFecha
			// 
			this.txtFecha.Location = new System.Drawing.Point(235, 101);
			this.txtFecha.Name = "txtFecha";
			this.txtFecha.Size = new System.Drawing.Size(100, 20);
			this.txtFecha.TabIndex = 10;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtFecha);
			this.groupBox1.Controls.Add(this.txtUsuario);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtRazonSocial);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtIdCliente);
			this.groupBox1.Controls.Add(this.txtNumeroFactura);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(590, 141);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Factura";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.btnAgregar);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.txtPrecio);
			this.groupBox2.Controls.Add(this.txtIdCiclo);
			this.groupBox2.Controls.Add(this.txtNombreProd);
			this.groupBox2.Controls.Add(this.txtNombreProy);
			this.groupBox2.Controls.Add(this.txtIdProducto);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.txtIdProyecto);
			this.groupBox2.Controls.Add(this.cboTipoCobro);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Location = new System.Drawing.Point(12, 160);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(590, 163);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Detalle";
			// 
			// btnAgregar
			// 
			this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAgregar.Location = new System.Drawing.Point(499, 126);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(85, 31);
			this.btnAgregar.TabIndex = 14;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(192, 132);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(37, 13);
			this.label13.TabIndex = 13;
			this.label13.Text = "Precio";
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(235, 129);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(121, 20);
			this.txtPrecio.TabIndex = 12;
			// 
			// txtIdCiclo
			// 
			this.txtIdCiclo.Location = new System.Drawing.Point(235, 102);
			this.txtIdCiclo.Name = "txtIdCiclo";
			this.txtIdCiclo.Size = new System.Drawing.Size(47, 20);
			this.txtIdCiclo.TabIndex = 11;
			// 
			// txtNombreProd
			// 
			this.txtNombreProd.Location = new System.Drawing.Point(343, 76);
			this.txtNombreProd.Name = "txtNombreProd";
			this.txtNombreProd.Size = new System.Drawing.Size(165, 20);
			this.txtNombreProd.TabIndex = 10;
			// 
			// txtNombreProy
			// 
			this.txtNombreProy.Location = new System.Drawing.Point(343, 50);
			this.txtNombreProy.Name = "txtNombreProy";
			this.txtNombreProy.Size = new System.Drawing.Size(165, 20);
			this.txtNombreProy.TabIndex = 9;
			// 
			// txtIdProducto
			// 
			this.txtIdProducto.Location = new System.Drawing.Point(235, 76);
			this.txtIdProducto.Name = "txtIdProducto";
			this.txtIdProducto.Size = new System.Drawing.Size(47, 20);
			this.txtIdProducto.TabIndex = 8;
			this.txtIdProducto.TextChanged += new System.EventHandler(this.txtIdProducto_TextChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(137, 105);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(94, 13);
			this.label12.TabIndex = 7;
			this.label12.Text = "Id Ciclo de Prueba";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(293, 79);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(44, 13);
			this.label11.TabIndex = 6;
			this.label11.Text = "Nombre";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(169, 79);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(62, 13);
			this.label10.TabIndex = 5;
			this.label10.Text = "Id Producto";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(293, 54);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(44, 13);
			this.label9.TabIndex = 4;
			this.label9.Text = "Nombre";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(168, 54);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(61, 13);
			this.label8.TabIndex = 3;
			this.label8.Text = "Id Proyecto";
			// 
			// txtIdProyecto
			// 
			this.txtIdProyecto.Location = new System.Drawing.Point(235, 50);
			this.txtIdProyecto.Name = "txtIdProyecto";
			this.txtIdProyecto.Size = new System.Drawing.Size(47, 20);
			this.txtIdProyecto.TabIndex = 2;
			this.txtIdProyecto.TextChanged += new System.EventHandler(this.txtIdProyecto_TextChanged);
			// 
			// cboTipoCobro
			// 
			this.cboTipoCobro.FormattingEnabled = true;
			this.cboTipoCobro.Items.AddRange(new object[] {
            "Por Producto",
            "Por Proyecto",
            "Por Ciclo de Prueba"});
			this.cboTipoCobro.Location = new System.Drawing.Point(235, 23);
			this.cboTipoCobro.Name = "cboTipoCobro";
			this.cboTipoCobro.Size = new System.Drawing.Size(121, 21);
			this.cboTipoCobro.TabIndex = 1;
			this.cboTipoCobro.SelectedIndexChanged += new System.EventHandler(this.cboTipoCobro_SelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(153, 26);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Tipo De Cobro";
			// 
			// grdDetallesFactura
			// 
			this.grdDetallesFactura.AllowUserToAddRows = false;
			this.grdDetallesFactura.AllowUserToDeleteRows = false;
			this.grdDetallesFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdDetallesFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdDetallesFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noOrden,
            this.TipoCobro,
            this.IdCobrado,
            this.Precio});
			this.grdDetallesFactura.Location = new System.Drawing.Point(78, 329);
			this.grdDetallesFactura.Name = "grdDetallesFactura";
			this.grdDetallesFactura.RowHeadersVisible = false;
			this.grdDetallesFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdDetallesFactura.Size = new System.Drawing.Size(481, 150);
			this.grdDetallesFactura.TabIndex = 13;
			// 
			// noOrden
			// 
			this.noOrden.HeaderText = "Nro";
			this.noOrden.Name = "noOrden";
			// 
			// TipoCobro
			// 
			this.TipoCobro.HeaderText = "Cobrando";
			this.TipoCobro.Name = "TipoCobro";
			// 
			// IdCobrado
			// 
			this.IdCobrado.HeaderText = "Elemento cobrado";
			this.IdCobrado.Name = "IdCobrado";
			this.IdCobrado.Width = 150;
			// 
			// Precio
			// 
			this.Precio.HeaderText = "Precio";
			this.Precio.Name = "Precio";
			this.Precio.Width = 120;
			// 
			// label14
			// 
			this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(392, 487);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(31, 13);
			this.label14.TabIndex = 14;
			this.label14.Text = "Total";
			// 
			// txtTotal
			// 
			this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTotal.Location = new System.Drawing.Point(429, 484);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.ReadOnly = true;
			this.txtTotal.Size = new System.Drawing.Size(130, 20);
			this.txtTotal.TabIndex = 15;
			this.txtTotal.Text = "0";
			this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnFacturar
			// 
			this.btnFacturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFacturar.Location = new System.Drawing.Point(513, 534);
			this.btnFacturar.Name = "btnFacturar";
			this.btnFacturar.Size = new System.Drawing.Size(91, 34);
			this.btnFacturar.TabIndex = 16;
			this.btnFacturar.Text = "Facturar";
			this.btnFacturar.UseVisualStyleBackColor = true;
			this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSalir.Location = new System.Drawing.Point(416, 534);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(91, 34);
			this.btnSalir.TabIndex = 17;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// frmFacturacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(616, 580);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnFacturar);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.grdDetallesFactura);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmFacturacion";
			this.Text = "Facturacion";
			this.Load += new System.EventHandler(this.frmFacturacion_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDetallesFactura)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtIdCiclo;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.TextBox txtNombreProy;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdProyecto;
        private System.Windows.Forms.ComboBox cboTipoCobro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView grdDetallesFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCobro;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCobrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnSalir;
    }
}