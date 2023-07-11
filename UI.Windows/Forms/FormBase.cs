using System;
using System.Collections.Generic;
using System.Runtime.Caching;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Aplicacion.Aplicacion.Services;
using Dominio.Model.Entities;
using UI.Windows.AplicationController;
using UI.Windows.ViewModel;
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
        
        private TsegPoliticaController controllerPolitica;
        protected TsegPoliticaViewModel viewModelPolitica;
        
        private static string CACHE_CLAVE_SESSION = "mdatossession";

        public FormBase() {
            serviceUsuarioSession = new TsegUsuarioSessionServices();
            controllerPolitica = new TsegPoliticaController();
        }

        /****************************************************************************
         * 
         * INICIO METODOS DE VALIDACION DE INPUTS EN FORMULARIOS
         * 
         ****************************************************************************/
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
         * FIN METODOS DE VALIDACION DE INPUTS EN FORMULARIOS
         ****************************************************************************/

        /****************************************************************************
         * 
         * INICIO METODOS DEL CONTADOR
         * 
         ****************************************************************************/
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
         ****************************************************************************/

        /****************************************************************************
         * 
         * INICIO METODOS DEL CACHE DE SESSION
         * 
         ****************************************************************************/
        protected bool ejecutaSentencia()
        {
            if (!ValidarSentencia())
            {
                formularioHijo.Close();
                MessageBox.Show("LA SESION A SIDO DESACTIVADA, EL PROGRAMA SE CERRARA");
                Application.Exit();
                return false;
            }
            return true;
        }

        private bool ValidarSentencia()
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
            CacheItemPolicy politicaCache = new CacheItemPolicy
            {
                AbsoluteExpiration = DateTime.Now.AddMinutes(Convert.ToDouble(tiemposession))
            };

            cache.Add(CACHE_CLAVE_SESSION, mdatossession, politicaCache);
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
         ****************************************************************************/

        /****************************************************************************
         * 
         * INICIO METODOS DE VALIDACION PASSWORD
         * 
         ****************************************************************************/
        protected void AlmacenarPolitica(decimal ccompania)
        {
            var pkpolitica = new Dictionary<string, object>
                {
                    { "CCOMPANIA", ccompania},
                    { "CCANAL",  ccanal}
                };
            viewModelPolitica = controllerPolitica.ObtenerRegistroPorPk(pkpolitica);
            if (viewModelPolitica == null)
            {
                MessageBox.Show("NO EXISTE POLÍTICA PARA ESTE CANAL Y COMPAÑIA");
            }
        }

        protected void VerificarPoliticasPassword(string password, out bool longitud, out bool especiales, out bool numeros, out bool mayusculas, out bool minusculas)
        {
            longitud = VerificarLongitud(password);
            especiales = VerificarCaracteresEspeciales(password);
            numeros = VerificarNumeros(password);
            mayusculas = VerificarMayusculas(password);
            minusculas = VerificarMinusculas(password);

            if (longitud && especiales && numeros && mayusculas && minusculas)
            {
                Console.WriteLine("La contraseña cumple con los requisitos.");
            }
            else
            {
                Console.WriteLine("La contraseña no cumple con los requisitos.");
            }
        }

        private bool VerificarLongitud(string password)
        {
            return password.Length >= viewModelPolitica.LONGITUD;
        }

        private bool VerificarCaracteresEspeciales(string password)
        {
            // Expresión regular para verificar caracteres especiales
            Regex regex = new Regex(@"[^a-zA-Z0-9]");
            MatchCollection matches = regex.Matches(password);
            return matches.Count >= viewModelPolitica.ESPECIALES;
        }

        private bool VerificarNumeros(string password)
        {
            // Expresión regular para verificar numeros
            Regex regex = new Regex(@"[0-9]");
            MatchCollection matches = regex.Matches(password);
            return matches.Count >= viewModelPolitica.NUMEROS;
        }

        private bool VerificarMayusculas(string password)
        {
            // Expresión regular para verificar mayúsculas
            Regex regex = new Regex(@"[A-Z]");
            MatchCollection matches = regex.Matches(password);
            return matches.Count >= viewModelPolitica.MAYUSCULAS;
        }

        private bool VerificarMinusculas(string password)
        {
            // Expresión regular para verificar minusculas
            Regex regex = new Regex(@"[a-z]");
            MatchCollection matches = regex.Matches(password);
            return matches.Count >= viewModelPolitica.MINUSCULAS;
        }

        protected bool ValidaPasswordRepeticiones(int count)
        {
            return count <= Convert.ToInt32(viewModelPolitica.REPETICIONES);
        }

        protected bool ValidaIntentosLogin(int count)
        {
            return count > Convert.ToInt32(viewModelPolitica.INTENTOS);
        }

        /****************************************************************************
         * FIN METODOS DE VALIDACION PASSWORD
         ****************************************************************************/
    }
}
