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
    public class TsegUsuarioController : BaseController<TSEGUSUARIO, TsegUsuarioViewModel>
    {
        private TsegUsuarioServices serviceUsuario;
        public TsegUsuarioController()
        {
            serviceUsuario = new TsegUsuarioServices();
        }

        public bool InsertarUsuario(TsegUsuarioViewModel nuevoUsuarioViewModel)
        {
            try
            {
                TSEGUSUARIO nuevo = mapearViewModelToEntidad(new TSEGUSUARIO(), nuevoUsuarioViewModel);
                serviceUsuario.InsertarUsuario(nuevo);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Usuario" + ex.Message);
            }
        }

        public bool ActualizarUsuario(TsegUsuarioViewModel nuevoUsuarioViewModel)
        {
            try
            {
                TSEGUSUARIO nuevo = mapearViewModelToEntidad(new TSEGUSUARIO(), nuevoUsuarioViewModel);
                serviceUsuario.ActualizarUsuario(nuevo);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar Usuario" + ex.Message);
            }
        }

        public IEnumerable<TsegUsuarioViewModel> ListarUsuario()
        {
            try
            {
                return mapearIEnumerableToLista(serviceUsuario.ListarUsuario());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los Usuarios" + ex.Message);
            }
        }
    }
}
