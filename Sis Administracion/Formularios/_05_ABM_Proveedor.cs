using System;
using System.Windows.Forms;
using Sis_Administracion.DAL.Enums;
using Sis_Administracion.DAL.Identidad;
using Sis_Administracion.DAL.Servicios;

namespace Sis_Administracion.Formularios
{
    public partial class _05_ABM_Proveedor : Form
    {
        private TipoAccionABM _tipoAccion;
        private Proveedor _Proveedor;


        public _05_ABM_Proveedor(TipoAccionABM tipoAccion, Proveedor Proveedor)
        {
            InitializeComponent();

            _tipoAccion = tipoAccion;
            _Proveedor = Proveedor;

            PrepararFormularioPorTipoAccion();

        }

        private void PrepararFormularioPorTipoAccion()
        {
            switch (_tipoAccion)
            {
                // ***  ALTA DE UN NUEVO COMPROBANTE  *** //
                case TipoAccionABM.Alta:

                    Text = @"Nuevo Proveedor";
                    btnGuardar.Click += AgregarNuevoProveedor;
                    PrepararCamposParaAlta();
                    txtCuit.Focus();

                    break;

                // ***  MODIFICACION DE UN COMPROBANTE  *** //
                case TipoAccionABM.Modificacion:

                    Text = @"Modificar Proveedor";
                    btnGuardar.Click += ModificarProveedor;
                    CargarDatosDelProveedor();

                    pnlCuit.Enabled = false;
                    txtRazonSocial.Focus();

                    break;

                case TipoAccionABM.Baja:

                    Text = @"Eliminar Proveedor";
                    btnGuardar.Visible = false;
                    CargarDatosDelProveedor();
                    BloquearTodosLosCampos();

                    DialogResult rta = MessageBox.Show($@"Seguro que desea elimninar a {_Proveedor.RazonSocial}",
                        @"Eliminar Proveedor", MessageBoxButtons.YesNo);

                    if (DialogResult.Yes == rta) EliminarProveedor();
                    else Close();

                    break;
            }
        }

        private void BloquearTodosLosCampos()
        {
            pnlCuit.Enabled = false;
            pnlDireccion.Enabled = false;
            pnlRazonSocial.Enabled = false;
            pnlTelefono.Enabled = false;
        }

        private void PrepararCamposParaAlta()
        {
            txtCuit.Text = "";
            txtCuit.Focus();
            txtDireccion.Text = "";
            txtRazonSocial.Text = "";
            txtTelefono.Text = "";
        }

        private void CargarDatosDelProveedor()
        {
            txtCuit.Text = _Proveedor.Cuit;
            txtRazonSocial.Text = _Proveedor.RazonSocial;
            txtTelefono.Text = _Proveedor.Telefono;
            txtDireccion.Text = _Proveedor.Direccion;
        }

        private bool ComprobarCampos()
        {
            bool checkearTodosLosCampos = true;

            // ***  COMPROBAR CUIT
            if (!FormularioServicios.EsCuit(txtCuit.Text) && !FormularioServicios.EsDni(txtCuit.Text))
            {
                FormularioServicios.ResaltarPanelConError(pnlCuit);
                checkearTodosLosCampos = checkearTodosLosCampos & false;
            }
            else
            {
                FormularioServicios.QuitarResaltadoError(pnlCuit);
            }

            // ***  COMPROBAR RAZON SOCIAL
            if (!FormularioServicios.EsApyNom(txtRazonSocial.Text))
            {
                FormularioServicios.ResaltarPanelConError(pnlRazonSocial);
                checkearTodosLosCampos = checkearTodosLosCampos & false;
            }
            else
            {
                FormularioServicios.QuitarResaltadoError(pnlRazonSocial);
            }

            // ***  COMPROBAR TELEFONO
            if (!FormularioServicios.EsTelefono(txtTelefono.Text))
            {
                FormularioServicios.ResaltarPanelConError(pnlTelefono);
                checkearTodosLosCampos = checkearTodosLosCampos & false;
            }
            else
            {
                FormularioServicios.QuitarResaltadoError(pnlTelefono);
            }

            // ***  COMPROBAR DIRECCION
            if (!FormularioServicios.EsDireccion(txtDireccion.Text))
            {
                FormularioServicios.ResaltarPanelConError(pnlDireccion);
                checkearTodosLosCampos = checkearTodosLosCampos & false;
            }
            else
            {
                FormularioServicios.QuitarResaltadoError(pnlDireccion);
            }

            return checkearTodosLosCampos;
        }

        private void MostrarErrorEnIngresoDeDatos()
        {
            MessageBox.Show($@"Uno o varios de los datos ingresados son incorrectos.", @"Error");
        }


        // ********************************* //
        // *****  ACCIONES DE ABM      ***** //
        // ********************************* //
        private void EliminarProveedor()
        {
            if (!ProveedorServicios.Eliminar(_Proveedor))
                MessageBox.Show(@"Error al intentar eliminar. Consulte con el administrador del sistema.", @"Error al eliminar");

            Close();
        }

        private void AgregarNuevoProveedor(object sender, EventArgs e)
        {
            if (ComprobarCampos())
            {
                var c = ProveedorServicios.Agregar(new Proveedor
                {
                    Cuit = txtCuit.Text,
                    RazonSocial = txtRazonSocial.Text,
                    Direccion = txtDireccion.Text,
                    Telefono = txtTelefono.Text,
                });

                if (c != null)
                {
                    MessageBox.Show(@"Nuevo elemento agregado correctamente.");
                    Close();
                }
                else
                {
                    MessageBox.Show(@"Error al grabar los datos. Intentalo nuevamente.");
                    txtCuit.Focus();
                }
            }
            else MostrarErrorEnIngresoDeDatos();
        }

        private void ModificarProveedor(object sender, EventArgs e)
        {
            if (ComprobarCampos())
            {
                var s = ProveedorServicios.Modificar(new Proveedor
                {
                    Cuit = txtCuit.Text,
                    RazonSocial = txtRazonSocial.Text,
                    Direccion = txtDireccion.Text,
                    Telefono = txtTelefono.Text,
                });

                if (s)
                {
                    MessageBox.Show(@"Nuevo elemento modificado correctamente.");
                    Close();
                }
                else
                {
                    MessageBox.Show(@"Error al grabar los datos. Intentalo nuevamente.");
                    txtCuit.Focus();
                }
            }
            else MostrarErrorEnIngresoDeDatos();
        }

    }
}
