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

namespace UI.Windows
{
    public partial class FrmUsuario : Form
    {
        private TsegUsuarioController controllerUsuario;
        private TsegUsuarioViewModel viewModelUsuario;

        private TsegUsuarioDetalleController controllerUsuarioDetalle;
        private TsegUsuarioDetalleViewModel viewModelUsuarioDetalle;

        public FrmUsuario()
        {
            InitializeComponent();
            controllerUsuario = new TsegUsuarioController();
            controllerUsuarioDetalle = new TsegUsuarioDetalleController();
        }

        public void InsertarUsuario()
        {
            if (controllerUsuario.InsertarUsuario(viewModelUsuario))
            {
                MessageBox.Show("Usuario insertado correctamente");
            }
            else
            {
                MessageBox.Show("Error al insertar Usuario");
            }
            if (controllerUsuarioDetalle.InsertarUsuarioDetalle(viewModelUsuarioDetalle))
            {
                MessageBox.Show("Usuario Detalle insertado correctamente");
            }
            else
            {
                MessageBox.Show("Error al insertar Usuario Detalle");
            }
        }

        public void ActualizarUsuario()
        {
            if (controllerUsuario.ActualizarUsuario(viewModelUsuario))
            {
                MessageBox.Show("Usuario actualizado correctamente");
            }
            else
            {
                MessageBox.Show("Error al actualizar Usuario");
            }
            if (controllerUsuarioDetalle.ActualizarUsuarioDetalle(viewModelUsuarioDetalle))
            {
                MessageBox.Show("Usuario actualizado correctamente");
            }
            else
            {
                MessageBox.Show("Error al actualizar Usuario");
            }
        }

        private void ListarUsuarios()
        {
            dgvListaUsuario.DataSource = controllerUsuarioDetalle.ListarUsuarioDetalle();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grbFormulario.Enabled = true;
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            viewModelUsuario = new TsegUsuarioViewModel();
            viewModelUsuario.CUSUARIO = txtCusuario.Text;
            viewModelUsuario.CCOMPANIA = int.Parse(txtCcompania.Text);
            viewModelUsuario.CINTERNO = int.Parse(txtCinterno.Text);

            viewModelUsuarioDetalle = new TsegUsuarioDetalleViewModel();
            viewModelUsuarioDetalle.CUSUARIO = txtCusuario.Text;
            viewModelUsuarioDetalle.CCOMPANIA = int.Parse(txtCcompania.Text);
            viewModelUsuarioDetalle.CCANAL = txtCcanal.Text;
            viewModelUsuarioDetalle.SOBRENOMBRE= txtSobreNombre.Text;
            viewModelUsuarioDetalle.PASSWORD = controllerUsuario.EncryptPassword( txtPassword.Text );
            viewModelUsuarioDetalle.OBSERVACION = txtObservacion.Text;

            if (chkEstatus.Checked)
            {
                viewModelUsuarioDetalle.ESTATUS = 1;
            }
            else
            {
                viewModelUsuarioDetalle.ESTATUS = 0;
            }

            // Solo inserta porque debe ingresar el codigo de usuario. 
            // TODO implementar la actualizacion con alguna bandera.
            InsertarUsuario();
            
            ListarUsuarios();
        }

        private void txtCcompania_KeyPress(object sender, KeyPressEventArgs e)
        {
            controllerUsuario.validarSoloNumerosTextBox(txtCcompania);
        }

        private void txtCinterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            controllerUsuario.validarSoloNumerosTextBox(txtCinterno);
        }
    }
}
