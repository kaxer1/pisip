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
    public class TSEGUsuarioSessionHistoriaController
    {
        private TsegUsuarioSessionHistoriaServices _TsegUsuarioSessionHistoriaServices;
        public TSEGUsuarioSessionHistoriaController()
        {
            _TsegUsuarioSessionHistoriaServices = new TsegUsuarioSessionHistoriaServices();
        }

        public bool InsertarUsuarioSessionHistoria(TsegUsuarioSessionHistoriaViewModel nuevoSessionHistoriaViewModel)
        {
            TSEGUSUARIOSESSIONHISTORIA nuevo = new TSEGUSUARIOSESSIONHISTORIA();
            try
            {
                nuevo.CUSUARIO = nuevoSessionHistoriaViewModel.CUSUARIO;
                nuevo.CCOMPANIA = nuevoSessionHistoriaViewModel.CCOMPANIA;
                nuevo.FCREACION = nuevoSessionHistoriaViewModel.FCREACION;
                nuevo.NUMEROINTENTOS = nuevoSessionHistoriaViewModel.NUMEROINTENTOS;
                nuevo.IDSESSION = nuevoSessionHistoriaViewModel.IDSESSION;
                nuevo.FINICIO = nuevoSessionHistoriaViewModel.FINICIO;
                nuevo.FSALIDA = nuevoSessionHistoriaViewModel.FSALIDA;
                nuevo.ACTIVO = nuevoSessionHistoriaViewModel.ACTIVO;
                nuevo.TIEMPOSESION = nuevoSessionHistoriaViewModel.TIEMPOSESION;
                nuevo.FULTIMAACCION = nuevoSessionHistoriaViewModel.FULTIMAACCION;
                nuevo.CESTADO = nuevoSessionHistoriaViewModel.CESTADO;
                nuevo.USERAGENT = nuevoSessionHistoriaViewModel.USERAGENT;
                nuevo.CTERMINALREMOTO = nuevoSessionHistoriaViewModel.CTERMINALREMOTO;

                _TsegUsuarioSessionHistoriaServices.InsertarUsuarioSessionHistory(nuevo);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Usuario Session Historia" + ex.Message);
            }
        }

        public bool ModificarUsuarioSessionHistoria(TsegUsuarioSessionHistoriaViewModel nuevoSessionHistoriaViewModel)
        {
            TSEGUSUARIOSESSIONHISTORIA nuevo = new TSEGUSUARIOSESSIONHISTORIA();
            try
            {

                nuevo.CUSUARIO = nuevoSessionHistoriaViewModel.CUSUARIO;
                nuevo.CCOMPANIA = nuevoSessionHistoriaViewModel.CCOMPANIA;
                nuevo.FCREACION = nuevoSessionHistoriaViewModel.FCREACION;
                nuevo.NUMEROINTENTOS = nuevoSessionHistoriaViewModel.NUMEROINTENTOS;
                nuevo.IDSESSION = nuevoSessionHistoriaViewModel.IDSESSION;
                nuevo.FINICIO = nuevoSessionHistoriaViewModel.FINICIO;
                nuevo.FSALIDA = nuevoSessionHistoriaViewModel.FSALIDA;
                nuevo.ACTIVO = nuevoSessionHistoriaViewModel.ACTIVO;
                nuevo.TIEMPOSESION = nuevoSessionHistoriaViewModel.TIEMPOSESION;
                nuevo.FULTIMAACCION = nuevoSessionHistoriaViewModel.FULTIMAACCION;
                nuevo.CESTADO = nuevoSessionHistoriaViewModel.CESTADO;
                nuevo.USERAGENT = nuevoSessionHistoriaViewModel.USERAGENT;
                nuevo.CTERMINALREMOTO = nuevoSessionHistoriaViewModel.CTERMINALREMOTO;
                _TsegUsuarioSessionHistoriaServices.ActualizarUsuarioSessionHistory(nuevo);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar Usuario Session Historia" + ex.Message);
            }
        }


        public IEnumerable<TsegUsuarioSessionHistoriaViewModel> ListarUsuarioSessionHistoria()
        {
            var canalList = _TsegUsuarioSessionHistoriaServices.GetUsuarioSessionHistory();
            List<TsegUsuarioSessionHistoriaViewModel> listaCanalesViewModel = new List<TsegUsuarioSessionHistoriaViewModel>();

            try
            {
                foreach (var item in canalList)
                {
                    listaCanalesViewModel.Add(new TsegUsuarioSessionHistoriaViewModel
                    {
                    CUSUARIO = item.CUSUARIO,
                    CCOMPANIA = item.CCOMPANIA,
                    FCREACION = item.FCREACION,
                    NUMEROINTENTOS = item.NUMEROINTENTOS,
                    IDSESSION = item.IDSESSION,
                    FINICIO = item.FINICIO,
                    FSALIDA = item.FSALIDA,
                    ACTIVO = item.ACTIVO,
                    TIEMPOSESION = item.TIEMPOSESION,
                    FULTIMAACCION = item.FULTIMAACCION,
                    CESTADO = item.CESTADO,
                    USERAGENT = item.USERAGENT,
                    CTERMINALREMOTO = item.CTERMINALREMOTO,

                });
                }
                return listaCanalesViewModel;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener Usuario Session Historia " + ex.Message);
            }
        }
    }
}
