using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Windows.AplicationController;
using UI.Windows.Forms;
using UI.Windows.ViewModel;

namespace UI.Windows
{
    public partial class FrmCompania : FormBase
    {
        private TgenCompaniaController controllerCompania;
        private TgenCompaniaViewModel viewModelCompania;
        public FrmCompania() : base()
        {
            base.formularioHijo = this;
            InitializeComponent();
            controllerCompania = new TgenCompaniaController();
        }

        public void InsertarCompania()
        {
            if (!ejecutaSentencia()) // Si no pasa la validacion que le permita ejecutar la sentencia
                return; // ASI NO PROCESDE A EJECUTAR

            if (controllerCompania.InsertarCompania(viewModelCompania))
            {
                MessageBox.Show("Compania insertado correctamente");
            }
            else
            {
                MessageBox.Show("Error al insertar Compania");
            }
        }

        public void ActualizarCompania()
        {
            if (!ejecutaSentencia()) // Si no pasa la validacion que le permita ejecutar la sentencia
                return; // ASI NO PROCESDE A EJECUTAR

            if (controllerCompania.ActualizarCompania(viewModelCompania))
            {
                MessageBox.Show("Compania actualizado correctamente");
            }
            else
            {
                MessageBox.Show("Error al actualizar Compania");
            }
        }

        private void ListarCompanias()
        {
            dgvListaCompania.DataSource = controllerCompania.ListarCompania();
            dgvListaCompania.Columns[0].ReadOnly = true;
            dgvListaCompania.Columns[1].Visible = false;
            dgvListaCompania.Columns[2].ReadOnly = true;
            dgvListaCompania.Columns[3].ReadOnly = true;
            dgvListaCompania.Columns[4].ReadOnly = true;
            dgvListaCompania.Columns[5].ReadOnly = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esnuevo = true;
            grbFormulario.Enabled = true;
            txtCcompania.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (esnuevo)
            {
                viewModelCompania = new TgenCompaniaViewModel();
                viewModelCompania.NOMBRECOMPANIA = txtNombreCompania.Text;
                viewModelCompania.ESLOGANCLIENTE = txtEsloganCliente.Text;
                viewModelCompania.ESLOGANCORE = txtEsloganCore.Text;
                viewModelCompania.NOMBRECORTO = txtNombreCorto.Text;
                InsertarCompania();
            }
            else
            {
                var pkUsuario = new Dictionary<string, object>
                {
                    { "CCOMPANIA", Convert.ToDecimal(txtCcompania.Text) }
                };

                viewModelCompania = controllerCompania.ObtenerRegistroPorPk(pkUsuario);
                viewModelCompania.NOMBRECOMPANIA = txtNombreCompania.Text;
                viewModelCompania.ESLOGANCLIENTE = txtEsloganCliente.Text;
                viewModelCompania.ESLOGANCORE = txtEsloganCore.Text;
                viewModelCompania.NOMBRECORTO = txtNombreCorto.Text;
                ActualizarCompania();
            }
            ListarCompanias();
            limpiarFormulario();
        }

        private void FrmCompania_Load(object sender, EventArgs e)
        {
            ListarCompanias();
        }

        private void limpiarFormulario()
        {
            txtCcompania.Text = "";
            txtNombreCompania.Text = "";
            txtEsloganCliente.Text = "";
            txtEsloganCore.Text = "";
            txtNombreCorto.Text = "";
            txtCcompania.Enabled = false;
            grbFormulario.Enabled = false;
        }

        private void dgvListaCompania_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaCompania.SelectedRows.Count > 0)
            {
                grbFormulario.Enabled = true;
                txtCcompania.Enabled = false;
                esnuevo = false;

                txtCcompania.Text = dgvListaCompania.CurrentRow.Cells[0].Value.ToString();
                txtNombreCompania.Text = dgvListaCompania.CurrentRow.Cells[2].Value.ToString();
                txtEsloganCliente.Text = dgvListaCompania.CurrentRow.Cells[3].Value.ToString();
                txtEsloganCore.Text = dgvListaCompania.CurrentRow.Cells[4].Value.ToString();
                txtNombreCorto.Text = dgvListaCompania.CurrentRow.Cells[5].Value.ToString();

            }
        }
    }
}
