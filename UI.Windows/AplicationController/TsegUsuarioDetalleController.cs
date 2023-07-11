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
        private TsegUsuarioDetalleHistServices serviceUsuarioDetalleHist;
        public TsegUsuarioDetalleController() : base()
        {
            serviceUsuarioDetalle = new TsegUsuarioDetalleServices();
            serviceUsuarioDetalleHist = new TsegUsuarioDetalleHistServices();
        }

        public bool InsertarUsuarioDetalle(TsegUsuarioDetalleViewModel nuevoUsuarioDetalleViewModel)
        {
            try
            {
                TSEGUSUARIODETALLE nuevo = mapearViewModelToEntidad(new TSEGUSUARIODETALLE(), nuevoUsuarioDetalleViewModel);
                nuevo.OPTLOCK = 0; // valor por defecto al insertar
                nuevo.CAMBIOPASSWORD = "0"; // por defecto no hace cambios de password cuando ingresa
                nuevo.CUSUARIOING = mdatosUsuario.cusuario;
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
                TSEGUSUARIODETALLE nuevo = mapearViewModelToEntidad(new TSEGUSUARIODETALLE(), nuevoUsuarioDetalleViewModel);
                nuevo.OPTLOCK = nuevo.OPTLOCK + 1;
                nuevo.CUSUARIOMOD = mdatosUsuario.cusuario;
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
                return mapearIEnumerableToLista(serviceUsuarioDetalle.ListarUsuarioDetalle());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los Usuarios Detalles" + ex.Message);
            }
        }

        public TsegUsuarioDetalleViewModel Login(string usuario, string contrasenia, decimal ccompania, string ccanal, decimal crol)
        {
            return mapearEntityToViewModel( serviceUsuarioDetalle.IniciarSession(usuario, contrasenia, ccompania, ccanal, crol), new TsegUsuarioDetalleViewModel() );
        }

        public TsegUsuarioDetalleViewModel ObtenerRegistroPorPk(Dictionary<string, object> idcompuesto)
        {
            try
            {
                TSEGUSUARIODETALLE registro = serviceUsuarioDetalle.ObtenerRegistroPorPk(idcompuesto);
                return mapearEntityToViewModel(registro, new TsegUsuarioDetalleViewModel());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar las Sessiones de Usuario" + ex.Message);
            }
        }

        public TsegUsuarioDetalleViewModel ValidaUsuarioExiste(string usuario, string contrasenia, decimal ccompania, string ccanal, decimal crol)
        {
            return mapearEntityToViewModel(serviceUsuarioDetalle.ValidaUsuarioRolExiste(usuario, contrasenia, ccompania, ccanal, crol), new TsegUsuarioDetalleViewModel());
        }

        public void InsertarHistorial(TsegUsuarioDetalleViewModel registro)
        {
            TSEGUSUARIODETALLE original = mapearViewModelToEntidad(new TSEGUSUARIODETALLE(), registro);
            TSEGUSUARIODETALLEHIST historia = (TSEGUSUARIODETALLEHIST)mapearEntityToEntityHistoria(original, typeof(TSEGUSUARIODETALLEHIST));
            historia.FHISTORIA = DateTime.Now;
            serviceUsuarioDetalleHist.InsertarUsuarioDetalleHist(historia);
        }
    }
}
