namespace Sis_Administracion.Formularios
{
    partial class _09_ABM_FacturaVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_09_ABM_FacturaVentas));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlCantidad = new System.Windows.Forms.Panel();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.pnlCodigoDescripcion = new System.Windows.Forms.Panel();
            this.cboCodigoDescripcion = new System.Windows.Forms.ComboBox();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlSujeto = new System.Windows.Forms.Panel();
            this.cboSujeto = new System.Windows.Forms.ComboBox();
            this.pnlFecha = new System.Windows.Forms.Panel();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.pnlTipoComprobante = new System.Windows.Forms.Panel();
            this.cboTIpoComprobante = new System.Windows.Forms.ComboBox();
            this.pnlNumeroComprobante = new System.Windows.Forms.Panel();
            this.txtNumeroComprobante = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminarItem = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlFormaPago = new System.Windows.Forms.Panel();
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlCantidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.pnlCodigoDescripcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.pnlSujeto.SuspendLayout();
            this.pnlFecha.SuspendLayout();
            this.pnlTipoComprobante.SuspendLayout();
            this.pnlNumeroComprobante.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.pnlFormaPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 28);
            this.label5.TabIndex = 81;
            this.label5.Text = "CODIGO | DESCRIPCION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 28);
            this.label6.TabIndex = 80;
            this.label6.Text = "CANT";
            // 
            // pnlCantidad
            // 
            this.pnlCantidad.AutoSize = true;
            this.pnlCantidad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlCantidad.BackColor = System.Drawing.Color.White;
            this.pnlCantidad.Controls.Add(this.nudCantidad);
            this.pnlCantidad.Location = new System.Drawing.Point(18, 166);
            this.pnlCantidad.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCantidad.Name = "pnlCantidad";
            this.pnlCantidad.Padding = new System.Windows.Forms.Padding(6);
            this.pnlCantidad.Size = new System.Drawing.Size(93, 45);
            this.pnlCantidad.TabIndex = 79;
            // 
            // nudCantidad
            // 
            this.nudCantidad.AutoSize = true;
            this.nudCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudCantidad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(9, 10);
            this.nudCantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(75, 26);
            this.nudCantidad.TabIndex = 0;
            this.nudCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pnlCodigoDescripcion
            // 
            this.pnlCodigoDescripcion.BackColor = System.Drawing.Color.White;
            this.pnlCodigoDescripcion.Controls.Add(this.cboCodigoDescripcion);
            this.pnlCodigoDescripcion.Location = new System.Drawing.Point(122, 166);
            this.pnlCodigoDescripcion.Name = "pnlCodigoDescripcion";
            this.pnlCodigoDescripcion.Padding = new System.Windows.Forms.Padding(4);
            this.pnlCodigoDescripcion.Size = new System.Drawing.Size(484, 45);
            this.pnlCodigoDescripcion.TabIndex = 78;
            // 
            // cboCodigoDescripcion
            // 
            this.cboCodigoDescripcion.BackColor = System.Drawing.Color.White;
            this.cboCodigoDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCodigoDescripcion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCodigoDescripcion.FormattingEnabled = true;
            this.cboCodigoDescripcion.Items.AddRange(new object[] {
            "Fede",
            "Rico",
            "Rios"});
            this.cboCodigoDescripcion.Location = new System.Drawing.Point(10, 8);
            this.cboCodigoDescripcion.MaxDropDownItems = 100;
            this.cboCodigoDescripcion.Name = "cboCodigoDescripcion";
            this.cboCodigoDescripcion.Size = new System.Drawing.Size(463, 31);
            this.cboCodigoDescripcion.TabIndex = 0;
            this.cboCodigoDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboCodigoDescripcion_KeyPress);
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListado.BackgroundColor = System.Drawing.Color.White;
            this.dgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListado.Location = new System.Drawing.Point(16, 222);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListado.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvListado.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListado.RowTemplate.Height = 32;
            this.dgvListado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(1102, 357);
            this.dgvListado.TabIndex = 75;
            this.dgvListado.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_RowEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(510, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 28);
            this.label4.TabIndex = 74;
            this.label4.Text = "NOMBRE | RAZÓN SOCIAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 28);
            this.label3.TabIndex = 73;
            this.label3.Text = "FECHA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 72;
            this.label2.Text = "NÚMERO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 28);
            this.label1.TabIndex = 71;
            this.label1.Text = "TIPO";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(18, 720);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btnGuardar.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btnGuardar.Size = new System.Drawing.Size(130, 46);
            this.btnGuardar.TabIndex = 66;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // pnlSujeto
            // 
            this.pnlSujeto.AutoSize = true;
            this.pnlSujeto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSujeto.BackColor = System.Drawing.Color.White;
            this.pnlSujeto.Controls.Add(this.cboSujeto);
            this.pnlSujeto.Location = new System.Drawing.Point(505, 58);
            this.pnlSujeto.Margin = new System.Windows.Forms.Padding(8, 8, 0, 8);
            this.pnlSujeto.Name = "pnlSujeto";
            this.pnlSujeto.Padding = new System.Windows.Forms.Padding(4);
            this.pnlSujeto.Size = new System.Drawing.Size(426, 47);
            this.pnlSujeto.TabIndex = 70;
            // 
            // cboSujeto
            // 
            this.cboSujeto.BackColor = System.Drawing.Color.White;
            this.cboSujeto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSujeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSujeto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSujeto.FormattingEnabled = true;
            this.cboSujeto.Items.AddRange(new object[] {
            "FA",
            "FB"});
            this.cboSujeto.Location = new System.Drawing.Point(10, 9);
            this.cboSujeto.MaxDropDownItems = 100;
            this.cboSujeto.Name = "cboSujeto";
            this.cboSujeto.Size = new System.Drawing.Size(409, 31);
            this.cboSujeto.TabIndex = 2;
            // 
            // pnlFecha
            // 
            this.pnlFecha.AutoSize = true;
            this.pnlFecha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFecha.BackColor = System.Drawing.Color.White;
            this.pnlFecha.Controls.Add(this.dtpFecha);
            this.pnlFecha.Location = new System.Drawing.Point(17, 58);
            this.pnlFecha.Margin = new System.Windows.Forms.Padding(8, 8, 0, 8);
            this.pnlFecha.Name = "pnlFecha";
            this.pnlFecha.Padding = new System.Windows.Forms.Padding(12, 12, 6, 6);
            this.pnlFecha.Size = new System.Drawing.Size(144, 47);
            this.pnlFecha.TabIndex = 69;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(9, 8);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(126, 30);
            this.dtpFecha.TabIndex = 0;
            // 
            // pnlTipoComprobante
            // 
            this.pnlTipoComprobante.AutoSize = true;
            this.pnlTipoComprobante.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTipoComprobante.BackColor = System.Drawing.Color.White;
            this.pnlTipoComprobante.Controls.Add(this.cboTIpoComprobante);
            this.pnlTipoComprobante.Location = new System.Drawing.Point(182, 59);
            this.pnlTipoComprobante.Margin = new System.Windows.Forms.Padding(8, 8, 0, 8);
            this.pnlTipoComprobante.Name = "pnlTipoComprobante";
            this.pnlTipoComprobante.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pnlTipoComprobante.Size = new System.Drawing.Size(86, 46);
            this.pnlTipoComprobante.TabIndex = 68;
            // 
            // cboTIpoComprobante
            // 
            this.cboTIpoComprobante.BackColor = System.Drawing.Color.White;
            this.cboTIpoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTIpoComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTIpoComprobante.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTIpoComprobante.FormattingEnabled = true;
            this.cboTIpoComprobante.Items.AddRange(new object[] {
            "FA",
            "FB"});
            this.cboTIpoComprobante.Location = new System.Drawing.Point(6, 6);
            this.cboTIpoComprobante.MaxDropDownItems = 100;
            this.cboTIpoComprobante.Name = "cboTIpoComprobante";
            this.cboTIpoComprobante.Size = new System.Drawing.Size(73, 31);
            this.cboTIpoComprobante.TabIndex = 1;
            // 
            // pnlNumeroComprobante
            // 
            this.pnlNumeroComprobante.AutoSize = true;
            this.pnlNumeroComprobante.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlNumeroComprobante.BackColor = System.Drawing.Color.White;
            this.pnlNumeroComprobante.Controls.Add(this.txtNumeroComprobante);
            this.pnlNumeroComprobante.Location = new System.Drawing.Point(276, 58);
            this.pnlNumeroComprobante.Margin = new System.Windows.Forms.Padding(8, 8, 0, 8);
            this.pnlNumeroComprobante.Name = "pnlNumeroComprobante";
            this.pnlNumeroComprobante.Padding = new System.Windows.Forms.Padding(12);
            this.pnlNumeroComprobante.Size = new System.Drawing.Size(197, 47);
            this.pnlNumeroComprobante.TabIndex = 67;
            // 
            // txtNumeroComprobante
            // 
            this.txtNumeroComprobante.BackColor = System.Drawing.Color.White;
            this.txtNumeroComprobante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroComprobante.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroComprobante.ForeColor = System.Drawing.Color.Black;
            this.txtNumeroComprobante.Location = new System.Drawing.Point(12, 12);
            this.txtNumeroComprobante.Margin = new System.Windows.Forms.Padding(0);
            this.txtNumeroComprobante.MaxLength = 30;
            this.txtNumeroComprobante.Name = "txtNumeroComprobante";
            this.txtNumeroComprobante.Size = new System.Drawing.Size(173, 23);
            this.txtNumeroComprobante.TabIndex = 1;
            this.txtNumeroComprobante.Tag = "";
            this.txtNumeroComprobante.Text = "1";
            this.txtNumeroComprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = global::Sis_Administracion.Properties.Resources.ic_file_download_white_24dp;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(618, 166);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btnAgregar.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnAgregar.Size = new System.Drawing.Size(121, 45);
            this.btnAgregar.TabIndex = 85;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminarItem
            // 
            this.btnEliminarItem.AutoSize = true;
            this.btnEliminarItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEliminarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminarItem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminarItem.FlatAppearance.BorderSize = 0;
            this.btnEliminarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarItem.ForeColor = System.Drawing.Color.White;
            this.btnEliminarItem.Image = global::Sis_Administracion.Properties.Resources.ic_highlight_off_white_24dp;
            this.btnEliminarItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarItem.Location = new System.Drawing.Point(755, 166);
            this.btnEliminarItem.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btnEliminarItem.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnEliminarItem.Name = "btnEliminarItem";
            this.btnEliminarItem.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnEliminarItem.Size = new System.Drawing.Size(161, 45);
            this.btnEliminarItem.TabIndex = 84;
            this.btnEliminarItem.Text = "Eliminar Item";
            this.btnEliminarItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarItem.UseVisualStyleBackColor = false;
            this.btnEliminarItem.Click += new System.EventHandler(this.btnEliminarItem_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.AutoSize = true;
            this.btnNuevoCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoCliente.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNuevoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevoCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevoCliente.FlatAppearance.BorderSize = 0;
            this.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.ForeColor = System.Drawing.Color.White;
            this.btnNuevoCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoCliente.Image")));
            this.btnNuevoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoCliente.Location = new System.Drawing.Point(942, 58);
            this.btnNuevoCliente.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btnNuevoCliente.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnNuevoCliente.Size = new System.Drawing.Size(169, 45);
            this.btnNuevoCliente.TabIndex = 83;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarProducto.AutoSize = true;
            this.btnAgregarProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarProducto.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgregarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarProducto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProducto.Image")));
            this.btnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProducto.Location = new System.Drawing.Point(932, 166);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btnAgregarProducto.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnAgregarProducto.Size = new System.Drawing.Size(186, 45);
            this.btnAgregarProducto.TabIndex = 82;
            this.btnAgregarProducto.Text = "Nuevo Producto";
            this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // pnlTotal
            // 
            this.pnlTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTotal.AutoSize = true;
            this.pnlTotal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTotal.BackColor = System.Drawing.Color.White;
            this.pnlTotal.Controls.Add(this.lblTotal);
            this.pnlTotal.Location = new System.Drawing.Point(922, 590);
            this.pnlTotal.Margin = new System.Windows.Forms.Padding(8, 8, 0, 8);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Padding = new System.Windows.Forms.Padding(12);
            this.pnlTotal.Size = new System.Drawing.Size(196, 52);
            this.pnlTotal.TabIndex = 67;
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(11, 12);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(170, 28);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "$  10.000,00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(841, 602);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 28);
            this.label7.TabIndex = 72;
            this.label7.Text = "TOTAL";
            // 
            // pnlFormaPago
            // 
            this.pnlFormaPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormaPago.AutoSize = true;
            this.pnlFormaPago.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFormaPago.BackColor = System.Drawing.Color.White;
            this.pnlFormaPago.Controls.Add(this.cboFormaPago);
            this.pnlFormaPago.Location = new System.Drawing.Point(922, 658);
            this.pnlFormaPago.Margin = new System.Windows.Forms.Padding(8, 8, 0, 8);
            this.pnlFormaPago.Name = "pnlFormaPago";
            this.pnlFormaPago.Padding = new System.Windows.Forms.Padding(4);
            this.pnlFormaPago.Size = new System.Drawing.Size(197, 46);
            this.pnlFormaPago.TabIndex = 68;
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.BackColor = System.Drawing.Color.White;
            this.cboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormaPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFormaPago.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Items.AddRange(new object[] {
            "FA",
            "FB"});
            this.cboFormaPago.Location = new System.Drawing.Point(17, 8);
            this.cboFormaPago.MaxDropDownItems = 100;
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(173, 31);
            this.cboFormaPago.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(742, 666);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 28);
            this.label9.TabIndex = 71;
            this.label9.Text = "FORMA DE PAGO";
            // 
            // _09_ABM_FacturasCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1135, 779);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminarItem);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnlCantidad);
            this.Controls.Add(this.pnlCodigoDescripcion);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnlSujeto);
            this.Controls.Add(this.pnlFecha);
            this.Controls.Add(this.pnlFormaPago);
            this.Controls.Add(this.pnlTotal);
            this.Controls.Add(this.pnlTipoComprobante);
            this.Controls.Add(this.pnlNumeroComprobante);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(1153, 826);
            this.Name = "_09_ABM_FacturasCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "_09_ABM_FacturasCompras";
            this.pnlCantidad.ResumeLayout(false);
            this.pnlCantidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.pnlCodigoDescripcion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.pnlSujeto.ResumeLayout(false);
            this.pnlFecha.ResumeLayout(false);
            this.pnlTipoComprobante.ResumeLayout(false);
            this.pnlNumeroComprobante.ResumeLayout(false);
            this.pnlNumeroComprobante.PerformLayout();
            this.pnlTotal.ResumeLayout(false);
            this.pnlFormaPago.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminarItem;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlCantidad;
        private System.Windows.Forms.Panel pnlCodigoDescripcion;
        private System.Windows.Forms.ComboBox cboCodigoDescripcion;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pnlSujeto;
        private System.Windows.Forms.ComboBox cboSujeto;
        private System.Windows.Forms.Panel pnlFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Panel pnlTipoComprobante;
        private System.Windows.Forms.ComboBox cboTIpoComprobante;
        private System.Windows.Forms.Panel pnlNumeroComprobante;
        private System.Windows.Forms.TextBox txtNumeroComprobante;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel pnlFormaPago;
        private System.Windows.Forms.ComboBox cboFormaPago;
        private System.Windows.Forms.Label label9;
    }
}