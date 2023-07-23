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
        private TgenCompaniaController _tgenCompaniaController;

        private TgenCanalesController _tgenCanalesController;

        private decimal ccompaniaSeleccionado = 0;
        private string ccanalSeleccionado = "";

        public FrmRol(Timer timer) : base(timer)
        {
            base.formularioHijo = this;
            InitializeComponent();
            _tsegRolController = new TsegRolController();
            _tgenCompaniaController = new TgenCompaniaController();
            _tgenCanalesController = new TgenCanalesController();
        }

        private void ListarCompania()
        {
            IEnumerable<TgenCompaniaViewModel> lcompanias = _tgenCompaniaController.ListarCompania();
            cb_compania.DataSource = _tgenCompaniaController.mapearComboBox(lcompanias, "CCOMPANIA", "NOMBRECOMPANIA");
            cb_compania.DisplayMember = "label";
            cb_compania.ValueMember = "value";
        }

        private void ListarCanal()
        {
            IEnumerable<TgenCanalesViewModel> lcanales = _tgenCanalesController.ListarCanales();
            cb_canal.DataSource = _tgenCanalesController.mapearComboBox(lcanales, "CCANAL", "NOMBRE");
            cb_canal.DisplayMember = "label";
            cb_canal.ValueMember = "value";
        }

        public void InsertarRol()
        {
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
            dgv_contenido.Columns[0].ReadOnly = true;
            dgv_contenido.Columns[1].ReadOnly = true;
            dgv_contenido.Columns[2].ReadOnly = true;
            dgv_contenido.Columns[3].Visible = false;
            dgv_contenido.Columns[4].ReadOnly = true;
            dgv_contenido.Columns[5].ReadOnly = true;
            dgv_contenido.Columns[6].ReadOnly = true;
            dgv_contenido.Columns[7].ReadOnly = true;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            ejecutaSentencia();
            var pkUsuarioRol = new Dictionary<string, object>
                {
                    { "CROL",  Convert.ToDecimal((txtCrol.Text == "") ? "0": txtCrol.Text) },
                    { "CCOMPANIA",  ccompaniaSeleccionado },
                };

            _tsegRolViewModel = _tsegRolController.ObtenerRegistroPorPk(pkUsuarioRol);

            if (esnuevo)
            {
                if (_tsegRolViewModel != null)
                {
                    MessageBox.Show("EL CÓDIGO DE REGISTRO YA EXISTE");
                    return;
                }
                _tsegRolViewModel = new TsegRolViewModel();
                _tsegRolViewModel.CROL = Convert.ToDecimal((txtCrol.Text == "") ? "0" : txtCrol.Text);
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
                cb_compania.SelectedValue = dgv_contenido.CurrentRow.Cells[1].Value.ToString();

                // setea el item correspondiente en el combo
                cb_canal.SelectedValue = dgv_contenido.CurrentRow.Cells[2].Value.ToString();

                txtCrol.Text = dgv_contenido.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgv_contenido.CurrentRow.Cells[4].Value.ToString();
                txtIcono.Text = (dgv_contenido.CurrentRow.Cells[6].Value == null) ? "" : dgv_contenido.CurrentRow.Cells[6].Value.ToString();
                txtColor.Text = (dgv_contenido.CurrentRow.Cells[7].Value == null) ? "" : dgv_contenido.CurrentRow.Cells[7].Value.ToString();

                int estatus = Convert.ToInt32(dgv_contenido.CurrentRow.Cells[5].Value.ToString());
                
                if (estatus == 1)
                    chkEstatus.Checked = true;
                else
                    chkEstatus.Checked = false;

            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            cb_compania.Enabled = true;
            grbContenido.Enabled = true;
            esnuevo = true;
        }

        private void FrmRol_Load(object sender, EventArgs e)
        {
            ListarCompania();
            ListarCanal();
            ListarUsuarioRoles();
        }

        private void cb_compania_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxSelectItem selectedItem = (ComboBoxSelectItem)cb_compania.SelectedItem;
            ccompaniaSeleccionado = decimal.Parse(selectedItem.value);
        }

        private void cb_canal_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxSelectItem selectedItem = (ComboBoxSelectItem)cb_canal.SelectedItem;
            ccanalSeleccionado = selectedItem.value;
        }
    }
}
