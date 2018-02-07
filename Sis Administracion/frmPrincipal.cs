using System;
using System.Windows.Forms;
using Sis_Administracion.DAL.Servicios;
using Sis_Administracion.Formularios;

namespace Sis_Administracion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            InicializarServicios();

        }

        private void InicializarServicios()
        {
            //ComprobanteServicios.Inicializador();
            //UsuarioServicios.Inicializador();
            ProductoServicios.Inicializador();
            ProductoMovimientoServicios.Inicializador();
            ClienteServicios.Inicializador();
            ProveedorServicios.Inicializador();
        }

        private void MostrarFormularioEnPanel(Form form)
        {
            form.TopLevel = false;

            pnlFormConteiner.Controls.Clear();
            pnlFormConteiner.Controls.Add(form);

            form.Width = pnlFormConteiner.Width;
            form.Height = pnlFormConteiner.Height;
            pnlFormConteiner.Controls[0].Show();
        }


        // *************************************** //
        // ***** EVENTOS DE BOTONES DEL MENU ***** //
        // *************************************** //
        private void btnMenuConfiguracion_Click(object sender, EventArgs e)
        {
            
        }


        private void btnMenuVentasClientes_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new _02_Cliente());
        }

        private void btnComprasProveedores_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new _04_Proveedor());
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnComprasFacturas_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new _06_ABM_Factura());
        }

        private void btnStockProductos_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new _06_Productos());
        }
    }
}
