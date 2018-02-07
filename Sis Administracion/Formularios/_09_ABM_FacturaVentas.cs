using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Sis_Administracion.DAL.Enums;
using Sis_Administracion.DAL.Identidad;
using Sis_Administracion.DAL.Servicios;

namespace Sis_Administracion.Formularios
{
    public partial class _09_ABM_FacturaVentas : Form
    {
        // DECLARACION DE VARIABLES
        private TipoAccionABM _tipoAccion;
        private Comprobante _Comprobante;
        private List<ProductoMovimiento> _listadoProductos;
        private ProductoMovimiento _productoSeleccionado;

        public _09_ABM_FacturaVentas(TipoAccionABM tipoAccion, Comprobante Comprobante)
        {
            InitializeComponent();

            // INICIALIZACION DE VARIABLES
            _tipoAccion = tipoAccion;
            _Comprobante = Comprobante;
            _listadoProductos = new List<ProductoMovimiento>();
            _productoSeleccionado = new ProductoMovimiento();

            PrepararFormularioPorTipoAccion();
        }

        // ********************************* //
        // *****  PREPARAR FORMULARIO  ***** //
        // ********************************* //
        private void PrepararFormularioPorTipoAccion()
        {
            switch (_tipoAccion)
            {
                // ***  ALTA DE UN NUEVO COMPROBANTE  *** //
                case TipoAccionABM.Alta:

                    Text = @"Nuevo Comprobante";
                    btnGuardar.Click += AgregarNuevoComprobante;
                    PrepararCamposParaAlta();
                    cboSujeto.Focus();

                    break;

                // ***  MODIFICACION DE UN COMPROBANTE  *** //
                case TipoAccionABM.Modificacion:

                    Text = @"Modificar Comprobante";
                    btnGuardar.Click += ModificarComprobante;
                    CargarDatosDelComprobante();
                    PrepararCamposParaModificacion();

                    cboSujeto.Focus();

                    break;

                case TipoAccionABM.Baja:

                    Text = @"Eliminar Comprobante";
                    btnGuardar.Visible = false;
                    CargarDatosDelComprobante();
                    BloquearTodosLosCampos();

                    DialogResult rta = MessageBox.Show(@"¿Seguro que desea elimninar el item?",
                        @"Eliminar Comprobante", MessageBoxButtons.YesNo);

                    if (DialogResult.Yes == rta) EliminarComprobante();
                    else Close();

                    break;
            }
        }

        private void BloquearTodosLosCampos()
        {
            pnlFecha.Enabled = false;
            pnlCantidad.Enabled = false;
            pnlCodigoDescripcion.Enabled = false;
            pnlNumeroComprobante.Enabled = false;
            pnlSujeto.Enabled = false;
            pnlTipoComprobante.Enabled = false;
            pnlFormaPago.Enabled = false;
            pnlTotal.Enabled = false;

            dgvListado.Enabled = false;

            btnAgregar.Enabled = false;
            btnAgregarProducto.Enabled = false;
            btnEliminarItem.Enabled = false;
            btnNuevoCliente.Enabled = false;
        }

        private void PrepararCamposParaAlta()
        {
            dtpFecha.Value = DateTime.Now;

            cboTIpoComprobante.DataSource = Enum.GetNames(typeof(TipoComprobante));
            cboTIpoComprobante.Focus();
            cboTIpoComprobante.Text = "";

            pnlNumeroComprobante.Enabled = false;
            txtNumeroComprobante.Text = "";

            cboSujeto.DataSource = ClienteServicios.Listar();
            cboSujeto.DisplayMember = "CuityNombre";
            cboSujeto.Text = "";

            nudCantidad.Value = 0;

            cboCodigoDescripcion.DataSource = ProductoServicios.Listar();
            cboCodigoDescripcion.DisplayMember = "Descripcion";
            cboCodigoDescripcion.Text = "";

            dgvListado.DataSource = null;

            cboTIpoComprobante.DataSource = Enum.GetNames(typeof(FormaPago));

            lblTotal.Text = @"$ 0,00";

        }

        private void PrepararCamposParaModificacion()
        {
            pnlFecha.Enabled = false;
            pnlNumeroComprobante.Enabled = false;
            pnlSujeto.Enabled = false;
            pnlTipoComprobante.Enabled = false;
            pnlFormaPago.Enabled = false;

            cboCodigoDescripcion.Focus();
        }

        private void CargarDatosDelComprobante()
        {
            dtpFecha.Value = _Comprobante.Fecha;
            cboTIpoComprobante.Text = _Comprobante.Tipo.ToString();
            txtNumeroComprobante.Text = _Comprobante.Numero;
            cboSujeto.Text = ClienteServicios.Buscar(_Comprobante.IdSujeto).RazonSocial;

            nudCantidad.Value = 0;

            cboCodigoDescripcion.DataSource = ProductoServicios.Listar();
            cboCodigoDescripcion.DisplayMember = "Descripcion";
            cboCodigoDescripcion.Text = "";

            // Obtengo todos los movimientos del comprobante
            _listadoProductos = ProductoMovimientoServicios.ListarPorComprobante(_Comprobante.Id);

            GrillaCargarDatos();
        }

        private void GrillaCargarDatos()
        {
            dgvListado.DataSource = _listadoProductos; 

            GrillaFormatoCampos();
        }

        private void GrillaFormatoCampos()
        {
            for (int i = 0; i < dgvListado.ColumnCount; i++)
                dgvListado.Columns[i].Visible = false;

            dgvListado.Columns["DescripcionProducto"].Visible = true;
            dgvListado.Columns["DescripcionProducto"].HeaderText = @"DESCRIPCIÓN";
            dgvListado.Columns["DescripcionProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListado.Columns["DescripcionProducto"].DisplayIndex = 1;

            dgvListado.Columns["Cantidad"].Visible = true;
            dgvListado.Columns["Cantidad"].HeaderText = @"CANTIDAD";
            dgvListado.Columns["Cantidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvListado.Columns["Cantidad"].DisplayIndex = 0;

            dgvListado.Columns["Precio"].Visible = true;
            dgvListado.Columns["Precio"].HeaderText = @"UNITARIO";
            dgvListado.Columns["Precio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvListado.Columns["Precio"].DisplayIndex = 2;

            dgvListado.Columns["Subtotal"].Visible = true;
            dgvListado.Columns["Subtotal"].HeaderText = @"SUBTOTAL";
            dgvListado.Columns["Subtotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvListado.Columns["Subtotal"].DisplayIndex = 3;
        }

        private bool DatosCargados()
        {
            return dgvListado.RowCount > 0;
        }


        // ********************************* //
        // *****   ACCIONES DE DATOS   ***** //
        // ********************************* //
        private void AgregarProductoAlaGrilla(ProductoMovimiento p)
        {
            _listadoProductos.Add(p);
            GrillaCargarDatos();

            ActualizarTotal();
        }

        private void ActualizarTotal()
        {
            double total = 0;

            foreach (ProductoMovimiento p in _listadoProductos)
                total += p.Precio;

            lblTotal.Text = @"$ " + total.ToString("00");
        }

        private bool ComprobarCampos()
        {
            bool checkearTodosLosCampos = true;


            return checkearTodosLosCampos;
        }

        private void MostrarErrorEnIngresoDeDatos()
        {
            MessageBox.Show(@"Uno o varios de los datos ingresados son incorrectos.", @"Error");
        }
        

        // ********************************* //
        // *****  ACCIONES DE ABM      ***** //
        // ********************************* //
        private void EliminarComprobante()
        {
            if (!ComprobanteServicios.Eliminar(_Comprobante))
                MessageBox.Show(@"Error al intentar eliminar. Consulte con el administrador del sistema.", @"Error al eliminar");

            Close();
        }

        private void AgregarNuevoComprobante(object sender, EventArgs e)
        {
            if (ComprobarCampos())
            {
                // AGREGAR UN NUEVO COMPROBANTE
                var c = ComprobanteServicios.Agregar(new Comprobante
                {
                    Fecha = _Comprobante.Fecha,
                    Tipo = (TipoComprobante)cboTIpoComprobante.SelectedItem,
                    Numero = txtNumeroComprobante.Text,
                    IdSujeto = ((Cliente)cboSujeto.SelectedItem).Codigo
                });

                // SI SE PUDO AGREGAR EL COMPROBANTE Y AGREGAR EL LISTADO DE PRODUCTOS
                if (c != null && GuardarListadoDeProductos(c) )
                {
                    MessageBox.Show(@"Nuevo elemento agregado correctamente.");
                    Close();
                }
                else
                {
                    MessageBox.Show(@"Error al grabar los datos. Intentalo nuevamente.");
                    cboSujeto.Focus();
                }
            }
            else MostrarErrorEnIngresoDeDatos();
        }

        private bool GuardarListadoDeProductos(Comprobante c)
        {
            bool movimientoProductoOk = true;

            // AGREGAR LOS PRODUCTOS A LA LISTA DE MOVIMIENTOS
            foreach (ProductoMovimiento p in _listadoProductos)
            {
                var pm = ProductoMovimientoServicios.Agregar(new ProductoMovimiento
                {
                    Fecha = DateTime.Now,
                    Ops = TipoOps.Compra,
                    CodProducto = ((Producto) cboCodigoDescripcion.SelectedItem ).Codigo,
                    IdComprobante = c.Id,
                    Cantidad = (int)nudCantidad.Value,
                    Precio = p.Precio
                });

                movimientoProductoOk = movimientoProductoOk && pm != null;
            }

            return movimientoProductoOk;
        }

        private void ModificarComprobante(object sender, EventArgs e)
        {
            if (ComprobarCampos())
            {
                var s = ComprobanteServicios.Modificar(new Comprobante
                {
                    Fecha = _Comprobante.Fecha,
                    Tipo = (TipoComprobante)cboTIpoComprobante.SelectedItem,
                    Numero = txtNumeroComprobante.Text,
                    IdSujeto = ((Cliente)cboSujeto.SelectedItem).Codigo
                });

                if (s)
                {
                    MessageBox.Show(@"Nuevo elemento modificado correctamente.");
                    Close();
                }
                else
                {
                    MessageBox.Show(@"Error al grabar los datos. Intentalo nuevamente.");
                    cboSujeto.Focus();
                }
            }
            else MostrarErrorEnIngresoDeDatos();
        }


        // ********************************* //
        // *****  ACCIONES DE CONTROLES **** //
        // ********************************* //
        private void dgvListado_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (DatosCargados())
                _productoSeleccionado = (ProductoMovimiento) dgvListado.Rows[e.RowIndex].DataBoundItem;

        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            Form f = new _03_ABM_Cliente(TipoAccionABM.Alta, null);
            f.ShowDialog();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Form f = new _07_ABM_Productos(TipoAccionABM.Alta, null);
            f.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto p = (Producto) cboCodigoDescripcion.SelectedItem;

            if (p != null)
                AgregarProductoAlaGrilla(cboCodigoDescripcion.SelectedItem as ProductoMovimiento);
            else
                MessageBox.Show(@"Ningún elemento seleccionado.", @"Error");


            cboCodigoDescripcion.Text = "";
            cboCodigoDescripcion.Focus();
        }

        private void cboCodigoDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Keys tecla = (Keys) sender;

            if (tecla == Keys.Enter)
                btnAgregar_Click(sender, e);
        }

        private void btnEliminarItem_Click(object sender, EventArgs e)
        {
            _listadoProductos.Remove(_productoSeleccionado);

            GrillaCargarDatos();

            cboCodigoDescripcion.Text = "";
            cboCodigoDescripcion.Focus();
        }
    }
}