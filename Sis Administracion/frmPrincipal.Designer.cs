namespace Sis_Administracion
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnlBarraNavegacion = new System.Windows.Forms.Panel();
            this.pnlNavegacionControles = new System.Windows.Forms.Panel();
            this.btnCerrarApp = new System.Windows.Forms.Button();
            this.pnlDatosEmpresa = new System.Windows.Forms.Panel();
            this.lblEmpresaNombre = new System.Windows.Forms.Label();
            this.picEmpresaLogo = new System.Windows.Forms.PictureBox();
            this.flpMenuLateral = new System.Windows.Forms.FlowLayoutPanel();
            this.flpMenuUsuario = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMenuUsuario = new System.Windows.Forms.Button();
            this.flpMenuVentas = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMenuVentasTitulo = new System.Windows.Forms.Label();
            this.btnMenuVentasClientes = new System.Windows.Forms.Button();
            this.btnMenuVentasFacturas = new System.Windows.Forms.Button();
            this.btnMenuVentasCaja = new System.Windows.Forms.Button();
            this.btnMenuVentasMovimientos = new System.Windows.Forms.Button();
            this.flpMenuCompras = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMenuComprasTitulo = new System.Windows.Forms.Label();
            this.btnComprasProveedores = new System.Windows.Forms.Button();
            this.btnComprasFacturas = new System.Windows.Forms.Button();
            this.btnComprasPago = new System.Windows.Forms.Button();
            this.flpMenuStock = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMenuStockTitulo = new System.Windows.Forms.Label();
            this.btnStockProductos = new System.Windows.Forms.Button();
            this.btnStockMovimientos = new System.Windows.Forms.Button();
            this.brnStockValorizacion = new System.Windows.Forms.Button();
            this.btnStockControl = new System.Windows.Forms.Button();
            this.flpMenuConfiguracion = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMenuConfiguracion = new System.Windows.Forms.Button();
            this.pnlFormConteiner = new System.Windows.Forms.Panel();
            this.pnlBarraNavegacion.SuspendLayout();
            this.pnlNavegacionControles.SuspendLayout();
            this.pnlDatosEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmpresaLogo)).BeginInit();
            this.flpMenuLateral.SuspendLayout();
            this.flpMenuUsuario.SuspendLayout();
            this.flpMenuVentas.SuspendLayout();
            this.flpMenuCompras.SuspendLayout();
            this.flpMenuStock.SuspendLayout();
            this.flpMenuConfiguracion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraNavegacion
            // 
            this.pnlBarraNavegacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlBarraNavegacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlBarraNavegacion.Controls.Add(this.pnlNavegacionControles);
            this.pnlBarraNavegacion.Controls.Add(this.pnlDatosEmpresa);
            this.pnlBarraNavegacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraNavegacion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBarraNavegacion.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraNavegacion.MinimumSize = new System.Drawing.Size(0, 40);
            this.pnlBarraNavegacion.Name = "pnlBarraNavegacion";
            this.pnlBarraNavegacion.Size = new System.Drawing.Size(1280, 40);
            this.pnlBarraNavegacion.TabIndex = 0;
            // 
            // pnlNavegacionControles
            // 
            this.pnlNavegacionControles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNavegacionControles.AutoSize = true;
            this.pnlNavegacionControles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlNavegacionControles.BackColor = System.Drawing.Color.Transparent;
            this.pnlNavegacionControles.Controls.Add(this.btnCerrarApp);
            this.pnlNavegacionControles.Location = new System.Drawing.Point(1032, 0);
            this.pnlNavegacionControles.MinimumSize = new System.Drawing.Size(240, 24);
            this.pnlNavegacionControles.Name = "pnlNavegacionControles";
            this.pnlNavegacionControles.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.pnlNavegacionControles.Size = new System.Drawing.Size(248, 44);
            this.pnlNavegacionControles.TabIndex = 2;
            // 
            // btnCerrarApp
            // 
            this.btnCerrarApp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCerrarApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCerrarApp.FlatAppearance.BorderSize = 0;
            this.btnCerrarApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarApp.ForeColor = System.Drawing.Color.Transparent;
            this.btnCerrarApp.Image = global::Sis_Administracion.Properties.Resources.ic_cancel_white_24dp;
            this.btnCerrarApp.Location = new System.Drawing.Point(205, 5);
            this.btnCerrarApp.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnCerrarApp.Name = "btnCerrarApp";
            this.btnCerrarApp.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btnCerrarApp.Size = new System.Drawing.Size(32, 32);
            this.btnCerrarApp.TabIndex = 0;
            this.btnCerrarApp.UseVisualStyleBackColor = false;
            this.btnCerrarApp.Click += new System.EventHandler(this.btnCerrarApp_Click);
            // 
            // pnlDatosEmpresa
            // 
            this.pnlDatosEmpresa.AutoSize = true;
            this.pnlDatosEmpresa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlDatosEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.pnlDatosEmpresa.Controls.Add(this.lblEmpresaNombre);
            this.pnlDatosEmpresa.Controls.Add(this.picEmpresaLogo);
            this.pnlDatosEmpresa.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDatosEmpresa.Location = new System.Drawing.Point(0, 0);
            this.pnlDatosEmpresa.MinimumSize = new System.Drawing.Size(262, 24);
            this.pnlDatosEmpresa.Name = "pnlDatosEmpresa";
            this.pnlDatosEmpresa.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.pnlDatosEmpresa.Size = new System.Drawing.Size(262, 40);
            this.pnlDatosEmpresa.TabIndex = 0;
            // 
            // lblEmpresaNombre
            // 
            this.lblEmpresaNombre.AutoSize = true;
            this.lblEmpresaNombre.Location = new System.Drawing.Point(44, 9);
            this.lblEmpresaNombre.Name = "lblEmpresaNombre";
            this.lblEmpresaNombre.Size = new System.Drawing.Size(117, 23);
            this.lblEmpresaNombre.TabIndex = 2;
            this.lblEmpresaNombre.Text = "SIS ADMINIST";
            // 
            // picEmpresaLogo
            // 
            this.picEmpresaLogo.Image = ((System.Drawing.Image)(resources.GetObject("picEmpresaLogo.Image")));
            this.picEmpresaLogo.Location = new System.Drawing.Point(14, 9);
            this.picEmpresaLogo.MinimumSize = new System.Drawing.Size(24, 24);
            this.picEmpresaLogo.Name = "picEmpresaLogo";
            this.picEmpresaLogo.Size = new System.Drawing.Size(24, 24);
            this.picEmpresaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picEmpresaLogo.TabIndex = 0;
            this.picEmpresaLogo.TabStop = false;
            // 
            // flpMenuLateral
            // 
            this.flpMenuLateral.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpMenuLateral.Controls.Add(this.flpMenuUsuario);
            this.flpMenuLateral.Controls.Add(this.flpMenuVentas);
            this.flpMenuLateral.Controls.Add(this.flpMenuCompras);
            this.flpMenuLateral.Controls.Add(this.flpMenuStock);
            this.flpMenuLateral.Controls.Add(this.flpMenuConfiguracion);
            this.flpMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpMenuLateral.Location = new System.Drawing.Point(0, 40);
            this.flpMenuLateral.Margin = new System.Windows.Forms.Padding(0);
            this.flpMenuLateral.Name = "flpMenuLateral";
            this.flpMenuLateral.Padding = new System.Windows.Forms.Padding(8);
            this.flpMenuLateral.Size = new System.Drawing.Size(256, 680);
            this.flpMenuLateral.TabIndex = 1;
            // 
            // flpMenuUsuario
            // 
            this.flpMenuUsuario.AutoSize = true;
            this.flpMenuUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpMenuUsuario.BackColor = System.Drawing.Color.SeaShell;
            this.flpMenuUsuario.Controls.Add(this.btnMenuUsuario);
            this.flpMenuUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpMenuUsuario.Location = new System.Drawing.Point(8, 8);
            this.flpMenuUsuario.Margin = new System.Windows.Forms.Padding(0, 0, 0, 32);
            this.flpMenuUsuario.MinimumSize = new System.Drawing.Size(240, 24);
            this.flpMenuUsuario.Name = "flpMenuUsuario";
            this.flpMenuUsuario.Size = new System.Drawing.Size(240, 41);
            this.flpMenuUsuario.TabIndex = 0;
            // 
            // btnMenuUsuario
            // 
            this.btnMenuUsuario.AutoSize = true;
            this.btnMenuUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMenuUsuario.FlatAppearance.BorderSize = 0;
            this.btnMenuUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuUsuario.Image = global::Sis_Administracion.Properties.Resources.ic_face_black_24dp;
            this.btnMenuUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuUsuario.Location = new System.Drawing.Point(0, 0);
            this.btnMenuUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuUsuario.MinimumSize = new System.Drawing.Size(240, 24);
            this.btnMenuUsuario.Name = "btnMenuUsuario";
            this.btnMenuUsuario.Size = new System.Drawing.Size(240, 41);
            this.btnMenuUsuario.TabIndex = 0;
            this.btnMenuUsuario.Text = "NOMRE USUARIO";
            this.btnMenuUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuUsuario.UseVisualStyleBackColor = false;
            // 
            // flpMenuVentas
            // 
            this.flpMenuVentas.AutoSize = true;
            this.flpMenuVentas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpMenuVentas.BackColor = System.Drawing.Color.SeaShell;
            this.flpMenuVentas.Controls.Add(this.lblMenuVentasTitulo);
            this.flpMenuVentas.Controls.Add(this.btnMenuVentasClientes);
            this.flpMenuVentas.Controls.Add(this.btnMenuVentasFacturas);
            this.flpMenuVentas.Controls.Add(this.btnMenuVentasCaja);
            this.flpMenuVentas.Controls.Add(this.btnMenuVentasMovimientos);
            this.flpMenuVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpMenuVentas.Location = new System.Drawing.Point(8, 81);
            this.flpMenuVentas.Margin = new System.Windows.Forms.Padding(0, 0, 0, 32);
            this.flpMenuVentas.MinimumSize = new System.Drawing.Size(240, 24);
            this.flpMenuVentas.Name = "flpMenuVentas";
            this.flpMenuVentas.Size = new System.Drawing.Size(240, 148);
            this.flpMenuVentas.TabIndex = 1;
            // 
            // lblMenuVentasTitulo
            // 
            this.lblMenuVentasTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMenuVentasTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMenuVentasTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuVentasTitulo.Image = global::Sis_Administracion.Properties.Resources.ic_attach_money_black_24dp;
            this.lblMenuVentasTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMenuVentasTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblMenuVentasTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblMenuVentasTitulo.Name = "lblMenuVentasTitulo";
            this.lblMenuVentasTitulo.Size = new System.Drawing.Size(240, 32);
            this.lblMenuVentasTitulo.TabIndex = 0;
            this.lblMenuVentasTitulo.Text = "     VENTAS";
            // 
            // btnMenuVentasClientes
            // 
            this.btnMenuVentasClientes.AutoSize = true;
            this.btnMenuVentasClientes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMenuVentasClientes.FlatAppearance.BorderSize = 0;
            this.btnMenuVentasClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuVentasClientes.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuVentasClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuVentasClientes.Location = new System.Drawing.Point(0, 32);
            this.btnMenuVentasClientes.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuVentasClientes.MinimumSize = new System.Drawing.Size(240, 16);
            this.btnMenuVentasClientes.Name = "btnMenuVentasClientes";
            this.btnMenuVentasClientes.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnMenuVentasClientes.Size = new System.Drawing.Size(240, 29);
            this.btnMenuVentasClientes.TabIndex = 1;
            this.btnMenuVentasClientes.Text = "CLIENTES";
            this.btnMenuVentasClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuVentasClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuVentasClientes.UseVisualStyleBackColor = false;
            this.btnMenuVentasClientes.Click += new System.EventHandler(this.btnMenuVentasClientes_Click);
            // 
            // btnMenuVentasFacturas
            // 
            this.btnMenuVentasFacturas.AutoSize = true;
            this.btnMenuVentasFacturas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMenuVentasFacturas.FlatAppearance.BorderSize = 0;
            this.btnMenuVentasFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuVentasFacturas.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuVentasFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuVentasFacturas.Location = new System.Drawing.Point(0, 61);
            this.btnMenuVentasFacturas.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuVentasFacturas.MinimumSize = new System.Drawing.Size(240, 16);
            this.btnMenuVentasFacturas.Name = "btnMenuVentasFacturas";
            this.btnMenuVentasFacturas.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnMenuVentasFacturas.Size = new System.Drawing.Size(240, 29);
            this.btnMenuVentasFacturas.TabIndex = 2;
            this.btnMenuVentasFacturas.Text = "FACTURAS";
            this.btnMenuVentasFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuVentasFacturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuVentasFacturas.UseVisualStyleBackColor = false;
            // 
            // btnMenuVentasCaja
            // 
            this.btnMenuVentasCaja.AutoSize = true;
            this.btnMenuVentasCaja.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMenuVentasCaja.FlatAppearance.BorderSize = 0;
            this.btnMenuVentasCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuVentasCaja.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuVentasCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuVentasCaja.Location = new System.Drawing.Point(0, 90);
            this.btnMenuVentasCaja.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuVentasCaja.MinimumSize = new System.Drawing.Size(240, 16);
            this.btnMenuVentasCaja.Name = "btnMenuVentasCaja";
            this.btnMenuVentasCaja.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnMenuVentasCaja.Size = new System.Drawing.Size(240, 29);
            this.btnMenuVentasCaja.TabIndex = 3;
            this.btnMenuVentasCaja.Text = "CAJA";
            this.btnMenuVentasCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuVentasCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuVentasCaja.UseVisualStyleBackColor = false;
            // 
            // btnMenuVentasMovimientos
            // 
            this.btnMenuVentasMovimientos.AutoSize = true;
            this.btnMenuVentasMovimientos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMenuVentasMovimientos.FlatAppearance.BorderSize = 0;
            this.btnMenuVentasMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuVentasMovimientos.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuVentasMovimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuVentasMovimientos.Location = new System.Drawing.Point(0, 119);
            this.btnMenuVentasMovimientos.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuVentasMovimientos.MinimumSize = new System.Drawing.Size(240, 16);
            this.btnMenuVentasMovimientos.Name = "btnMenuVentasMovimientos";
            this.btnMenuVentasMovimientos.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnMenuVentasMovimientos.Size = new System.Drawing.Size(240, 29);
            this.btnMenuVentasMovimientos.TabIndex = 4;
            this.btnMenuVentasMovimientos.Text = "MOVIMIENTOS";
            this.btnMenuVentasMovimientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuVentasMovimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuVentasMovimientos.UseVisualStyleBackColor = false;
            // 
            // flpMenuCompras
            // 
            this.flpMenuCompras.AutoSize = true;
            this.flpMenuCompras.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpMenuCompras.BackColor = System.Drawing.Color.SeaShell;
            this.flpMenuCompras.Controls.Add(this.lblMenuComprasTitulo);
            this.flpMenuCompras.Controls.Add(this.btnComprasProveedores);
            this.flpMenuCompras.Controls.Add(this.btnComprasFacturas);
            this.flpMenuCompras.Controls.Add(this.btnComprasPago);
            this.flpMenuCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpMenuCompras.Location = new System.Drawing.Point(8, 261);
            this.flpMenuCompras.Margin = new System.Windows.Forms.Padding(0, 0, 0, 32);
            this.flpMenuCompras.MinimumSize = new System.Drawing.Size(240, 24);
            this.flpMenuCompras.Name = "flpMenuCompras";
            this.flpMenuCompras.Size = new System.Drawing.Size(240, 119);
            this.flpMenuCompras.TabIndex = 2;
            // 
            // lblMenuComprasTitulo
            // 
            this.lblMenuComprasTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMenuComprasTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMenuComprasTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuComprasTitulo.Image = global::Sis_Administracion.Properties.Resources.ic_shopping_cart_black_24dp;
            this.lblMenuComprasTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMenuComprasTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblMenuComprasTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblMenuComprasTitulo.Name = "lblMenuComprasTitulo";
            this.lblMenuComprasTitulo.Size = new System.Drawing.Size(240, 32);
            this.lblMenuComprasTitulo.TabIndex = 1;
            this.lblMenuComprasTitulo.Text = "     COMPRAS";
            // 
            // btnComprasProveedores
            // 
            this.btnComprasProveedores.AutoSize = true;
            this.btnComprasProveedores.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnComprasProveedores.FlatAppearance.BorderSize = 0;
            this.btnComprasProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprasProveedores.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprasProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprasProveedores.Location = new System.Drawing.Point(0, 32);
            this.btnComprasProveedores.Margin = new System.Windows.Forms.Padding(0);
            this.btnComprasProveedores.MinimumSize = new System.Drawing.Size(240, 16);
            this.btnComprasProveedores.Name = "btnComprasProveedores";
            this.btnComprasProveedores.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnComprasProveedores.Size = new System.Drawing.Size(240, 29);
            this.btnComprasProveedores.TabIndex = 5;
            this.btnComprasProveedores.Text = "PROVEEDORES";
            this.btnComprasProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprasProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComprasProveedores.UseVisualStyleBackColor = false;
            this.btnComprasProveedores.Click += new System.EventHandler(this.btnComprasProveedores_Click);
            // 
            // btnComprasFacturas
            // 
            this.btnComprasFacturas.AutoSize = true;
            this.btnComprasFacturas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnComprasFacturas.FlatAppearance.BorderSize = 0;
            this.btnComprasFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprasFacturas.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprasFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprasFacturas.Location = new System.Drawing.Point(0, 61);
            this.btnComprasFacturas.Margin = new System.Windows.Forms.Padding(0);
            this.btnComprasFacturas.MinimumSize = new System.Drawing.Size(240, 16);
            this.btnComprasFacturas.Name = "btnComprasFacturas";
            this.btnComprasFacturas.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnComprasFacturas.Size = new System.Drawing.Size(240, 29);
            this.btnComprasFacturas.TabIndex = 6;
            this.btnComprasFacturas.Text = "FACTURAS";
            this.btnComprasFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprasFacturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComprasFacturas.UseVisualStyleBackColor = false;
            this.btnComprasFacturas.Click += new System.EventHandler(this.btnComprasFacturas_Click);
            // 
            // btnComprasPago
            // 
            this.btnComprasPago.AutoSize = true;
            this.btnComprasPago.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnComprasPago.FlatAppearance.BorderSize = 0;
            this.btnComprasPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprasPago.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprasPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprasPago.Location = new System.Drawing.Point(0, 90);
            this.btnComprasPago.Margin = new System.Windows.Forms.Padding(0);
            this.btnComprasPago.MinimumSize = new System.Drawing.Size(240, 16);
            this.btnComprasPago.Name = "btnComprasPago";
            this.btnComprasPago.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnComprasPago.Size = new System.Drawing.Size(240, 29);
            this.btnComprasPago.TabIndex = 7;
            this.btnComprasPago.Text = "PAGO";
            this.btnComprasPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprasPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComprasPago.UseVisualStyleBackColor = false;
            // 
            // flpMenuStock
            // 
            this.flpMenuStock.AutoSize = true;
            this.flpMenuStock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpMenuStock.BackColor = System.Drawing.Color.SeaShell;
            this.flpMenuStock.Controls.Add(this.lblMenuStockTitulo);
            this.flpMenuStock.Controls.Add(this.btnStockProductos);
            this.flpMenuStock.Controls.Add(this.btnStockMovimientos);
            this.flpMenuStock.Controls.Add(this.brnStockValorizacion);
            this.flpMenuStock.Controls.Add(this.btnStockControl);
            this.flpMenuStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpMenuStock.Location = new System.Drawing.Point(8, 412);
            this.flpMenuStock.Margin = new System.Windows.Forms.Padding(0, 0, 0, 32);
            this.flpMenuStock.MinimumSize = new System.Drawing.Size(240, 24);
            this.flpMenuStock.Name = "flpMenuStock";
            this.flpMenuStock.Size = new System.Drawing.Size(240, 148);
            this.flpMenuStock.TabIndex = 3;
            // 
            // lblMenuStockTitulo
            // 
            this.lblMenuStockTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMenuStockTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMenuStockTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuStockTitulo.Image = global::Sis_Administracion.Properties.Resources.ic_local_shipping_black_24dp;
            this.lblMenuStockTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMenuStockTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblMenuStockTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblMenuStockTitulo.Name = "lblMenuStockTitulo";
            this.lblMenuStockTitulo.Size = new System.Drawing.Size(240, 32);
            this.lblMenuStockTitulo.TabIndex = 1;
            this.lblMenuStockTitulo.Text = "      STOCK";
            // 
            // btnStockProductos
            // 
            this.btnStockProductos.AutoSize = true;
            this.btnStockProductos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStockProductos.FlatAppearance.BorderSize = 0;
            this.btnStockProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockProductos.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockProductos.Location = new System.Drawing.Point(0, 32);
            this.btnStockProductos.Margin = new System.Windows.Forms.Padding(0);
            this.btnStockProductos.MinimumSize = new System.Drawing.Size(240, 16);
            this.btnStockProductos.Name = "btnStockProductos";
            this.btnStockProductos.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnStockProductos.Size = new System.Drawing.Size(240, 29);
            this.btnStockProductos.TabIndex = 8;
            this.btnStockProductos.Text = "PRODUCTOS";
            this.btnStockProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStockProductos.UseVisualStyleBackColor = false;
            this.btnStockProductos.Click += new System.EventHandler(this.btnStockProductos_Click);
            // 
            // btnStockMovimientos
            // 
            this.btnStockMovimientos.AutoSize = true;
            this.btnStockMovimientos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStockMovimientos.FlatAppearance.BorderSize = 0;
            this.btnStockMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockMovimientos.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockMovimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockMovimientos.Location = new System.Drawing.Point(0, 61);
            this.btnStockMovimientos.Margin = new System.Windows.Forms.Padding(0);
            this.btnStockMovimientos.MinimumSize = new System.Drawing.Size(240, 16);
            this.btnStockMovimientos.Name = "btnStockMovimientos";
            this.btnStockMovimientos.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnStockMovimientos.Size = new System.Drawing.Size(240, 29);
            this.btnStockMovimientos.TabIndex = 9;
            this.btnStockMovimientos.Text = "MOVIMIENTOS";
            this.btnStockMovimientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockMovimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStockMovimientos.UseVisualStyleBackColor = false;
            // 
            // brnStockValorizacion
            // 
            this.brnStockValorizacion.AutoSize = true;
            this.brnStockValorizacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.brnStockValorizacion.FlatAppearance.BorderSize = 0;
            this.brnStockValorizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnStockValorizacion.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnStockValorizacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnStockValorizacion.Location = new System.Drawing.Point(0, 90);
            this.brnStockValorizacion.Margin = new System.Windows.Forms.Padding(0);
            this.brnStockValorizacion.MinimumSize = new System.Drawing.Size(240, 16);
            this.brnStockValorizacion.Name = "brnStockValorizacion";
            this.brnStockValorizacion.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.brnStockValorizacion.Size = new System.Drawing.Size(240, 29);
            this.brnStockValorizacion.TabIndex = 10;
            this.brnStockValorizacion.Text = "VALORACION";
            this.brnStockValorizacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnStockValorizacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.brnStockValorizacion.UseVisualStyleBackColor = false;
            // 
            // btnStockControl
            // 
            this.btnStockControl.AutoSize = true;
            this.btnStockControl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStockControl.FlatAppearance.BorderSize = 0;
            this.btnStockControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockControl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockControl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockControl.Location = new System.Drawing.Point(0, 119);
            this.btnStockControl.Margin = new System.Windows.Forms.Padding(0);
            this.btnStockControl.MinimumSize = new System.Drawing.Size(240, 16);
            this.btnStockControl.Name = "btnStockControl";
            this.btnStockControl.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnStockControl.Size = new System.Drawing.Size(240, 29);
            this.btnStockControl.TabIndex = 11;
            this.btnStockControl.Text = "CONTROL DE STOCK";
            this.btnStockControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockControl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStockControl.UseVisualStyleBackColor = false;
            // 
            // flpMenuConfiguracion
            // 
            this.flpMenuConfiguracion.AutoSize = true;
            this.flpMenuConfiguracion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpMenuConfiguracion.BackColor = System.Drawing.Color.SeaShell;
            this.flpMenuConfiguracion.Controls.Add(this.btnMenuConfiguracion);
            this.flpMenuConfiguracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpMenuConfiguracion.Location = new System.Drawing.Point(8, 592);
            this.flpMenuConfiguracion.Margin = new System.Windows.Forms.Padding(0, 0, 0, 32);
            this.flpMenuConfiguracion.MinimumSize = new System.Drawing.Size(240, 24);
            this.flpMenuConfiguracion.Name = "flpMenuConfiguracion";
            this.flpMenuConfiguracion.Size = new System.Drawing.Size(240, 41);
            this.flpMenuConfiguracion.TabIndex = 4;
            // 
            // btnMenuConfiguracion
            // 
            this.btnMenuConfiguracion.AutoSize = true;
            this.btnMenuConfiguracion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMenuConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnMenuConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuConfiguracion.Image = global::Sis_Administracion.Properties.Resources.ic_settings_black_24dp;
            this.btnMenuConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuConfiguracion.Location = new System.Drawing.Point(0, 0);
            this.btnMenuConfiguracion.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuConfiguracion.MinimumSize = new System.Drawing.Size(240, 24);
            this.btnMenuConfiguracion.Name = "btnMenuConfiguracion";
            this.btnMenuConfiguracion.Size = new System.Drawing.Size(240, 41);
            this.btnMenuConfiguracion.TabIndex = 12;
            this.btnMenuConfiguracion.Text = "CONFIGURACION";
            this.btnMenuConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuConfiguracion.UseVisualStyleBackColor = false;
            this.btnMenuConfiguracion.Click += new System.EventHandler(this.btnMenuConfiguracion_Click);
            // 
            // pnlFormConteiner
            // 
            this.pnlFormConteiner.BackColor = System.Drawing.Color.White;
            this.pnlFormConteiner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormConteiner.Location = new System.Drawing.Point(256, 40);
            this.pnlFormConteiner.Margin = new System.Windows.Forms.Padding(16);
            this.pnlFormConteiner.Name = "pnlFormConteiner";
            this.pnlFormConteiner.Padding = new System.Windows.Forms.Padding(16);
            this.pnlFormConteiner.Size = new System.Drawing.Size(1024, 680);
            this.pnlFormConteiner.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlFormConteiner);
            this.Controls.Add(this.flpMenuLateral);
            this.Controls.Add(this.pnlBarraNavegacion);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Administracion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlBarraNavegacion.ResumeLayout(false);
            this.pnlBarraNavegacion.PerformLayout();
            this.pnlNavegacionControles.ResumeLayout(false);
            this.pnlDatosEmpresa.ResumeLayout(false);
            this.pnlDatosEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmpresaLogo)).EndInit();
            this.flpMenuLateral.ResumeLayout(false);
            this.flpMenuLateral.PerformLayout();
            this.flpMenuUsuario.ResumeLayout(false);
            this.flpMenuUsuario.PerformLayout();
            this.flpMenuVentas.ResumeLayout(false);
            this.flpMenuVentas.PerformLayout();
            this.flpMenuCompras.ResumeLayout(false);
            this.flpMenuCompras.PerformLayout();
            this.flpMenuStock.ResumeLayout(false);
            this.flpMenuStock.PerformLayout();
            this.flpMenuConfiguracion.ResumeLayout(false);
            this.flpMenuConfiguracion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraNavegacion;
        private System.Windows.Forms.Panel pnlNavegacionControles;
        private System.Windows.Forms.Button btnCerrarApp;
        private System.Windows.Forms.Panel pnlDatosEmpresa;
        private System.Windows.Forms.Label lblEmpresaNombre;
        private System.Windows.Forms.PictureBox picEmpresaLogo;
        private System.Windows.Forms.FlowLayoutPanel flpMenuLateral;
        private System.Windows.Forms.FlowLayoutPanel flpMenuUsuario;
        private System.Windows.Forms.FlowLayoutPanel flpMenuVentas;
        private System.Windows.Forms.FlowLayoutPanel flpMenuCompras;
        private System.Windows.Forms.FlowLayoutPanel flpMenuStock;
        private System.Windows.Forms.FlowLayoutPanel flpMenuConfiguracion;
        private System.Windows.Forms.Label lblMenuVentasTitulo;
        private System.Windows.Forms.Label lblMenuComprasTitulo;
        private System.Windows.Forms.Label lblMenuStockTitulo;
        private System.Windows.Forms.Button btnMenuUsuario;
        private System.Windows.Forms.Button btnMenuVentasClientes;
        private System.Windows.Forms.Button btnMenuConfiguracion;
        private System.Windows.Forms.Button btnMenuVentasFacturas;
        private System.Windows.Forms.Button btnMenuVentasCaja;
        private System.Windows.Forms.Button btnMenuVentasMovimientos;
        private System.Windows.Forms.Button btnComprasProveedores;
        private System.Windows.Forms.Button btnComprasFacturas;
        private System.Windows.Forms.Button btnComprasPago;
        private System.Windows.Forms.Button btnStockProductos;
        private System.Windows.Forms.Button btnStockMovimientos;
        private System.Windows.Forms.Button brnStockValorizacion;
        private System.Windows.Forms.Button btnStockControl;
        private System.Windows.Forms.Panel pnlFormConteiner;
    }
}

