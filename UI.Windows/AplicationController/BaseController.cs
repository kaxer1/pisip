using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Caching;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio.Model.Entities;
using UI.Windows.ViewModel;

namespace UI.Windows.AplicationController
{
    public class MdatosSession
    {
        public string cusuario { get; set; }
        public string ccanal { get; set; }
        public decimal crol { get; set; }
        public decimal ccompania { get; set; }

    }
    public class ComboBoxSelectItem
    {
        // nombre que aparece en el combo
        public string label { get; set; }

        // valor del ID o PK
        public string value { get; set; }
    }

    public abstract class BaseController<TEntity, T> where TEntity : class
    {
        private static string CACHE_CLAVE_SESSION = "mdatossession";

        private static MemoryCache cache = MemoryCache.Default;

        public MdatosSession mdatosUsuario;

        protected BaseController()
        {
            mdatosUsuario = ObtenerObjetoMdatosSessionCache();
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

        // Metodo que mapea los datos del ViewModel y los setea en la entidad
        public TEntity mapearViewModelToEntidad(TEntity entidad, T viewModel)
        {
            if (viewModel == null)
            {
                return null;
            }
            // Estrae los campos del View Model
            PropertyInfo[] camposViewModel = typeof(T).GetProperties();

            foreach (PropertyInfo campoVM in camposViewModel)
            {
                // Obtener el valor del campo del View Model
                object valorCampo = campoVM.GetValue(viewModel);

                // Obtener el campo correspondiente a la entidad
                PropertyInfo campoEntidad = typeof(TEntity).GetProperty(campoVM.Name);

                // Establecer el valor del campo del View Model en la instancia de la entidad por el campo de la entidad
                campoEntidad.SetValue(entidad, valorCampo);
            }
            return entidad;
        }

        // Metodo que mapea la lista del que devuelve el servicio y devuelve con el tipo de dato del View Model
        public List<T> mapearIEnumerableToLista(IEnumerable<TEntity> lista)
        {

            List<T> resultadoViewModel = new List<T>();

            if (lista == null)
            {
                resultadoViewModel = null;
                return resultadoViewModel;
            }
            
            foreach (TEntity item in lista)
            {
                resultadoViewModel.Add(mapearEntityToViewModel(item, (T)Activator.CreateInstance(typeof(T)) ) );
            }
            return resultadoViewModel;
        }

        // Metodo que mapea los datos la entidad y los setea en el viewModel
        public T mapearEntityToViewModel(TEntity entidad, T viewModel)
        {
            if (entidad == null)
            {
                return default(T);
            }
            // Estrae los campos de la entidad
            PropertyInfo[] camposEntidad = typeof(TEntity).GetProperties();

            foreach (PropertyInfo campoE in camposEntidad)
            {
                // TODO. validar que funcione con virtual ICollection
                if (!campoE.Name.Contains("TSEG") && !campoE.Name.Contains("TGEN"))
                {
                    // Obtener el valor del campo de la Endidad
                    object valorCampo = campoE.GetValue(entidad);

                    // Obtener el campo correspondiente al View Model
                    PropertyInfo campoViewModel = typeof(T).GetProperty(campoE.Name);

                    // Establecer el valor del campo de la Entidad a la instancia del View Model por el campo del View Model
                    campoViewModel.SetValue(viewModel, valorCampo);
                }
            }
            return viewModel;
        }

        // Metodo que mapea los datos la entidad y los setea en la entidad de historia de su tabla
        public object mapearEntityToEntityHistoria(TEntity entidad, Type entidadHistoria)
        {
            if (entidad == null)
            {
                return null;
            }

            object instancia = Activator.CreateInstance(entidadHistoria);

            // Estrae los campos de la entidad
            PropertyInfo[] camposEntidad = typeof(TEntity).GetProperties();

            foreach (PropertyInfo campoE in camposEntidad)
            {
                // TODO. validar que funcione con virtual ICollection
                if (!campoE.Name.Contains("TSEG") && !campoE.Name.Contains("TGEN"))
                {
                    // Obtener el valor del campo de la Endidad
                    object valorCampo = campoE.GetValue(entidad);

                    // Obtener el campo correspondiente al View Model
                    PropertyInfo campoEntidadHistoria = entidadHistoria.GetProperty(campoE.Name);

                    // Establecer el valor del campo de la Entidad a la instancia del View Model por el campo del View Model
                    campoEntidadHistoria.SetValue( instancia, valorCampo);
                }
            }
            return instancia;
        }

        public string EncryptPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashedBytes = sha256.ComputeHash(passwordBytes);

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }

        // Metodo que mapea la lista del que devuelve el servicio y lo transforma en una lista de tipo ComboBoxSelectItem
        public IEnumerable<ComboBoxSelectItem> mapearComboBox(IEnumerable<T> lista, string campoId, string campoNombre)
        {
            List<ComboBoxSelectItem> resultadoComboBox = new List<ComboBoxSelectItem>();

            if (lista == null)
            {
                resultadoComboBox = null;
                return resultadoComboBox;
            }

            foreach (T item in lista)
            {
                ComboBoxSelectItem combo = new ComboBoxSelectItem();
                // Estrae los campos del View Model
                PropertyInfo[] camposViewModel = typeof(T).GetProperties();

                foreach (PropertyInfo campoVM in camposViewModel)
                {
                    if (campoVM.Name == campoId && campoVM.Name == campoNombre)
                    {
                        object valorCampo = campoVM.GetValue(item);
                        combo.value = valorCampo.ToString();
                        combo.label = valorCampo.ToString();
                        continue;
                    }
                    if (campoVM.Name == campoId)
                    {
                        object valorCampo = campoVM.GetValue(item);
                        combo.value = valorCampo.ToString();
                        continue;
                    }
                    if (campoVM.Name == campoNombre)
                    {
                        object valorCampo = campoVM.GetValue(item);
                        combo.label = valorCampo.ToString();
                        continue;
                    }
                }
                resultadoComboBox.Add(combo);
            }
            return resultadoComboBox;
        }
    }
}