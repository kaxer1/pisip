using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicacion.Aplicacion.Services;
using Dominio.Model.Entities;
using UI.Windows.ViewModel;

namespace UI.Windows.AplicationController
{
    internal class TsegPoliticaController : BaseController<TSEGPOLITICA, TsegPoliticaViewModel>
    {
        private TsegPoliticaServices servicePolitica;

        public TsegPoliticaController()
        {
            servicePolitica = new TsegPoliticaServices();
        }

        public bool InsertarPolitica(TsegPoliticaViewModel nuevoPoliticaViewModel)
        {
            try
            {
                TSEGPOLITICA nuevo = mapearViewModelToEntidad(new TSEGPOLITICA(), nuevoPoliticaViewModel);
                servicePolitica.InsertarPoliticas(nuevo);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar la Politica" + ex.Message);
            }
        }

        public bool ActualizarPolitica(TsegPoliticaViewModel nuevoPoliticaViewModel)
        {
            try
            {
                TSEGPOLITICA nuevo = mapearViewModelToEntidad(new TSEGPOLITICA(), nuevoPoliticaViewModel);
                servicePolitica.ActualizarPoliticas(nuevo);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la Politica" + ex.Message);
            }
        }

        public IEnumerable<TsegPoliticaViewModel> ListarPolitica()
        {
            try
            {
                return mapearIEnumerableToLista(servicePolitica.GetPoliticas());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar las Politicas" + ex.Message);
            }
        }

      

        public TsegPoliticaViewModel ObtenerRegistroPorPk(Dictionary<string, object> idcompuesto)
        {
            try
            {
                TSEGPOLITICA registro = servicePolitica.ObtenerRegistroPorPk(idcompuesto);
                return mapearEntityToViewModel(registro, new TsegPoliticaViewModel());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener registro por pk compuesto" + ex.Message);
            }
        }
    }
}
