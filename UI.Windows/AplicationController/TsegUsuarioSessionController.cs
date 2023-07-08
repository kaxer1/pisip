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
    public class TsegUsuarioSessionController : BaseController<TSEGUSUARIOSESSION, TsegUsuarioSessionViewModel>
    {
        private TsegUsuarioSessionServices serviceUsuarioSession;
        private TsegUsuarioSessionHistoriaServices serviceUsuarioSessionHistoria;
        public TsegUsuarioSessionController()
        {
            serviceUsuarioSession = new TsegUsuarioSessionServices();
            serviceUsuarioSessionHistoria = new TsegUsuarioSessionHistoriaServices();
        }

        public bool InsertarUsuarioSession(TsegUsuarioSessionViewModel nuevoUsuarioSessionViewModel)
        {
            try
            {
                TSEGUSUARIOSESSION nuevo = mapearViewModelToEntidad(new TSEGUSUARIOSESSION(), nuevoUsuarioSessionViewModel);
                nuevo.FINICIO = DateTime.Now;
                serviceUsuarioSession.InsertarUsuarioSession(nuevo);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar la Session de Usuario" + ex.Message);
            }
        }

        public bool ActualizarUsuarioSession(TsegUsuarioSessionViewModel nuevoUsuarioSessionViewModel)
        {
            try
            {
                TSEGUSUARIOSESSION nuevo = mapearViewModelToEntidad(new TSEGUSUARIOSESSION(), nuevoUsuarioSessionViewModel);
                serviceUsuarioSession.ActualizarUsuarioSession(nuevo);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la Session de Usuario" + ex.Message);
            }
        }

        public IEnumerable<TsegUsuarioSessionViewModel> ListarUsuarioSession()
        {
            try
            {
                return mapearIEnumerableToLista(serviceUsuarioSession.ListarUsuarioSession());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar las Sessiones de Usuario" + ex.Message);
            }
        }

        public IEnumerable<TsegUsuarioSessionViewModel> ListarUsuarioSessionesActivas()
        {
            try
            {
                return mapearIEnumerableToLista(serviceUsuarioSession.listarSessionesActivas());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar las Sessiones de Usuario" + ex.Message);
            }
        }

        public TsegUsuarioSessionViewModel ObtenerRegistroPorPk(Dictionary<string, object> idcompuesto) 
        {
            try
            {
                TSEGUSUARIOSESSION registro = serviceUsuarioSession.ObtenerRegistroPorPk(idcompuesto);
                return mapearEntityToViewModel(registro, new TsegUsuarioSessionViewModel() );
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar las Sessiones de Usuario" + ex.Message);
            }
        }

        public void InsertarHistorial (TsegUsuarioSessionViewModel registro)
        {
            TSEGUSUARIOSESSION original = mapearViewModelToEntidad(new TSEGUSUARIOSESSION(), registro);
            TSEGUSUARIOSESSIONHISTORIA historia = (TSEGUSUARIOSESSIONHISTORIA) mapearEntityToEntityHistoria(original, typeof(TSEGUSUARIOSESSIONHISTORIA) );
            historia.FCREACION = DateTime.Now;
            serviceUsuarioSessionHistoria.InsertarUsuarioSessionHistory(historia);
        }
    }
}
