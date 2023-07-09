using System;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace UI.Windows.Forms
{
    public partial class FormBase : Form
    {
        protected Form formularioHijo;
        
        protected string ccanal = "OFI";

        protected decimal tiemposession = 5;

        private Timer sessionTimer;

        public FormBase() { }

        public void validarSoloNumerosTextBox(TextBox textBox)
        {
            textBox.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            };
        }

        public void validarSoloLetrasTextBox(TextBox textBox)
        {
            textBox.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
            };
        }

        public void validarSinCaracteresEspecialesTextBox(TextBox textBox)
        {
            textBox.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            };
        }

        public void IniciaContador(decimal minutos)
        {
            // Configurar el temporizador de sesión
            sessionTimer = new Timer();
            sessionTimer.Interval = Convert.ToInt32( TimeSpan.FromMinutes( Convert.ToDouble(minutos) ).TotalMilliseconds );
            sessionTimer.Tick += SessionAccionFinaliza;

            IniciarTimer();
        }
        private void IniciarTimer()
        {
            // Iniciar el temporizador de sesión
            sessionTimer.Start();
        }

        private void SessionAccionFinaliza(object sender, EventArgs e)
        {
            // Detener el temporizador
            sessionTimer.Stop();
            // Cerrar el formulario hijo
            CerrarFormularioHijo();
        }

        protected virtual void CerrarFormularioHijo()
        {
            // Implementa la lógica para cerrar el formulario hijo en las clases derivadas
            formularioHijo.Close();
            MessageBox.Show("SESION FINALIZADA");
        }
    }
}
