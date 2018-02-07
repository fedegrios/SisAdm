using System;
using System.Windows.Forms;
using Sis_Administracion.DAL.Enums;
using Sis_Administracion.DAL.Identidad;
using Sis_Administracion.DAL.Servicios;

namespace Sis_Administracion.Formularios
{
    public partial class _03_ABM_Cliente : Form
    {
        private TipoAccionABM _tipoAccion;
        private Cliente _cliente;


        public _03_ABM_Cliente(TipoAccionABM tipoAccion, Cliente cliente)
        {
            InitializeComponent();
            
            _tipoAccion = tipoAccion;
            _cliente = cliente;

            PrepararFormularioPorTipoAccion();

        }

        private void PrepararFormularioPorTipoAccion()
        {
            switch (_tipoAccion)
            {
                // ***  ALTA DE UN NUEVO COMPROBANTE  *** //
                case TipoAccionABM.Alta:

                    Text = @"Nuevo Cliente";
                    btnGuardar.Click += AgregarNuevoCliente;
                    PrepararCamposParaAlta();
                    txtCuit.Focus();

                    break;

                // ***  MODIFICACION DE UN COMPROBANTE  *** //
                case TipoAccionABM.Modificacion:

                    Text = @"Modificar Cliente";
                    btnGuardar.Click += ModificarCliente;
                    CargarDatosDelCliente();

                    pnlCuit.Enabled = false;
                    txtRazonSocial.Focus();

                    break;

                case TipoAccionABM.Baja:

                    Text = @"Eliminar Cliente";
                    btnGuardar.Visible = false;
                    CargarDatosDelCliente();
                    BloquearTodosLosCampos();

                    DialogResult rta = MessageBox.Show($@"Seguro que desea elimninar a {_cliente.RazonSocial}",
                        @"Eliminar Cliente", MessageBoxButtons.YesNo);

                    if (DialogResult.Yes == rta) EliminarCliente();
                    else Close();
            
                    break;
            }
        }

        private void BloquearTodosLosCampos()
        {
            pnlCuit.Enabled = false;
            pnlDireccion.Enabled = false;
            pnlMontoMaxCtaCte.Enabled = false;
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
            nudMontoMaxCtaCte.Value = 0;
        }

        private void CargarDatosDelCliente()
        {
            txtCuit.Text = _cliente.Cuit;
            txtRazonSocial.Text = _cliente.RazonSocial;
            txtTelefono.Text = _cliente.Telefono;
            txtDireccion.Text = _cliente.Direccion;
            nudMontoMaxCtaCte.Value = (decimal)_cliente.MontoMaxCtaCte;
        }

        private bool ComprobarCampos()
        {
            bool checkearTodosLosCampos = true;

            // ***  COMPROBAR CUIT
            if (!FormularioServicios.EsCuit(txtCuit.Text) && !FormularioServicios.EsDni(txtCuit.Text))
            {
                FormularioServicios.ResaltarPanelConError( pnlCuit );
                checkearTodosLosCampos = checkearTodosLosCampos & false;
            }
            else
            {
                FormularioServicios.QuitarResaltadoError( pnlCuit );
            }

            // ***  COMPROBAR RAZON SOCIAL
            if (!FormularioServicios.EsApyNom( txtRazonSocial.Text ))
            {
                FormularioServicios.ResaltarPanelConError( pnlRazonSocial );
                checkearTodosLosCampos = checkearTodosLosCampos & false;
            }
            else
            {
                FormularioServicios.QuitarResaltadoError( pnlRazonSocial );
            }

            // ***  COMPROBAR TELEFONO
            if (!FormularioServicios.EsTelefono( txtTelefono.Text ))
            {
                FormularioServicios.ResaltarPanelConError( pnlTelefono );
                checkearTodosLosCampos = checkearTodosLosCampos & false;
            }
            else
            {
                FormularioServicios.QuitarResaltadoError( pnlTelefono );
            }

            // ***  COMPROBAR DIRECCION
            if (!FormularioServicios.EsDireccion( txtDireccion.Text ))
            {
                FormularioServicios.ResaltarPanelConError( pnlDireccion );
                checkearTodosLosCampos = checkearTodosLosCampos & false;
            }
            else
            {
                FormularioServicios.QuitarResaltadoError( pnlDireccion );
            }

            // ***  COMPROBAR LIMITE CTA CTE
            var limiteCtaCteOk =
                decimal.TryParse(nudMontoMaxCtaCte.Text, out var monto)
                && monto >= 0
                && monto <= 10000;

            if ( !limiteCtaCteOk )
            {
                FormularioServicios.ResaltarPanelConError(pnlDireccion);
                checkearTodosLosCampos = checkearTodosLosCampos & false;
            }
            else
            {
                FormularioServicios.QuitarResaltadoError( pnlMontoMaxCtaCte );
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
        private void EliminarCliente()
        {
            if (!ClienteServicios.Eliminar(_cliente))
                MessageBox.Show(@"Error al intentar eliminar. Consulte con el administrador del sistema.", @"Error al eliminar");

            Close();
        }

        private void AgregarNuevoCliente(object sender, EventArgs e)
        {
            if (ComprobarCampos())
            {
                var c = ClienteServicios.Agregar(new Cliente
                {
                    Cuit = txtCuit.Text,
                    RazonSocial = txtRazonSocial.Text,
                    Direccion = txtDireccion.Text,
                    Telefono = txtTelefono.Text,
                    MontoMaxCtaCte = (double) nudMontoMaxCtaCte.Value
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

        private void ModificarCliente(object sender, EventArgs e)
        {
            if (ComprobarCampos())
            {
                var s = ClienteServicios.Modificar(new Cliente
                {
                    Cuit = txtCuit.Text,
                    RazonSocial = txtRazonSocial.Text,
                    Direccion = txtDireccion.Text,
                    Telefono = txtTelefono.Text,
                    MontoMaxCtaCte = (double)nudMontoMaxCtaCte.Value
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
