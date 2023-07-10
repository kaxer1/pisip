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
    public partial class frm_usuarioRol : Form
    {
        private TsegUsuarioRolController _tsegUsuarioRolController;
        private TsegUsuarioRolViewModel _TsegUsuarioRolViewModel;

        //Referencias
        private TsegUsuarioController _tsegUsuarioController;
        private TsegRolController _tsegRolController;
        private TgenCompaniaController _tgenCompaniaController;


        public frm_usuarioRol()
        {
            InitializeComponent();
            _tsegUsuarioRolController = new TsegUsuarioRolController();
            _tsegUsuarioController = new TsegUsuarioController();
            _tsegRolController = new TsegRolController();
            _tgenCompaniaController = new TgenCompaniaController();
        }

        private void ListarUsuarios()
        {

            cb_usuario.DataSource = _tsegUsuarioController.ListarUsuario();
            cb_usuario.DisplayMember = "CUSUARIO";
            cb_usuario.ValueMember = "CUSUARIO";
        }
        private void ListarRoles()
        {

            cb_rol.DataSource = _tsegRolController.ListarRol();
            cb_rol.DisplayMember = "NOMBRE";
            cb_rol.ValueMember = "CROL";
        }

        private void ListarCompania()
        {

            cb_compania.DataSource = _tgenCompaniaController.ListarCompania();
            cb_compania.DisplayMember = "NOMBRECOMPANIA";
            cb_compania.ValueMember = "CCOMPANIA";
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

            dgv_contenido.DataSource = _tsegUsuarioRolController.ListarUsuarioRol();

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            _TsegUsuarioRolViewModel = new TsegUsuarioRolViewModel();
            _TsegUsuarioRolViewModel.CUSUARIO = cb_usuario.GetItemText(cb_usuario.SelectedValue);
            _TsegUsuarioRolViewModel.CROL = decimal.Parse(cb_rol.GetItemText(cb_rol.SelectedValue));
            _TsegUsuarioRolViewModel.CCOMPANIA = decimal.Parse(cb_compania.GetItemText(cb_compania.SelectedValue));
            _TsegUsuarioRolViewModel.CUSUARIOING = "ADMIN";
            _TsegUsuarioRolViewModel.CUSUARIOMOD = "ADMIN";
            _TsegUsuarioRolViewModel.FINGRESO = DateTime.Now;
            _TsegUsuarioRolViewModel.FMODIFICACION = DateTime.Now;
                     

                InsertarUsuarioROl();
            
            ListarUsuarioRoles();
            limpiarContenido();
            btn_nuevo.Enabled = true;
            gp_contenido.Enabled = false;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            gp_contenido.Enabled = true;
        }

        private void frm_usuarioRol_Load(object sender, EventArgs e)
        {
            ListarUsuarioRoles();
            ListarUsuarios();
            ListarRoles();
            ListarCompania();
        }
    }
}
