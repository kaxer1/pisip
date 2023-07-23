using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Windows.AplicationController;
using UI.Windows.ViewModel;
using System.Windows.Forms;

namespace UI.Windows.Forms.FormsAdministrador
{
    public partial class FrmUsuarioRol : FormBase
    {
        private TsegUsuarioRolController _tsegUsuarioRolController;
        private TsegUsuarioRolViewModel _TsegUsuarioRolViewModel;

        //Referencias
        private TsegUsuarioController _tsegUsuarioController;
        private TsegRolController _tsegRolController;
        private TsegRolViewModel _TsegRolViewModel;
        private TgenCompaniaController _tgenCompaniaController;

        private string cusuarioSeleccionado = "";
        private decimal ccompaniaSeleccionado = 0;
        private decimal crolSeleccionado = 0;

        public FrmUsuarioRol(Timer timer) : base(timer)
        {
            base.formularioHijo = this;
            InitializeComponent();
            _tsegUsuarioRolController = new TsegUsuarioRolController();
            _tsegUsuarioController = new TsegUsuarioController();
            _tsegRolController = new TsegRolController();
            _tgenCompaniaController = new TgenCompaniaController();
        }

        private void ListarUsuarios()
        {
            IEnumerable<TsegUsuarioViewModel> lregistros = _tsegUsuarioController.ListarUsuario();
            cb_usuario.DataSource = _tsegUsuarioController.mapearComboBox(lregistros, "CUSUARIO", "CUSUARIO");
            cb_usuario.DisplayMember = "label";
            cb_usuario.ValueMember = "value";
        }
        private void ListarRoles()
        {
            IEnumerable<TsegRolViewModel> lregistros = _tsegRolController.ListarRol();
            cb_rol.DataSource = _tsegRolController.mapearComboBox(lregistros, "CROL", "NOMBRE");
            cb_rol.DisplayMember = "label";
            cb_rol.ValueMember = "value";
        }

        private void ListarCompania()
        {
            IEnumerable<TgenCompaniaViewModel> lcompanias = _tgenCompaniaController.ListarCompania();
            cb_compania.DataSource = _tgenCompaniaController.mapearComboBox(lcompanias, "CCOMPANIA", "NOMBRECOMPANIA");
            cb_compania.DisplayMember = "label";
            cb_compania.ValueMember = "value";
        }

        public void InsertarUsuarioROl()
        {
            if (_tsegUsuarioRolController.InsertarUsuarioRol(_TsegUsuarioRolViewModel))
            {
                MessageBox.Show("Registro creado correctamente");
            }
            else
            {
                MessageBox.Show("Error al registrar");
            }
        }
        public void ActualizarUsuarioRol()
        {
            if (_tsegUsuarioRolController.ActualizarUsuarioRol(_TsegUsuarioRolViewModel))
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
            cb_usuario.SelectedItem = "";
            cb_rol.Text = "";
            cb_compania.Text = "";
        }
        public void ListarUsuarioRoles()
        {
            ejecutaSentencia();
            dgv_contenido.DataSource = _tsegUsuarioRolController.ListarUsuarioRol();
            dgv_contenido.Columns[0].ReadOnly = true;
            dgv_contenido.Columns[1].ReadOnly = true;
            dgv_contenido.Columns[2].ReadOnly = true;
            dgv_contenido.Columns[3].ReadOnly = true;
            dgv_contenido.Columns[4].ReadOnly = true;
            dgv_contenido.Columns[5].ReadOnly = true;
        }

        private void FrmUsuarioRol_Load(object sender, EventArgs e)
        {
            ejecutaSentencia();
            ListarUsuarios();
            ListarRoles();
            ListarCompania();
            ListarUsuarioRoles();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            ejecutaSentencia();
            var pkRol = new Dictionary<string, object>
                {
                    { "CCOMPANIA",  ccompaniaSeleccionado },
                    { "CROL",  crolSeleccionado },
                };

            _TsegRolViewModel = _tsegRolController.ObtenerRegistroPorPk(pkRol);

            if (_TsegRolViewModel == null)
            {
                MessageBox.Show("EL ROL SELECCIONADO NO EXISTE");
                return;
            }

            var pkUsuarioRol = new Dictionary<string, object>
                {
                    { "CUSUARIO",  cusuarioSeleccionado },
                    { "CCOMPANIA",  ccompaniaSeleccionado },
                    { "CROL",  crolSeleccionado },
                };

            _TsegUsuarioRolViewModel = _tsegUsuarioRolController.ObtenerRegistroPorPk(pkUsuarioRol);

            if (esnuevo)
            {
                if (_TsegUsuarioRolViewModel != null)
                {
                    MessageBox.Show("EL CÓDIGO DE REGISTRO YA EXISTE");
                    return;
                }
                _TsegUsuarioRolViewModel = new TsegUsuarioRolViewModel();
                _TsegUsuarioRolViewModel.CUSUARIO = cusuarioSeleccionado;
                _TsegUsuarioRolViewModel.CCOMPANIA = ccompaniaSeleccionado;
                _TsegUsuarioRolViewModel.CROL = crolSeleccionado;

                InsertarUsuarioROl();
            }
            else
            {
                ActualizarUsuarioRol();
            }
            
            ListarUsuarioRoles();
            limpiarContenido();
            btn_nuevo.Enabled = true;
            gp_contenido.Enabled = false;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            gp_contenido.Enabled = true;
            cb_compania.Enabled = true;
            cb_rol.Enabled = true;
            cb_usuario.Enabled = true;
            esnuevo = true;
        }

        private void cb_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxSelectItem selectedItem = (ComboBoxSelectItem)cb_usuario.SelectedItem;
            cusuarioSeleccionado= selectedItem.value;
        }

        private void cb_rol_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxSelectItem selectedItem = (ComboBoxSelectItem)cb_rol.SelectedItem;
            crolSeleccionado = Convert.ToDecimal( selectedItem.value.ToString() );
        }

        private void cb_compania_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxSelectItem selectedItem = (ComboBoxSelectItem)cb_compania.SelectedItem;
            ccompaniaSeleccionado = Convert.ToDecimal(selectedItem.value.ToString());
        }

        private void dgv_contenido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_contenido.SelectedRows.Count > 0)
            {
                cb_compania.Enabled = false;
                cb_rol.Enabled = false;
                cb_usuario.Enabled = false;
                gp_contenido.Enabled = true;
                esnuevo = false;

                cusuarioSeleccionado = dgv_contenido.CurrentRow.Cells[0].Value.ToString();
                ccompaniaSeleccionado = (decimal)dgv_contenido.CurrentRow.Cells[1].Value;
                crolSeleccionado = (decimal)dgv_contenido.CurrentRow.Cells[2].Value;

                // setea el item correspondiente en el combo
                cb_usuario.SelectedValue = dgv_contenido.CurrentRow.Cells[0].Value.ToString();

                // setea el item correspondiente en el combo
                cb_compania.SelectedValue = dgv_contenido.CurrentRow.Cells[1].Value.ToString();

                // setea el item correspondiente en el combo
                cb_rol.SelectedValue = dgv_contenido.CurrentRow.Cells[2].Value.ToString();

            }
        }
    }
}
