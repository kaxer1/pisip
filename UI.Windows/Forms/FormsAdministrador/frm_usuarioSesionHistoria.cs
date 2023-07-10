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
    public partial class frm_usuarioSesionHistoria : Form
    {
        private TsegUsuarioSessionHistoriaController _TsegUsuarioSessionHistoriaController;
        private TsegUsuarioController _tsegUsuarioController;
        public frm_usuarioSesionHistoria()
        {
            _tsegUsuarioController = new TsegUsuarioController();
            _TsegUsuarioSessionHistoriaController = new TsegUsuarioSessionHistoriaController();
            InitializeComponent();
        }

        public void ListarSessiones(string usuario)
        {

            dgv_historia.DataSource = _TsegUsuarioSessionHistoriaController.ListarUsuarioSessionHistoria(usuario);

        }
        private void ListarUsuarios()
        {

            cb_usuario.DataSource = _tsegUsuarioController.ListarUsuario();
            cb_usuario.DisplayMember = "CUSUARIO";
            cb_usuario.ValueMember = "CUSUARIO";
        }

        private void btn_consultat_Click(object sender, EventArgs e)
        {
            ListarSessiones(cb_usuario.GetItemText(cb_usuario.SelectedValue));
        }

        private void frm_usuarioSesionHistoria_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }
    }
}
