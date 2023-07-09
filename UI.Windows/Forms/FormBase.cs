using System;
using System.Collections.Generic;
using System.Runtime.Caching;
using System.Windows.Forms;
using Aplicacion.Aplicacion.Services;
using Dominio.Model.Entities;
using UI.Windows.AplicationController;
using Timer = System.Windows.Forms.Timer;

namespace UI.Windows.Forms
{
    public partial class FormBase : Form
    {
        protected Form formularioHijo;
        
        protected string ccanal = "OFI";

        protected decimal tiemposession = 5;

        private Timer sessionTimer;

        private static MemoryCache cache = MemoryCache.Default;

        private TsegUsuarioSessionServices serviceUsuarioSession;

        private static string CACHE_CLAVE_SESSION = "mdatossession";

        public FormBase() {
            serviceUsuarioSession = new TsegUsuarioSessionServices();
        }

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

        /****************************************************************************
         * 
         * INICIO METODOS DEL CONTADOR
         * 
         ************************************************************************** */
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

        /****************************************************************************
         * FIN METODOS DEL CONTADOR
         ************************************************************************** */

        /****************************************************************************
         * 
         * INICIO METODOS DEL CACHE DE SESSION
         * 
         ************************************************************************** */
        protected bool ejecutaSentencia()
        {
            if (!validarSentencia())
            {
                formularioHijo.Close();
                MessageBox.Show("LA SESION A SIDO DESACTIVADA, EL PROGRAMA SE CERRARA");
                Application.Exit();
                return false;
            }
            return true;
        }

        private bool validarSentencia()
        {
            MdatosSession mdatos = ObtenerObjetoMdatosSessionCache();

            if (mdatos == null)
            {
                return false;
            }

            var pkUsuarioSession = new Dictionary<string, object>
                {
                    { "CCOMPANIA", mdatos.ccompania },
                    { "CUSUARIO", mdatos.cusuario }
                };

            TSEGUSUARIOSESSION usuariosession = serviceUsuarioSession.ObtenerRegistroPorPk(pkUsuarioSession);

            if (usuariosession == null)
            {
                return false;
            }

            if (usuariosession.ACTIVO == "0")
            {
                return false;
            }

            return true;
        }

        protected void GuardarInicioSessionCache(decimal tiemposession, MdatosSession mdatossession)
        {
            CacheItemPolicy politica = new CacheItemPolicy
            {
                AbsoluteExpiration = DateTime.Now.AddMinutes(Convert.ToDouble(tiemposession))
            };

            cache.Add(CACHE_CLAVE_SESSION, mdatossession, politica);
        }

        private MdatosSession ObtenerObjetoMdatosSessionCache()
        {
            // Obtener un objeto de la caché
            MdatosSession valorObtenido = cache.Get(CACHE_CLAVE_SESSION) as MdatosSession;
            if (valorObtenido != null)
            {
                Console.WriteLine("Valor obtenido: " + valorObtenido);
            }
            return valorObtenido;
        }

        protected void RemoverSession()
        {
            // Remover un objeto de la caché
            cache.Remove(CACHE_CLAVE_SESSION);
        }

        /****************************************************************************
         * FIN METODOS DEL CACHE DE SESSION
         ************************************************************************** */

    }
}
