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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

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

        private decimal ccompaniaSeleccionado = 0;
        private decimal crolSeleccionado = 0;
        private int intentosLogin = 0;
        private Guid sessionId;

        public FrmLogin() : base()
        {
            base.formularioHijo = this;
            InitializeComponent();
            controllerUsuarioDetalle = new TsegUsuarioDetalleController();
            controllerUsuarioSession = new TsegUsuarioSessionController();
            controllerCompania = new TgenCompaniaController();
            controllerRol = new TsegRolController();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            AlmacenarPolitica(ccompaniaSeleccionado);

            string usuario = txtUsuario.Text;
            string password = controllerUsuarioDetalle.EncryptPassword( txtClave.Text );

            viewModelUsuarioDetalle = controllerUsuarioDetalle.Login(usuario, password, ccompaniaSeleccionado, ccanal, crolSeleccionado);

            if(viewModelUsuarioDetalle == null)
            {
                intentosLogin++;
                bool bloquea = ValidaIntentosLogin(intentosLogin);

                if(bloquea)
                {
                    this.ManejaBloqueoSession(usuario);
                } else
                {
                    MessageBox.Show("EL USUARIO O CONTRASEÑA INCORRECTO.");
                }
            }
            else
            {
                this.ManejarSession();
            }

        }

        private void ManejaBloqueoSession(string usuario)
        {
            var pkUsuario = new Dictionary<string, object>
                    {
                        { "CUSUARIO", usuario },
                        { "CCOMPANIA", ccompaniaSeleccionado }
                    };

            TsegUsuarioDetalleViewModel detalleUsuario = controllerUsuarioDetalle.ObtenerRegistroPorPk(pkUsuario);

            if (detalleUsuario != null)
            {
                controllerUsuarioDetalle.InsertarHistorial(detalleUsuario);
                detalleUsuario.OBSERVACION = "BLOQUEO POR INGRESO DE CONTRASEÑA INCORRECTA";
                detalleUsuario.CAMBIOPASSWORD = "1";
                detalleUsuario.ESTATUS = 0;
                controllerUsuarioDetalle.ActualizarUsuarioDetalle(detalleUsuario);
            }

            TsegUsuarioSessionViewModel sessionUsuario = controllerUsuarioSession.ObtenerRegistroPorPk(pkUsuario);

            if (sessionUsuario == null)
            {
                sessionUsuario = new TsegUsuarioSessionViewModel();
                sessionUsuario.CUSUARIO = usuario;
                sessionUsuario.CCOMPANIA = ccompaniaSeleccionado;
                sessionUsuario.CESTADO = "F";
                sessionUsuario.FINICIO = DateTime.Now;
                sessionUsuario.ACTIVO = "0";
                sessionUsuario.NUMEROINTENTOS = intentosLogin;
                controllerUsuarioSession.InsertarUsuarioSession(sessionUsuario);
            }
            else
            {
                controllerUsuarioSession.InsertarHistorial(sessionUsuario);
                sessionUsuario.CESTADO = "F";
                sessionUsuario.FINICIO = DateTime.Now;
                sessionUsuario.ACTIVO = "0";
                sessionUsuario.NUMEROINTENTOS = intentosLogin;
                controllerUsuarioSession.ActualizarUsuarioSession(sessionUsuario);
            }
            MessageBox.Show("EL USUARIO FUE BLOQUEADO POR EXCEDER EL NÚMERO DE INTENTOS FALLIDOS.");
        }

        private void ManejarSession()
        {
            sessionId = Guid.NewGuid();
            var pkUsuarioSession = new Dictionary<string, object>
                {
                    { "CUSUARIO", viewModelUsuarioDetalle.CUSUARIO },
                    { "CCOMPANIA", viewModelUsuarioDetalle.CCOMPANIA }
                };

            viewModelUsuarioSession = controllerUsuarioSession.ObtenerRegistroPorPk(pkUsuarioSession);

            if (viewModelUsuarioSession == null)
            {
                viewModelUsuarioSession = new TsegUsuarioSessionViewModel();
                viewModelUsuarioSession.CUSUARIO = viewModelUsuarioDetalle.CUSUARIO;
                viewModelUsuarioSession.CCOMPANIA = viewModelUsuarioDetalle.CCOMPANIA;
                viewModelUsuarioSession.CESTADO = "I";
                viewModelUsuarioSession.FINICIO = DateTime.Now;
                viewModelUsuarioSession.ACTIVO = "1";
                viewModelUsuarioSession.NUMEROINTENTOS = intentosLogin;
                viewModelUsuarioSession.IDSESSION = sessionId.ToString();
                controllerUsuarioSession.InsertarUsuarioSession(viewModelUsuarioSession);
            }
            else
            {
                controllerUsuarioSession.InsertarHistorial(viewModelUsuarioSession);
                viewModelUsuarioSession.CESTADO = "I";
                viewModelUsuarioSession.FINICIO = DateTime.Now;
                viewModelUsuarioSession.ACTIVO = "1";
                viewModelUsuarioSession.NUMEROINTENTOS = intentosLogin;
                viewModelUsuarioSession.IDSESSION = sessionId.ToString();
                controllerUsuarioSession.ActualizarUsuarioSession(viewModelUsuarioSession);
            }

            this.ManejarPoliticas();

        }

        private void ManejarPoliticas()
        {

            if(viewModelPolitica.TIEMPOSESION != null)
            {
                tiemposession = (decimal) viewModelPolitica.TIEMPOSESION;
                
                MdatosSession mdatos = new MdatosSession();
                mdatos.ccanal = ccanal;
                mdatos.ccompania = ccompaniaSeleccionado;
                mdatos.crol = crolSeleccionado;
                mdatos.cusuario = viewModelUsuarioDetalle.CUSUARIO;

                GuardarInicioSessionCache(tiemposession, mdatos);
                
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
                MDIAdministrador formAdministrador = new MDIAdministrador();
                formAdministrador.IniciaContador(tiemposession);
                DialogResult resultadoAdministrador = formAdministrador.ShowDialog();

                if (resultadoAdministrador == DialogResult.Cancel)
                {
                    MostrarVenta();
                }
            }

            if (crolSeleccionado == 2) // ROL FUNCIONARIO
            {
                MDIFuncionario formFuncionario = new MDIFuncionario();
                formFuncionario.IniciaContador(tiemposession);
                DialogResult resultadoAdministrador = formFuncionario.ShowDialog();

                if (resultadoAdministrador == DialogResult.Cancel)
                {
                    MostrarVenta();
                }
            }

            RemoverSession();
        }

        private void MostrarVenta()
        {
            try
            {
                this.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR AL MOSTRAR LA PANTALLA: " + ex.Message);
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
            ComboBoxSelectItem selectedItem = (ComboBoxSelectItem) cbRol.SelectedItem;
            crolSeleccionado = decimal.Parse(selectedItem.value);
        }

        private void btnCambiarPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCambiarClave frmCambiarClave = new FrmCambiarClave(ccompaniaSeleccionado, txtUsuario.Text, crolSeleccionado);
            DialogResult resultadoCambioClave = frmCambiarClave.ShowDialog();

            if (resultadoCambioClave == DialogResult.OK)
            {
                limpiarFormularioLogin();
            }
            this.Show();
        }
    }
}
