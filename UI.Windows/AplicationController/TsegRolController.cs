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
    internal class TsegRolController : BaseController<TSEGROL, TsegRolViewModel>
    {
        private TsegRolServices serviceRol;
        public TsegRolController()
        {
            serviceRol = new TsegRolServices();
        }

        public bool InsertarRol(TsegRolViewModel nuevoRolViewModel)
        {
            try
            {
                TSEGROL nuevo = mapearViewModelToEntidad(new TSEGROL(), nuevoRolViewModel);
                serviceRol.InsertarRol(nuevo);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Rol" + ex.Message);
            }
        }

        public bool ActualizarRol(TsegRolViewModel nuevoRolViewModel)
        {
            try
            {
                TSEGROL nuevo = mapearViewModelToEntidad(new TSEGROL(), nuevoRolViewModel);
                serviceRol.ActualizarRol(nuevo);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar Rol" + ex.Message);
            }
        }

        public IEnumerable<TsegRolViewModel> ListarRol()
        {
            try
            {
                return mapearIEnumerableToLista(serviceRol.ListarRol());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los Roles" + ex.Message);
            }
        }

        public IEnumerable<TsegRolViewModel> ListarPorFiltro(Dictionary<string, object> filtros)
        {
            try
            {
                return mapearIEnumerableToLista(serviceRol.ObtenerPorFiltro(filtros));
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los Roles" + ex.Message);
            }
        }

    }
}
