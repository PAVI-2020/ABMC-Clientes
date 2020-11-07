namespace ABMC_Clientes.GUI
{
    partial class frmABMCContactos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMCContactos));
			this.btnAgregarContacto = new System.Windows.Forms.Button();
			this.btnEditarContacto = new System.Windows.Forms.Button();
			this.btnEliminarContacto = new System.Windows.Forms.Button();
			this.btnConsultarContacto = new System.Windows.Forms.Button();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtMail = new System.Windows.Forms.TextBox();
			this.lblNom = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.grdContactos = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Teléfono = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAceptar = new ABMC_Clientes.GUI.MaterialButton();
			this.btnCancelar = new ABMC_Clientes.GUI.MaterialButton();
			this.btnSalir = new System.Windows.Forms.Button();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.grdContactos)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAgregarContacto
			// 
			this.btnAgregarContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAgregarContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(148)))), ((int)(((byte)(209)))));
			this.btnAgregarContacto.FlatAppearance.BorderSize = 0;
			this.btnAgregarContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregarContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregarContacto.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnAgregarContacto.Image = global::ABMC_Clientes.Properties.Resources.icn_add;
			this.btnAgregarContacto.Location = new System.Drawing.Point(3, 3);
			this.btnAgregarContacto.Name = "btnAgregarContacto";
			this.btnAgregarContacto.Size = new System.Drawing.Size(151, 50);
			this.btnAgregarContacto.TabIndex = 0;
			this.btnAgregarContacto.UseVisualStyleBackColor = false;
			this.btnAgregarContacto.Click += new System.EventHandler(this.btnAgregarContacto_Click);
			// 
			// btnEditarContacto
			// 
			this.btnEditarContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEditarContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(148)))), ((int)(((byte)(209)))));
			this.btnEditarContacto.FlatAppearance.BorderSize = 0;
			this.btnEditarContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditarContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditarContacto.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnEditarContacto.Image = global::ABMC_Clientes.Properties.Resources.icn_edit;
			this.btnEditarContacto.Location = new System.Drawing.Point(160, 3);
			this.btnEditarContacto.Name = "btnEditarContacto";
			this.btnEditarContacto.Size = new System.Drawing.Size(151, 50);
			this.btnEditarContacto.TabIndex = 1;
			this.btnEditarContacto.UseVisualStyleBackColor = false;
			this.btnEditarContacto.Click += new System.EventHandler(this.btnEditarContacto_Click);
			// 
			// btnEliminarContacto
			// 
			this.btnEliminarContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEliminarContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(148)))), ((int)(((byte)(209)))));
			this.btnEliminarContacto.FlatAppearance.BorderSize = 0;
			this.btnEliminarContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminarContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminarContacto.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnEliminarContacto.Image = global::ABMC_Clientes.Properties.Resources.outline_delete_forever_white_36dp;
			this.btnEliminarContacto.Location = new System.Drawing.Point(317, 3);
			this.btnEliminarContacto.Name = "btnEliminarContacto";
			this.btnEliminarContacto.Size = new System.Drawing.Size(151, 50);
			this.btnEliminarContacto.TabIndex = 2;
			this.btnEliminarContacto.UseVisualStyleBackColor = false;
			this.btnEliminarContacto.Click += new System.EventHandler(this.btnEliminarContacto_Click);
			// 
			// btnConsultarContacto
			// 
			this.btnConsultarContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnConsultarContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(148)))), ((int)(((byte)(209)))));
			this.btnConsultarContacto.FlatAppearance.BorderSize = 0;
			this.btnConsultarContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConsultarContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConsultarContacto.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnConsultarContacto.Image = global::ABMC_Clientes.Properties.Resources.icn_find;
			this.btnConsultarContacto.Location = new System.Drawing.Point(474, 3);
			this.btnConsultarContacto.Name = "btnConsultarContacto";
			this.btnConsultarContacto.Size = new System.Drawing.Size(153, 50);
			this.btnConsultarContacto.TabIndex = 3;
			this.btnConsultarContacto.UseVisualStyleBackColor = false;
			this.btnConsultarContacto.Click += new System.EventHandler(this.btnConsultarContacto_Click);
			// 
			// txtNombre
			// 
			this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(408, 3);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(219, 22);
			this.txtNombre.TabIndex = 4;
			// 
			// txtApellido
			// 
			this.txtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellido.Location = new System.Drawing.Point(408, 33);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(219, 22);
			this.txtApellido.TabIndex = 5;
			// 
			// txtId
			// 
			this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtId.Location = new System.Drawing.Point(93, 3);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(219, 22);
			this.txtId.TabIndex = 6;
			// 
			// txtMail
			// 
			this.txtMail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMail.Location = new System.Drawing.Point(93, 33);
			this.txtMail.Name = "txtMail";
			this.txtMail.Size = new System.Drawing.Size(219, 22);
			this.txtMail.TabIndex = 7;
			// 
			// lblNom
			// 
			this.lblNom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNom.AutoSize = true;
			this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNom.Location = new System.Drawing.Point(318, 3);
			this.lblNom.Margin = new System.Windows.Forms.Padding(3);
			this.lblNom.Name = "lblNom";
			this.lblNom.Size = new System.Drawing.Size(84, 24);
			this.lblNom.TabIndex = 8;
			this.lblNom.Text = "Nombre:";
			this.lblNom.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(318, 33);
			this.label1.Margin = new System.Windows.Forms.Padding(3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 24);
			this.label1.TabIndex = 9;
			this.label1.Text = "Apellido:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 3);
			this.label2.Margin = new System.Windows.Forms.Padding(3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 24);
			this.label2.TabIndex = 10;
			this.label2.Text = "Id: ";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(3, 33);
			this.label3.Margin = new System.Windows.Forms.Padding(3);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 24);
			this.label3.TabIndex = 11;
			this.label3.Text = "Email:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// grdContactos
			// 
			this.grdContactos.AllowUserToAddRows = false;
			this.grdContactos.AllowUserToDeleteRows = false;
			this.grdContactos.AllowUserToResizeColumns = false;
			this.grdContactos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdContactos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellido,
            this.Email,
            this.Teléfono});
			this.grdContactos.Location = new System.Drawing.Point(3, 154);
			this.grdContactos.Name = "grdContactos";
			this.grdContactos.ReadOnly = true;
			this.grdContactos.RowHeadersVisible = false;
			this.grdContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdContactos.Size = new System.Drawing.Size(624, 180);
			this.grdContactos.TabIndex = 12;
			this.grdContactos.SelectionChanged += new System.EventHandler(this.grdContactos_SelectionChanged);
			// 
			// Id
			// 
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Width = 50;
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			this.Nombre.Width = 107;
			// 
			// Apellido
			// 
			this.Apellido.HeaderText = "Apellido";
			this.Apellido.Name = "Apellido";
			this.Apellido.ReadOnly = true;
			this.Apellido.Width = 107;
			// 
			// Email
			// 
			this.Email.HeaderText = "Email";
			this.Email.Name = "Email";
			this.Email.ReadOnly = true;
			this.Email.Width = 175;
			// 
			// Teléfono
			// 
			this.Teléfono.HeaderText = "Teléfono";
			this.Teléfono.Name = "Teléfono";
			this.Teléfono.ReadOnly = true;
			this.Teléfono.Width = 120;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(209)))), ((int)(((byte)(29)))));
			this.btnAceptar.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(105)))), ((int)(((byte)(56)))));
			this.btnAceptar.FlatAppearance.BorderSize = 0;
			this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnAceptar.Image = global::ABMC_Clientes.Properties.Resources.icn_accept;
			this.btnAceptar.Location = new System.Drawing.Point(3, 3);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.RegularColor = System.Drawing.Color.White;
			this.btnAceptar.Size = new System.Drawing.Size(49, 49);
			this.btnAceptar.TabIndex = 14;
			this.btnAceptar.UseVisualStyleBackColor = false;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(44)))), ((int)(((byte)(27)))));
			this.btnCancelar.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(78)))), ((int)(((byte)(74)))));
			this.btnCancelar.FlatAppearance.BorderSize = 0;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnCancelar.Image = global::ABMC_Clientes.Properties.Resources.icn_cancel;
			this.btnCancelar.Location = new System.Drawing.Point(58, 3);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.RegularColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(44)))), ((int)(((byte)(27)))));
			this.btnCancelar.Size = new System.Drawing.Size(49, 49);
			this.btnCancelar.TabIndex = 15;
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(44)))), ((int)(((byte)(27)))));
			this.btnSalir.FlatAppearance.BorderSize = 0;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnSalir.Image = global::ABMC_Clientes.Properties.Resources.icn_exit;
			this.btnSalir.Location = new System.Drawing.Point(578, 3);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(49, 49);
			this.btnSalir.TabIndex = 16;
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// txtTelefono
			// 
			this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefono.Location = new System.Drawing.Point(408, 63);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(219, 22);
			this.txtTelefono.TabIndex = 17;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(318, 63);
			this.label4.Margin = new System.Windows.Forms.Padding(3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 30);
			this.label4.TabIndex = 18;
			this.label4.Text = "Teléfono:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Controls.Add(this.btnAgregarContacto, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnEditarContacto, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnEliminarContacto, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnConsultarContacto, 3, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(630, 55);
			this.tableLayoutPanel1.TabIndex = 19;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel3.ColumnCount = 4;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
			this.tableLayoutPanel3.Controls.Add(this.btnAceptar, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.btnCancelar, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.btnSalir, 3, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 337);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(630, 55);
			this.tableLayoutPanel3.TabIndex = 21;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel4.ColumnCount = 1;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Controls.Add(this.grdContactos, 0, 2);
			this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 0, 3);
			this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel1, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
			this.tableLayoutPanel4.Location = new System.Drawing.Point(9, 9);
			this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 4;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(630, 392);
			this.tableLayoutPanel4.TabIndex = 22;
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel5.ColumnCount = 4;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.Controls.Add(this.txtNombre, 3, 0);
			this.tableLayoutPanel5.Controls.Add(this.txtTelefono, 3, 2);
			this.tableLayoutPanel5.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel5.Controls.Add(this.txtApellido, 3, 1);
			this.tableLayoutPanel5.Controls.Add(this.label4, 2, 2);
			this.tableLayoutPanel5.Controls.Add(this.txtId, 1, 0);
			this.tableLayoutPanel5.Controls.Add(this.lblNom, 2, 0);
			this.tableLayoutPanel5.Controls.Add(this.label1, 2, 1);
			this.tableLayoutPanel5.Controls.Add(this.label3, 0, 1);
			this.tableLayoutPanel5.Controls.Add(this.txtMail, 1, 1);
			this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 55);
			this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 3;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(630, 96);
			this.tableLayoutPanel5.TabIndex = 17;
			// 
			// frmABMCContactos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(648, 410);
			this.Controls.Add(this.tableLayoutPanel4);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(602, 343);
			this.Name = "frmABMCContactos";
			this.Text = "Administracion Contactos";
			this.Load += new System.EventHandler(this.FormABMCContactos_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdContactos)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel5.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarContacto;
        private System.Windows.Forms.Button btnEditarContacto;
        private System.Windows.Forms.Button btnEliminarContacto;
        private System.Windows.Forms.Button btnConsultarContacto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grdContactos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teléfono;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private MaterialButton btnAceptar;
		private MaterialButton btnCancelar;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
	}
}