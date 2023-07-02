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
    public class TsegUsuarioDetalleController : BaseController<TSEGUSUARIODETALLE, TsegUsuarioDetalleViewModel>
    {
        private TsegUsuarioDetalleServices serviceUsuarioDetalle;
        public TsegUsuarioDetalleController()
        {
            serviceUsuarioDetalle = new TsegUsuarioDetalleServices();
        }

        public bool InsertarUsuarioDetalle(TsegUsuarioDetalleViewModel nuevoUsuarioDetalleViewModel)
        {
            try
            {
                TSEGUSUARIODETALLE nuevo = mapearEntidad(new TSEGUSUARIODETALLE(), nuevoUsuarioDetalleViewModel);
                nuevo.OPTLOCK = 0; // valor por defecto al insertar
                nuevo.CAMBIOPASSWORD = "0"; // por defecto no hace cambios de password cuando ingresa
                nuevo.FINGRESO = DateTime.Now;
                serviceUsuarioDetalle.InsertarUsuarioDetalle(nuevo);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Usuario Detalle" + ex.Message);
            }
        }

        public bool ActualizarUsuarioDetalle(TsegUsuarioDetalleViewModel nuevoUsuarioDetalleViewModel)
        {
            try
            {
                TSEGUSUARIODETALLE nuevo = mapearEntidad(new TSEGUSUARIODETALLE(), nuevoUsuarioDetalleViewModel);
                nuevo.FMODIFICACION = DateTime.Now;
                serviceUsuarioDetalle.ActualizarUsuarioDetalle(nuevo);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar Usuario Detalle" + ex.Message);
            }
        }

        public IEnumerable<TsegUsuarioDetalleViewModel> ListarUsuarioDetalle()
        {
            try
            {
                return mapearLista(serviceUsuarioDetalle.ListarUsuarioDetalle());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los Usuarios Detalles" + ex.Message);
            }
        }
    }
}
