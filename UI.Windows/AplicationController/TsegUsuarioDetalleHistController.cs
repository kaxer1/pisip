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
    public class TsegUsuarioDetalleHistController : BaseController<TSEGUSUARIODETALLEHIST, TsegUsuarioDetalleHistViewModel>
    {
        private TsegUsuarioDetalleHistServices serviceUsuarioDetalleHist;
        public TsegUsuarioDetalleHistController() : base()
        {
            serviceUsuarioDetalleHist = new TsegUsuarioDetalleHistServices();
        }

        public bool InsertarUsuarioDetalleHist(TsegUsuarioDetalleHistViewModel nuevoUsuarioDetalleHistViewModel)
        {
            try
            {
                TSEGUSUARIODETALLEHIST nuevo = mapearViewModelToEntidad(new TSEGUSUARIODETALLEHIST(), nuevoUsuarioDetalleHistViewModel);
                nuevo.OPTLOCK = 0; // valor por defecto al insertar
                nuevo.CAMBIOPASSWORD = "0"; // por defecto no hace cambios de password cuando ingresa
                nuevo.FINGRESO = DateTime.Now;
                serviceUsuarioDetalleHist.InsertarUsuarioDetalleHist(nuevo);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Usuario Detalle Historia" + ex.Message);
            }
        }

        public bool ActualizarUsuarioDetalleHist(TsegUsuarioDetalleHistViewModel nuevoUsuarioDetalleHistViewModel)
        {
            try
            {
                TSEGUSUARIODETALLEHIST nuevo = mapearViewModelToEntidad(new TSEGUSUARIODETALLEHIST(), nuevoUsuarioDetalleHistViewModel);
                nuevo.FMODIFICACION = DateTime.Now;
                serviceUsuarioDetalleHist.ActualizarUsuarioDetalleHist(nuevo);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar Usuario Detalle Historia" + ex.Message);
            }
        }

        public IEnumerable<TsegUsuarioDetalleHistViewModel> ListarUsuarioDetalleHist()
        {
            try
            {
                return mapearIEnumerableToLista(serviceUsuarioDetalleHist.ListarUsuarioDetalleHist());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los Usuarios Detalle Historia" + ex.Message);
            }
        }

        public IEnumerable<TsegUsuarioDetalleHistViewModel> ListarPorFiltro(Dictionary<string, object> filtros)
        {
            try
            {
                return mapearIEnumerableToLista(serviceUsuarioDetalleHist.ObtenerPorFiltro(filtros));
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los Detalles Historicos del Usuario" + ex.Message);
            }
        }
    }
}
