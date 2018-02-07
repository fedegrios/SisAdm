using System;
using System.Windows.Forms;
using Sis_Administracion.DAL.Enums;
using Sis_Administracion.DAL.Identidad;
using Sis_Administracion.DAL.Servicios;

namespace Sis_Administracion.Formularios
{
    public partial class _08_FactuaraVentas : Form
    {
        private Comprobante _ComprobanteSeleccionado;

        public _08_FactuaraVentas()
        {
            InitializeComponent();
            _ComprobanteSeleccionado = new Comprobante();

            ActualizarGrilla();
            dgvListado.Focus();
        }

        private void ActualizarGrilla()
        {
            dgvListado.DataSource = ComprobanteServicios.Listar(TipoOps.Compra,"");

            if (dgvListado.RowCount > 0)
                DarFormatoAGrilla();
        }

        private void DarFormatoAGrilla()
        {
             
            for (int i = 0; i < dgvListado.ColumnCount; i++)
                dgvListado.Columns[i].Visible = false;

            dgvListado.Columns["Descripcion"].Visible = true;
            dgvListado.Columns["Descripcion"].HeaderText = @"DESCRIPCIÓN";
            dgvListado.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dgvListado.Columns["Codigo"].Visible = true;
            dgvListado.Columns["Codigo"].HeaderText = @"CÓDIGO";
            dgvListado.Columns["Codigo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            dgvListado.Columns["CodBarra"].Visible = true;
            dgvListado.Columns["CodBarra"].HeaderText = @"COD. DE BARRA";
            dgvListado.Columns["CodBarra"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvListado.Columns["Stock"].Visible = true;
            dgvListado.Columns["Stock"].HeaderText = @"STOCK";
            dgvListado.Columns["Stock"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvListado.Columns["Marca"].Visible = true;
            dgvListado.Columns["Marca"].HeaderText = @"MARCA";
            dgvListado.Columns["Marca"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }

        private void ActualizarGrillaPagos()
        {
            /*
            dgvListadoPagos.DataSource = PagoServicios.Listar(_ComprobanteSeleccionado.Codigo);

            DarFormatoAGrillaPagos();
            */
        }

        private void DarFormatoAGrillaPagos()
        {
            for (int i = 0; i < dgvListadoPagos.ColumnCount; i++)
                dgvListadoPagos.Columns[i].Visible = false;

            dgvListadoPagos.Columns["ComprobanteDescripcion"].Visible = true;
            dgvListadoPagos.Columns["ComprobanteDescripcion"].HeaderText = @"DESCRIPCIÓN";
            dgvListadoPagos.Columns["ComprobanteDescripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dgvListadoPagos.Columns["Fecha"].Visible = true;
            dgvListadoPagos.Columns["Fecha"].HeaderText = @"FECHA";
            dgvListadoPagos.Columns["Fecha"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            dgvListadoPagos.Columns["Cantidad"].Visible = true;
            dgvListadoPagos.Columns["Cantidad"].HeaderText = @"CANT.";
            dgvListadoPagos.Columns["Cantidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvListadoPagos.Columns["Precio"].Visible = true;
            dgvListadoPagos.Columns["Precio"].HeaderText = @"PRECIO";
            dgvListadoPagos.Columns["Precio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }


        // ********************************* //
        // *****  MANEJO DE CONTROLES  ***** //
        // ********************************* //
        private void dgvListado_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (DatosCargados())
            {
                _ComprobanteSeleccionado = (Comprobante)dgvListado.Rows[e.RowIndex].DataBoundItem;
                ActualizarGrillaPagos();
            }

        }

        private bool DatosCargados()
        {
            return dgvListado.RowCount > 0;
        }


        // ********************************* //
        // ***** EVENTOS DE FORMULARIO ***** //
        // ********************************* //
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form f = new _09_ABM_FacturaVentas(TipoAccionABM.Alta, _ComprobanteSeleccionado);
            f.ShowDialog();

            ActualizarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form f = new _09_ABM_FacturaVentas(TipoAccionABM.Modificacion, _ComprobanteSeleccionado);
            f.ShowDialog();

            ActualizarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Form f = new _09_ABM_FacturaVentas(TipoAccionABM.Baja, _ComprobanteSeleccionado);
            //f.ShowDialog();

            ActualizarGrilla();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvListado.DataSource = ComprobanteServicios.Listar(TipoOps.Compra,txtBuscar.Text);

            DarFormatoAGrilla();
        }
    }
}
