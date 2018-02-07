using System;
using System.Linq;
using System.Windows.Forms;
using Sis_Administracion.DAL.Enums;
using Sis_Administracion.DAL.Identidad;
using Sis_Administracion.DAL.Servicios;

namespace Sis_Administracion.Formularios
{
    public partial class _07_ABM_Productos : Form
    {
        private TipoAccionABM _tipoAccion;
        private Producto _Producto;
        
        public _07_ABM_Productos(TipoAccionABM tipoAccion, Producto Producto)
        {
            InitializeComponent();

            _tipoAccion = tipoAccion;
            _Producto = Producto;

            PrepararFormularioPorTipoAccion();

        }

        private void PrepararFormularioPorTipoAccion()
        {
            switch (_tipoAccion)
            {
                // ***  ALTA DE UN NUEVO COMPROBANTE  *** //
                case TipoAccionABM.Alta:

                    Text = @"Nuevo Producto";
                    btnGuardar.Click += AgregarNuevoProducto;
                    PrepararCamposParaAlta();
                    txtCodigo.Focus();

                    break;

                // ***  MODIFICACION DE UN COMPROBANTE  *** //
                case TipoAccionABM.Modificacion:

                    Text = @"Modificar Producto";
                    btnGuardar.Click += ModificarProducto;
                    CargarDatosDelProducto();

                    txtCodigo.Focus();

                    break;

                case TipoAccionABM.Baja:

                    Text = @"Eliminar Producto";
                    btnGuardar.Visible = false;
                    CargarDatosDelProducto();
                    BloquearTodosLosCampos();

                    DialogResult rta = MessageBox.Show(@"¿Seguro que desea elimninar el item?",
                        @"Eliminar Producto", MessageBoxButtons.YesNo);

                    if (DialogResult.Yes == rta) EliminarProducto();
                    else Close();

                    break;
            }
        }

        private void BloquearTodosLosCampos()
        {
            pnlCodigo.Enabled = false;
            pnlCodigoDeBarra.Enabled = false;
            pnlDescripcion.Enabled = false;
            pnlMarca.Enabled = false;
        }

        private void PrepararCamposParaAlta()
        {
            txtCodigo.Text = "";
            txtCodigo.Focus();
            txtCodigoDeBarra.Text = "";
            txtDescripcion.Text = "";
            txtMarca.Text = "";
        }

        private void CargarDatosDelProducto()
        {
            txtCodigo.Text = _Producto.Codigo;
            txtCodigoDeBarra.Text = _Producto.CodBarra;
            txtDescripcion.Text = _Producto.Descripcion;
            txtMarca.Text = _Producto.Marca;
        }

        private bool ComprobarCampos()
        {
            bool checkearTodosLosCampos = true;

            // ***  COMPROBAR CODIGO DE BARRA
            if (!FormularioServicios.EsCodigoDeBarra(txtCodigoDeBarra.Text))
            {
                FormularioServicios.ResaltarPanelConError(pnlCodigoDeBarra);
                checkearTodosLosCampos = checkearTodosLosCampos & false;
            }
            else
            {
                FormularioServicios.QuitarResaltadoError(pnlCodigoDeBarra);
            }

            // ***  COMPROBAR CODIGO
            if (!FormularioServicios.EsCodigoDeProducto(txtCodigo.Text))
            {
                FormularioServicios.ResaltarPanelConError(pnlCodigo);
                checkearTodosLosCampos = checkearTodosLosCampos & false;
            }
            else
            {
                FormularioServicios.QuitarResaltadoError(pnlCodigo);
            }

            // ***  COMPROBAR MARCA
            if ( !txtMarca.Text.All(c => char.IsLetterOrDigit(c) || char.IsSeparator(c)) )
            {
                FormularioServicios.ResaltarPanelConError(pnlMarca);
                checkearTodosLosCampos = checkearTodosLosCampos & false;
            }
            else
            {
                FormularioServicios.QuitarResaltadoError(pnlMarca);
            }

            // ***  COMPROBAR DESCRIPCION
            if ( !txtDescripcion.Text.All(c => char.IsLetterOrDigit(c) || char.IsSeparator(c)) )
            {
                FormularioServicios.ResaltarPanelConError(pnlDescripcion);
                checkearTodosLosCampos = checkearTodosLosCampos & false;
            }
            else
            {
                FormularioServicios.QuitarResaltadoError(pnlDescripcion);
            }

            return checkearTodosLosCampos;
        }

        private void MostrarErrorEnIngresoDeDatos()
        {
            MessageBox.Show(@"Uno o varios de los datos ingresados son incorrectos.", @"Error");
        }


        // ********************************* //
        // *****  ACCIONES DE ABM      ***** //
        // ********************************* //
        private void EliminarProducto()
        {
            if (!ProductoServicios.Eliminar(_Producto))
                MessageBox.Show(@"Error al intentar eliminar. Consulte con el administrador del sistema.", @"Error al eliminar");

            Close();
        }

        private void AgregarNuevoProducto(object sender, EventArgs e)
        {
            if (ComprobarCampos())
            {
                var c = ProductoServicios.Agregar(new Producto
                {
                    Codigo = txtCodigo.Text,
                    CodBarra = txtCodigoDeBarra.Text,
                    Descripcion = txtDescripcion.Text,
                    Marca = txtMarca.Text
                });

                if (c != null)
                {
                    MessageBox.Show(@"Nuevo elemento agregado correctamente.");
                    Close();
                }
                else
                {
                    MessageBox.Show(@"Error al grabar los datos. Intentalo nuevamente.");
                    txtCodigo.Focus();
                }
            }
            else MostrarErrorEnIngresoDeDatos();
        }

        private void ModificarProducto(object sender, EventArgs e)
        {
            if (ComprobarCampos())
            {
                var s = ProductoServicios.Modificar(new Producto
                {
                    Codigo = txtCodigo.Text,
                    CodBarra = txtCodigoDeBarra.Text,
                    Descripcion = txtDescripcion.Text,
                    Marca = txtMarca.Text
                });

                if (s)
                {
                    MessageBox.Show(@"Nuevo elemento modificado correctamente.");
                    Close();
                }
                else
                {
                    MessageBox.Show(@"Error al grabar los datos. Intentalo nuevamente.");
                    txtCodigo.Focus();
                }
            }
            else MostrarErrorEnIngresoDeDatos();
        }

    }
}
