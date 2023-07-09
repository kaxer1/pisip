using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio.Model.Entities;
using UI.Windows.AplicationController;
using UI.Windows.Forms.FormsFuncionario;
using UI.Windows.ViewModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI.Windows.Forms
{
    public partial class FrmLogin : FormBase
    {
        TsegUsuarioDetalleController controllerUsuarioDetalle;
        TsegUsuarioDetalleViewModel viewModelUsuarioDetalle;

        TsegUsuarioSessionController controllerUsuarioSession;
        TsegUsuarioSessionViewModel viewModelUsuarioSession;

        TgenCompaniaController controllerCompania;

        TsegRolController controllerRol;

        TsegPoliticaController controllerPolitica;
        TsegPoliticaViewModel viewModelPolitica;

        private decimal ccompaniaSeleccionado = 0;
        private decimal crolSeleccionado = 0;

        public FrmLogin() : base()
        {
            InitializeComponent();
            controllerUsuarioDetalle = new TsegUsuarioDetalleController();
            controllerUsuarioSession = new TsegUsuarioSessionController();
            controllerCompania = new TgenCompaniaController();
            controllerRol = new TsegRolController();
            controllerPolitica = new TsegPoliticaController();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = controllerUsuarioDetalle.EncryptPassword( txtClave.Text );

            viewModelUsuarioDetalle = controllerUsuarioDetalle.Login(usuario, password, ccompaniaSeleccionado, ccanal, crolSeleccionado);

            if(viewModelUsuarioDetalle == null)
            {
                MessageBox.Show("El usuario no existe");
            } else
            {
                var pkUsuarioSession = new Dictionary<string, object>
                {
                    { "CUSUARIO", viewModelUsuarioDetalle.CUSUARIO }, 
                    { "CCOMPANIA", viewModelUsuarioDetalle.CCOMPANIA }  
                };

                viewModelUsuarioSession = controllerUsuarioSession.ObtenerRegistroPorPk(pkUsuarioSession);
                
                if(viewModelUsuarioSession == null)
                {
                    viewModelUsuarioSession = new TsegUsuarioSessionViewModel();
                    viewModelUsuarioSession.CUSUARIO = viewModelUsuarioDetalle.CUSUARIO;
                    viewModelUsuarioSession.CCOMPANIA = viewModelUsuarioDetalle.CCOMPANIA;
                    viewModelUsuarioSession.CESTADO = "I";
                    viewModelUsuarioSession.FINICIO = DateTime.Now;
                    viewModelUsuarioSession.ACTIVO = "1";

                    controllerUsuarioSession.InsertarUsuarioSession(viewModelUsuarioSession);
                } else
                {
                    controllerUsuarioSession.InsertarHistorial(viewModelUsuarioSession);
                    viewModelUsuarioSession.CESTADO = "I";
                    viewModelUsuarioSession.FINICIO = DateTime.Now;
                    viewModelUsuarioSession.ACTIVO = "1";
                    controllerUsuarioSession.ActualizarUsuarioSession(viewModelUsuarioSession);
                }

                this.ManejarPoliticas();
            }

        }

        private void ManejarPoliticas()
        {
            var pkrol = new Dictionary<string, object>
                {
                    { "CCOMPANIA", viewModelUsuarioDetalle.CCOMPANIA },
                    { "CCANAL", ccanal }
                };
            viewModelPolitica = controllerPolitica.ObtenerRegistroPorPk(pkrol);

            if(viewModelPolitica.TIEMPOSESION != null)
            {
                tiemposession = (decimal) viewModelPolitica.TIEMPOSESION;
                this.ManejoRoles();
            } else
            {
                MessageBox.Show("POLITICAS DE SEGURIDAD NO REGISTRADO");
            }

        }

        private void ManejoRoles()
        {

            this.Hide();
            this.limpiarFormularioLogin();

            if (crolSeleccionado == 1) // ROL ADMINISTRADOR
            {
                // TODO validacion de ventanas.
                MDIAdministrador formAdministrador = new MDIAdministrador();
                formAdministrador.IniciaContador(tiemposession);
                DialogResult resultadoAdministrador = formAdministrador.ShowDialog();

                if (resultadoAdministrador == DialogResult.Cancel)
                {
                    this.Show();
                }
            }

            if (crolSeleccionado == 2) // ROL FUNCIONARIO
            {
                MDIFuncionario formFuncionario = new MDIFuncionario();
                formFuncionario.IniciaContador(tiemposession);
                DialogResult resultadoAdministrador = formFuncionario.ShowDialog();

                if (resultadoAdministrador == DialogResult.Cancel)
                {
                    this.Show();
                }
            }

        }

        private void limpiarFormularioLogin ()
        {
            txtUsuario.Text = "";
            txtClave.Text = "";
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.validarSinCaracteresEspecialesTextBox(txtUsuario);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            IEnumerable<TgenCompaniaViewModel> lcompanias = controllerCompania.ListarCompania();
            cbCompania.DataSource = controllerCompania.mapearComboBox(lcompanias, "CCOMPANIA", "NOMBRECOMPANIA");
            cbCompania.DisplayMember = "label";
            cbCompania.ValueMember = "value";
        }

        private void cbCompania_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxSelectItem selectedItem = (ComboBoxSelectItem) cbCompania.SelectedItem;
            ccompaniaSeleccionado = decimal.Parse(selectedItem.value);

            var filtro = new Dictionary<string, object>
                {
                    { "CCOMPANIA", ccompaniaSeleccionado},
                    { "CCANAL", ccanal}
                };

            IEnumerable<TsegRolViewModel> lroles = controllerRol.ListarPorFiltro(filtro);
            cbRol.DataSource = controllerRol.mapearComboBox(lroles, "CROL", "NOMBRE");
            cbRol.DisplayMember = "label";
            cbRol.ValueMember = "value";
        }

        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxSelectItem selectedItem = (ComboBoxSelectItem)cbRol.SelectedItem;
            crolSeleccionado = decimal.Parse(selectedItem.value);
        }
    }
}
