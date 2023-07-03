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
        private TSEGUsuarioSessionHistoriaServices _TSEGUsuarioSessionHistoriaServices;
        public TSEGUsuarioSessionHistoriaController()
        {
            _TSEGUsuarioSessionHistoriaServices = new TSEGUsuarioSessionHistoriaServices();
        }






        public bool InsertarCanal(TSEGUsuarioSessionHistoriaViewModel nuevoCanalViewModel)
        {
            TSEGUSUARIOSESSIONHISTORIA nuevo = new TSEGUSUARIOSESSIONHISTORIA();
            try
            {
                nuevo.CUSUARIO = nuevoCanalViewModel.CUSUARIO;
                nuevo.CCOMPANIA = nuevoCanalViewModel.CCOMPANIA;
                nuevo.FCREACION = nuevoCanalViewModel.FCREACION;
                nuevo.NUMEROINTENTOS = nuevoCanalViewModel.NUMEROINTENTOS;
                nuevo.IDSESSION = nuevoCanalViewModel.IDSESSION;
                nuevo.FINICIO = nuevoCanalViewModel.FINICIO;
                nuevo.FSALIDA = nuevoCanalViewModel.FSALIDA;
                nuevo.ACTIVO = nuevoCanalViewModel.ACTIVO;
                nuevo.TIEMPOSESION = nuevoCanalViewModel.TIEMPOSESION;
                nuevo.FULTIMAACCION = nuevoCanalViewModel.FULTIMAACCION;
                nuevo.CESTADO = nuevoCanalViewModel.CESTADO;
                nuevo.USERAGENT = nuevoCanalViewModel.USERAGENT;
                nuevo.CTERMINALREMOTO = nuevoCanalViewModel.CTERMINALREMOTO;

                _TSEGUsuarioSessionHistoriaServices.InsertarUsuarioSessionHistory(nuevo);
                return true;



            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Canal" + ex.Message);
            }
        }

        public bool ModificarCanal(TSEGUsuarioSessionHistoriaViewModel nuevoCanalViewModel)
        {
            TSEGUSUARIOSESSIONHISTORIA nuevo = new TSEGUSUARIOSESSIONHISTORIA();
            try
            {

                nuevo.CUSUARIO = nuevoCanalViewModel.CUSUARIO;
                nuevo.CCOMPANIA = nuevoCanalViewModel.CCOMPANIA;
                nuevo.FCREACION = nuevoCanalViewModel.FCREACION;
                nuevo.NUMEROINTENTOS = nuevoCanalViewModel.NUMEROINTENTOS;
                nuevo.IDSESSION = nuevoCanalViewModel.IDSESSION;
                nuevo.FINICIO = nuevoCanalViewModel.FINICIO;
                nuevo.FSALIDA = nuevoCanalViewModel.FSALIDA;
                nuevo.ACTIVO = nuevoCanalViewModel.ACTIVO;
                nuevo.TIEMPOSESION = nuevoCanalViewModel.TIEMPOSESION;
                nuevo.FULTIMAACCION = nuevoCanalViewModel.FULTIMAACCION;
                nuevo.CESTADO = nuevoCanalViewModel.CESTADO;
                nuevo.USERAGENT = nuevoCanalViewModel.USERAGENT;
                nuevo.CTERMINALREMOTO = nuevoCanalViewModel.CTERMINALREMOTO;
                _TSEGUsuarioSessionHistoriaServices.ActualizarUsuarioSessionHistory(nuevo);
                return true;



            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar Canal" + ex.Message);
            }
        }


        public IEnumerable<TSEGUsuarioSessionHistoriaViewModel> ListarCanales()
        {
            var canalList = _TSEGUsuarioSessionHistoriaServices.GetUsuarioSessionHistory();
            List<TSEGUsuarioSessionHistoriaViewModel> listaCanalesViewModel = new List<TSEGUsuarioSessionHistoriaViewModel>();

            try
            {
                foreach (var item in canalList)
                {
                    listaCanalesViewModel.Add(new TSEGUsuarioSessionHistoriaViewModel
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
                throw new Exception("Error al obtener Canales " + ex.Message);
            }




        }



    }
}
