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
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grbFormulario.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            viewModelCompania = new TgenCompaniaViewModel();
            viewModelCompania.NOMBRECOMPANIA = txtNombreCompania.Text;
            viewModelCompania.ESLOGANCLIENTE = txtEsloganCliente.Text;
            viewModelCompania.ESLOGANCORE = txtEsloganCore.Text;
            viewModelCompania.NOMBRECORTO = txtNombreCorto.Text;

            if (txtCcompania.Text != "")
            {
                viewModelCompania.CCOMPANIA = int.Parse(txtCcompania.Text);
                ActualizarCompania();
            }
            else
            {
                InsertarCompania();
            }
            ListarCompanias();
        }

        private void FrmCompania_Load(object sender, EventArgs e)
        {
            ListarCompanias();
        }

        private void dgvListaCompania_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
