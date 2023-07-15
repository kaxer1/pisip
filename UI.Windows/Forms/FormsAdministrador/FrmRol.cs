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
using UI.Windows.ViewModel;

namespace UI.Windows.Forms.FormsAdministrador
{
    public partial class FrmRol : FormBase
    {
        private TsegRolController _tsegRolController;
        private TsegRolViewModel _tsegRolViewModel;
        private TsegUsuarioController _tsegUsuarioController;
        private TgenCompaniaController _tgenCompaniaController;

        private decimal ccompaniaSeleccionado = 0;
        private string ccanalSeleccionado = "";

        public FrmRol() : base()
        {
            base.formularioHijo = this;
            InitializeComponent();
            _tsegUsuarioController = new TsegUsuarioController();
            _tsegRolController = new TsegRolController();
            _tgenCompaniaController = new TgenCompaniaController();
        }

        private void ListarCompania()
        {
            IEnumerable<TgenCompaniaViewModel> lcompanias = _tgenCompaniaController.ListarCompania();
            cb_compania.DataSource = _tgenCompaniaController.mapearComboBox(lcompanias, "CCOMPANIA", "NOMBRECOMPANIA");
            cb_compania.DisplayMember = "label";
            cb_compania.ValueMember = "value";
        }

        public void InsertarRol()
        {
            if (!ejecutaSentencia())
                return;

            var pkRol = new Dictionary<string, object>
                {
                    { "CCOMPANIA",  ccompaniaSeleccionado },
                    { "CROL",  Convert.ToDecimal(txtCrol.Text) },
                };

            TsegRolViewModel rol = _tsegRolController.ObtenerRegistroPorPk(pkRol);

            if (rol != null)
            {
                MessageBox.Show("El Rol ya existe");
                return;
            }

            if (_tsegRolController.InsertarRol(_tsegRolViewModel))
            {
                MessageBox.Show("Registro creado correctamente");
            }
            else
            {
                MessageBox.Show("Error al registrar");
            }
        }
        public void ActualizarRol()
        {
            if (!ejecutaSentencia())
                return;
            if (_tsegRolController.ActualizarRol(_tsegRolViewModel))
            {
                MessageBox.Show("Registro modificado correctamente");
            }
            else
            {
                MessageBox.Show("Error al modificar Registro");
            }
        }

        private void limpiarContenido()
        {
            cb_compania.Text = "";
            cb_canal.Text = "";
            txtCrol.Text = "";
            txtNombre.Text = "";
            txtIcono.Text = "";
            txtColor.Text = "";
            chkEstatus.Checked = false;
        }
        public void ListarUsuarioRoles()
        {
            dgv_contenido.DataSource = _tsegRolController.ListarRol();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (esnuevo)
            {
                _tsegRolViewModel = new TsegRolViewModel();
                _tsegRolViewModel.CROL = Convert.ToDecimal(txtCrol.Text);
                _tsegRolViewModel.CCOMPANIA = ccompaniaSeleccionado;

                _tsegRolViewModel.CCANAL = ccanalSeleccionado;
                _tsegRolViewModel.NOMBRE = txtNombre.Text;
                _tsegRolViewModel.ICONO = txtIcono.Text;
                _tsegRolViewModel.COLOR = txtColor.Text;

                if (chkEstatus.Checked)
                    _tsegRolViewModel.ACTIVO = 1;
                else
                    _tsegRolViewModel.ACTIVO = 0;

                InsertarRol();
            }
            else
            {
                var pkUsuarioRol = new Dictionary<string, object>
                {
                    { "CROL",  Convert.ToDecimal(txtCrol.Text) },
                    { "CCOMPANIA",  ccompaniaSeleccionado },
                };

                _tsegRolViewModel = _tsegRolController.ObtenerRegistroPorPk(pkUsuarioRol);
                _tsegRolViewModel.CCANAL = ccanalSeleccionado;
                _tsegRolViewModel.NOMBRE = txtNombre.Text;
                _tsegRolViewModel.ICONO = txtIcono.Text;
                _tsegRolViewModel.COLOR = txtColor.Text;

                if (chkEstatus.Checked)
                    _tsegRolViewModel.ACTIVO = 1;
                else
                    _tsegRolViewModel.ACTIVO= 0;

                ActualizarRol();
            }

            ListarUsuarioRoles();
            limpiarContenido();
            btn_nuevo.Enabled = true;
            grbContenido.Enabled = false;
        }

        private void dgv_contenido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_contenido.SelectedRows.Count > 0)
            {
                cb_compania.Enabled = false;
                grbContenido.Enabled = true;
                esnuevo = false;

                ccompaniaSeleccionado = (decimal)dgv_contenido.CurrentRow.Cells[1].Value;
                ccanalSeleccionado = dgv_contenido.CurrentRow.Cells[2].Value.ToString();

                // setea el item correspondiente en el combo
                int indexCcomponia = cb_compania.FindStringExact(dgv_contenido.CurrentRow.Cells[1].Value.ToString());
                if (indexCcomponia != -1)
                    cb_compania.SelectedIndex = indexCcomponia;

                // setea el item correspondiente en el combo
                int indexCcanal = cb_canal.FindStringExact(dgv_contenido.CurrentRow.Cells[2].Value.ToString());
                if (indexCcanal != -1)
                    cb_canal.SelectedIndex = indexCcanal;

                txtCrol.Text = dgv_contenido.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgv_contenido.CurrentRow.Cells[4].Value.ToString();
                txtIcono.Text = dgv_contenido.CurrentRow.Cells[6].Value.ToString();
                txtColor.Text = dgv_contenido.CurrentRow.Cells[7].Value.ToString();

                int estatus = Convert.ToInt32(dgv_contenido.CurrentRow.Cells[5].Value.ToString());
                
                if (estatus == 1)
                {
                    chkEstatus.Checked = true;
                }
                else
                {
                    chkEstatus.Checked = false;
                }

            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            cb_compania.Enabled = true;
            grbContenido.Enabled = true;
            esnuevo = false;
        }

        private void FrmRol_Load(object sender, EventArgs e)
        {
            ListarUsuarioRoles();
        }
    }
}
