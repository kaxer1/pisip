﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio.Model.Entities;
using UI.Windows.ViewModel;

namespace UI.Windows.AplicationController
{
    public abstract class BaseController<TEntity, T> where TEntity : class
    {

        // Metodo que mapea los datos del ViewModel y los setea en la entidad
        public TEntity mapearEntidad(TEntity entidad, T viewModel)
        {
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
        public List<T> mapearLista(IEnumerable<TEntity> lista)
        {

            List<T> resultadoViewModel = new List<T>();

            
            foreach (TEntity item in lista)
            {
                resultadoViewModel.Add(mapearViewModel(item, (T)Activator.CreateInstance(typeof(T)) ) );
            }
            return resultadoViewModel;
        }

        // Metodo que mapea los datos la entidad y los setea en el viewModel
        public T mapearViewModel(TEntity entidad, T viewModel)
        {
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

        public void validarSoloNumerosTextBox(TextBox textBox)
        {
            textBox.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;  // Ignorar el carácter ingresado
                }
            };
        }

        private void validarSoloLetrasTextBox(TextBox textBox)
        {
            textBox.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;  // Ignorar el carácter ingresado
                }
            };
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
    }
}