using System;
using System.Windows.Forms;
using Sis_Administracion.DAL.Enums;
using Sis_Administracion.DAL.Identidad;
using Sis_Administracion.DAL.Servicios;

namespace Sis_Administracion.Formularios
{
    public partial class _06_Productos : Form
    {
        private Producto _ProductoSeleccionado;

        public _06_Productos()
        {
            InitializeComponent();
            _ProductoSeleccionado = new Producto();

            ActualizarGrilla();
            dgvListado.Focus();

        }

        private void ActualizarGrilla()
        {
            dgvListado.DataSource = ProductoServicios.Listar();

            if(dgvListado.RowCount > 0)
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

        private void ActualizarGrillaMovimientos()
        {
            dgvListadoMovimientos.DataSource = ProductoMovimientoServicios.Listar(_ProductoSeleccionado.Codigo);

            DarFormatoAGrillaMovimientos();
        }

        private void DarFormatoAGrillaMovimientos()
        {
            for (int i = 0; i < dgvListadoMovimientos.ColumnCount; i++)
                dgvListadoMovimientos.Columns[i].Visible = false;

            dgvListadoMovimientos.Columns["ComprobanteDescripcion"].Visible = true;
            dgvListadoMovimientos.Columns["ComprobanteDescripcion"].HeaderText = @"DESCRIPCIÓN";
            dgvListadoMovimientos.Columns["ComprobanteDescripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dgvListadoMovimientos.Columns["Fecha"].Visible = true;
            dgvListadoMovimientos.Columns["Fecha"].HeaderText = @"FECHA";
            dgvListadoMovimientos.Columns["Fecha"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            dgvListadoMovimientos.Columns["Cantidad"].Visible = true;
            dgvListadoMovimientos.Columns["Cantidad"].HeaderText = @"CANT.";
            dgvListadoMovimientos.Columns["Cantidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvListadoMovimientos.Columns["Precio"].Visible = true;
            dgvListadoMovimientos.Columns["Precio"].HeaderText = @"PRECIO";
            dgvListadoMovimientos.Columns["Precio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }


        // ********************************* //
        // *****  MANEJO DE CONTROLES  ***** //
        // ********************************* //
        private void dgvListado_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (DatosCargados())
            {
                _ProductoSeleccionado = (Producto)dgvListado.Rows[e.RowIndex].DataBoundItem;
                ActualizarGrillaMovimientos();

                txtCosto.Text = @"$ "+_ProductoSeleccionado.Costo.ToString("#.00");
                txtPrecio.Text = @"$ " + _ProductoSeleccionado.Precio.ToString("#.00");
                txtStock.Text = _ProductoSeleccionado.Stock.ToString();
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
            Form f = new _07_ABM_Productos(TipoAccionABM.Alta, _ProductoSeleccionado);
            f.ShowDialog();

            ActualizarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form f = new _07_ABM_Productos(TipoAccionABM.Modificacion, _ProductoSeleccionado);
            f.ShowDialog();

            ActualizarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Form f = new _07_ABM_Productos(TipoAccionABM.Baja, _ProductoSeleccionado);
            //f.ShowDialog();

            ActualizarGrilla();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvListado.DataSource = ProductoServicios.Listar(txtBuscar.Text);

            DarFormatoAGrilla();
        }

    }
}
