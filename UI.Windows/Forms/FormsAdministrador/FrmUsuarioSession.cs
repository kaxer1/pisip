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
    public partial class FrmUsuarioSession : FormBase
    {
        private TsegUsuarioSessionController controllerSessiones;
        private TsegUsuarioSessionViewModel viewModelSessiones;

        private decimal codigoCompaniaSeleccionado = 0;
        public FrmUsuarioSession(Timer timer) : base(timer)
        {
            base.formularioHijo = this;
            InitializeComponent();
            controllerSessiones = new TsegUsuarioSessionController();
        }

        private void ListarSessionesActivas()
        {
            ejecutaSentencia();
            dgvListaSesiones.DataSource = controllerSessiones.ListarUsuarioSessionesActivas();
            dgvListaSesiones.Columns[0].ReadOnly = true;
            dgvListaSesiones.Columns[1].ReadOnly = true;
            dgvListaSesiones.Columns[2].ReadOnly = true;
            dgvListaSesiones.Columns[3].ReadOnly = true;
            dgvListaSesiones.Columns[4].ReadOnly = true;
            dgvListaSesiones.Columns[5].ReadOnly = true;
            dgvListaSesiones.Columns[6].ReadOnly = true;
            dgvListaSesiones.Columns[7].ReadOnly = true;
            dgvListaSesiones.Columns[8].ReadOnly = true;
            dgvListaSesiones.Columns[9].ReadOnly = true;
            dgvListaSesiones.Columns[10].ReadOnly = true;
            dgvListaSesiones.Columns[11].ReadOnly = true;
        }

        private void Frm_UsuarioSession_Load(object sender, EventArgs e)
        {
            ListarSessionesActivas();
        }

        private void dgvListaSesiones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaSesiones.SelectedRows.Count > 0)
            {
                txtUsuarioSeleccionado.Text = dgvListaSesiones.CurrentRow.Cells[0].Value.ToString();
                codigoCompaniaSeleccionado = (decimal) dgvListaSesiones.CurrentRow.Cells[1].Value;
                grbDesactivarSesion.Enabled = true;
            }
        }

        private void btnInactivarSession_Click(object sender, EventArgs e)
        {
            ejecutaSentencia();
            var pkUsuarioSession = new Dictionary<string, object>
                {
                    { "CUSUARIO", txtUsuarioSeleccionado.Text },
                    { "CCOMPANIA", codigoCompaniaSeleccionado }
                };

            viewModelSessiones = controllerSessiones.ObtenerRegistroPorPk(pkUsuarioSession);

            if (viewModelSessiones != null)
            {
                controllerSessiones.InsertarHistorial(viewModelSessiones);
                viewModelSessiones.CESTADO = "S";
                viewModelSessiones.FSALIDA = DateTime.Now;
                viewModelSessiones.ACTIVO = "0";
                controllerSessiones.ActualizarUsuarioSession(viewModelSessiones);
                ListarSessionesActivas();
                grbDesactivarSesion.Enabled = false;
            }
            else
            {
                MessageBox.Show("LA SESSIÓN NO FUE ENCONTRADA");
            }
        }
    }
}
