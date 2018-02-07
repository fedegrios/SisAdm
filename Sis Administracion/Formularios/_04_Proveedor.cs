using System;
using System.Windows.Forms;
using Sis_Administracion.DAL.Enums;
using Sis_Administracion.DAL.Identidad;
using Sis_Administracion.DAL.Servicios;

namespace Sis_Administracion.Formularios
{
    public partial class _04_Proveedor : Form
    {
        private Proveedor _ProveedorSeleccionado;

        public _04_Proveedor()
        {
            InitializeComponent();
            _ProveedorSeleccionado = new Proveedor();

            ActualizarGrilla();
            dgvListado.Focus();

        }

        private void ActualizarGrilla()
        {
            dgvListado.DataSource = ProveedorServicios.Listar();

            DarFormatoAGrilla();
        }

        private void DarFormatoAGrilla()
        {
            for (int i = 0; i < dgvListado.ColumnCount; i++)
                dgvListado.Columns[i].Visible = false;

            dgvListado.Columns["RazonSocial"].Visible = true;
            dgvListado.Columns["RazonSocial"].HeaderText = @"RAZÓN SOCIAL";
            dgvListado.Columns["RazonSocial"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dgvListado.Columns["Cuit"].Visible = true;
            dgvListado.Columns["Cuit"].HeaderText = @"CUIT / DNI";
            dgvListado.Columns["Cuit"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            dgvListado.Columns["Direccion"].Visible = true;
            dgvListado.Columns["Direccion"].HeaderText = @"DIRECCIÓN";
            dgvListado.Columns["Direccion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvListado.Columns["Telefono"].Visible = true;
            dgvListado.Columns["Telefono"].HeaderText = @"TELÉFONO";
            dgvListado.Columns["Telefono"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }


        // ********************************* //
        // *****  MANEJO DE CONTROLES  ***** //
        // ********************************* //
        private void dgvListado_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (DatosCargados())
                _ProveedorSeleccionado = (Proveedor)dgvListado.Rows[e.RowIndex].DataBoundItem;

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
            Form f = new _05_ABM_Proveedor(TipoAccionABM.Alta, _ProveedorSeleccionado);
            f.ShowDialog();

            ActualizarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form f = new _05_ABM_Proveedor(TipoAccionABM.Modificacion, _ProveedorSeleccionado);
            f.ShowDialog();

            ActualizarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Form f = new _05_ABM_Proveedor(TipoAccionABM.Baja, _ProveedorSeleccionado);
            //f.ShowDialog();

            ActualizarGrilla();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvListado.DataSource = ProveedorServicios.Listar(txtBuscar.Text);

            DarFormatoAGrilla();
        }
    }
}
