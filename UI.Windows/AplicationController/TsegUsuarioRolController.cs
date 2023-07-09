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
    public class TsegUsuarioRolController : BaseController<TSEGUSUARIOROL, TsegUsuarioRolViewModel>
    {
        private TsegUsuarioRolServices serviceUsuarioRol;
        public TsegUsuarioRolController()
        {
            serviceUsuarioRol = new TsegUsuarioRolServices();
        }

        public bool InsertarUsuarioRol(TsegUsuarioRolViewModel nuevoUsuarioRolViewModel)
        {
            try
            {
                TSEGUSUARIOROL nuevo = mapearViewModelToEntidad(new TSEGUSUARIOROL(), nuevoUsuarioRolViewModel);
                nuevo.FINGRESO = DateTime.Now;
                serviceUsuarioRol.InsertarUsuarioRol(nuevo);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Usuario Rol" + ex.Message);
            }
        }

        public bool ActualizarUsuarioRol(TsegUsuarioRolViewModel nuevoUsuarioRolViewModel)
        {
            try
            {
                TSEGUSUARIOROL nuevo = mapearViewModelToEntidad(new TSEGUSUARIOROL(), nuevoUsuarioRolViewModel);
                nuevo.FMODIFICACION = DateTime.Now;
                serviceUsuarioRol.ActualizarUsuarioRol(nuevo);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar Usuario Rol" + ex.Message);
            }
        }

        public IEnumerable<TsegUsuarioRolViewModel> ListarUsuarioRol()
        {
            try
            {
                return mapearIEnumerableToLista(serviceUsuarioRol.ListarUsuarioRol());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los Usuarios Rol" + ex.Message);
            }
        }

    }
}
