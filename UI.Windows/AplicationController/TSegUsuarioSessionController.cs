using Aplicacion.Aplicacion.Services;
using Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Windows.ViewModel;

namespace UI.Windows.AplicationController
{
   public class TSegUsuarioSessionController
    {
        private TSegUsuarioSessionServices servicesUsuarioSession;
        private TSegUsuarioSessionViewModel nuevoUsuarioSessionViewModel;

        public TSegUsuarioSessionController()
        {
            servicesUsuarioSession = new TSegUsuarioSessionServices();
        }

        public bool InsertarUsuario(TSegUsuarioSessionViewModel nuevoUsuarioSessionViewModel)
        {
            try
            {
                TSEGUSUARIOSESSION nuevo = MapearEntidad(new TSEGUSUARIOSESSION(), nuevoUsuarioSessionViewModel);
                servicesUsuarioSession.InsertarUsuarioSession(nuevo);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Sección de Usuario" + ex.Message);
            }
        }

        private TSEGUSUARIOSESSION MapearEntidad(TSEGUSUARIOSESSION tSEGUSUARIOSESSION, TSegUsuarioSessionViewModel nuevoUsuarioSessionViewModel)
        {
            throw new NotImplementedException();
        }

        public bool ActualizarUsuario(TSegUsuarioSessionViewModel nuevoUsuarioViewModel)
        {
            try
            {
                TSEGUSUARIOSESSION nuevo = MapearEntidad(new TSEGUSUARIOSESSION(), nuevoUsuarioSessionViewModel);
                servicesUsuarioSession.ActualizarUsuario(nuevo);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar Sección de Usuario" + ex.Message);
            }
        }

        private TSEGUSUARIOSESSION mapearEntidad(TSEGUSUARIOSESSION tSEGUSUARIOSESSION, object nuevoUsuarioSessionViewModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TSegUsuarioSessionViewModel> ListarUsuario()
        {
            try
            {
                return mapearLista(servicesUsuarioSession.ListarUsuario());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar Sección de Usuarios" + ex.Message);
            }
        }

        private IEnumerable<TSegUsuarioSessionViewModel> mapearLista(object p)
        {
            throw new NotImplementedException();
        }
    }

}