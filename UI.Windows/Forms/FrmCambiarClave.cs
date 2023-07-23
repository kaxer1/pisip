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

namespace UI.Windows.Forms
{
    public partial class FrmCambiarClave : FormBase
    {
        private decimal ccompania;
        private decimal crol;
        private string cusuario;

        private TsegUsuarioDetalleController contorllerUsuarioDetalle;
        private TsegUsuarioDetalleViewModel viewModelUsuarioDetalle;

        private TsegUsuarioDetalleHistController contorllerUsuarioDetalleHist;
        public FrmCambiarClave(decimal ccompania, string cusuario, decimal crol, Timer timer) : base(timer)
        {
            base.formularioHijo = this;
            InitializeComponent();
            this.ccompania = ccompania;
            this.cusuario = cusuario;
            this.crol = crol;
            contorllerUsuarioDetalle = new TsegUsuarioDetalleController();
            contorllerUsuarioDetalleHist = new TsegUsuarioDetalleHistController();
        }

        private void FrmCambiarClave_Load(object sender, EventArgs e)
        {
            AlmacenarPolitica(ccompania);
            if (viewModelPolitica != null)
            {
                lblLongitud.Text = viewModelPolitica.LONGITUD.ToString() + " - Longitud minima de caracteres";
                lblMayusculas.Text = viewModelPolitica.MAYUSCULAS.ToString() + " - Caracteres Mayúsculas";
                lblMinusculas.Text = viewModelPolitica.MINUSCULAS.ToString() + " - Caracteres Minúsculas";
                lblNumeros.Text = viewModelPolitica.NUMEROS.ToString() + " - Caracteres Números";
                lblEspeciales.Text = viewModelPolitica.ESPECIALES.ToString() + " - Caracteres Especiales";
            }
        }

        private void txtPassNuevo_TextChanged(object sender, EventArgs e)
        {
            TextBox txtLocal = (TextBox)sender;

            bool longitud;
            bool especiales;
            bool numeros;
            bool mayusculas;
            bool minusculas;

            VerificarPoliticasPassword(txtLocal.Text, out longitud, out especiales, out numeros, out mayusculas, out minusculas);

            lblLongitud.ForeColor = (longitud) ? Color.Green : Color.Red;
            lblEspeciales.ForeColor = (especiales) ? Color.Green : Color.Red;
            lblNumeros.ForeColor = (numeros) ? Color.Green : Color.Red;
            lblMayusculas.ForeColor = (mayusculas) ? Color.Green : Color.Red;
            lblMinusculas.ForeColor = (minusculas) ? Color.Green : Color.Red;
        }

        private void txtPassNuevoConfirmacion_TextChanged(object sender, EventArgs e)
        {
            TextBox txtLocal = (TextBox)sender;
            if (txtLocal.Text == txtPassNuevo.Text)
            {
                lblPasswordIgual.Visible = true;
            } else
            {
                lblPasswordIgual.Visible = false;
            }
        }

        private void btnCambiarPassword_Click(object sender, EventArgs e)
        {
            // busca si el usuario existe
            string passwordAnteriorEncriptado = contorllerUsuarioDetalle.EncryptPassword(txtPassAnterior.Text);
            viewModelUsuarioDetalle = contorllerUsuarioDetalle.ValidaUsuarioExiste(this.cusuario, passwordAnteriorEncriptado, this.ccompania, ccanal, this.crol);

            if(viewModelUsuarioDetalle == null)
            {
                MessageBox.Show("EL USUARIO PARA ESE ROL NO EXISTE");
                return;
            }
            // Fin
            // Inicio busca por filtro los registros historicos del usuario para validar si puede o no repetir la nueva contrasenia
            var filtros = new Dictionary<string, object>
                {
                    { "CUSUARIO", viewModelUsuarioDetalle.CUSUARIO },
                    { "CCOMPANIA", viewModelUsuarioDetalle.CCOMPANIA }
                };
            IEnumerable<TsegUsuarioDetalleHistViewModel> lhistorico = contorllerUsuarioDetalleHist.ListarPorFiltro(filtros);

            string passwordNuevoEncriptado = contorllerUsuarioDetalle.EncryptPassword(txtPassNuevo.Text);
            int count = 0;
            if (lhistorico != null)
            {
                foreach(TsegUsuarioDetalleHistViewModel reg in lhistorico)
                {
                    if (passwordNuevoEncriptado == reg.PASSWORD)
                        count++;
                }
            }
            if( !ValidaPasswordRepeticiones(count) )
            {
                MessageBox.Show("EXCEDIO EL NÚMERO DE VECES QUE PUEDE REPETIR LA CONTRASEÑA PARA ACCEDER INGRESE UNA NUEVA CONTRASEÑA.");
                txtPassNuevo.Text = "";
                txtPassNuevoConfirmacion.Text = "";
                lblPasswordIgual.Visible = false;
                return;
            }
            // Fin

            // Crea Historia
            contorllerUsuarioDetalle.InsertarHistorial(viewModelUsuarioDetalle);

            // Cambia la contrasenia y actualiza registro
            viewModelUsuarioDetalle.PASSWORD = passwordNuevoEncriptado;
            viewModelUsuarioDetalle.CUSUARIOMOD = this.cusuario;
            contorllerUsuarioDetalle.ActualizarUsuarioDetalle(viewModelUsuarioDetalle);
            
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
