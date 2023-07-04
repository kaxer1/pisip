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
    class TGENCanalesController
    {
        private TGENCanalesServices _servicesCanales;
        public TGENCanalesController()
        {
            _servicesCanales = new TGENCanalesServices();
        }






        public bool InsertarCanal(TGENCanalesViewModel nuevoCanalViewModel)
        {
            TGENCANALES nuevoCanal = new TGENCANALES();
            try
            {
                nuevoCanal.CCANAL = nuevoCanalViewModel.CCANAL;
                nuevoCanal.NOMBRE = nuevoCanalViewModel.NOMBRE;
                nuevoCanal.OPTLOCK = nuevoCanalViewModel.OPTLOCK;

                _servicesCanales.InsertarCanales(nuevoCanal);
                return true;



            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Canal" + ex.Message);
            }
        }

        public bool ModificarCanal(TGENCanalesViewModel nuevoCanalViewModel)
        {
            TGENCANALES nuevoCanal = new TGENCANALES();
            try
            {
            
                nuevoCanal.NOMBRE = nuevoCanalViewModel.NOMBRE;
                nuevoCanal.CCANAL = nuevoCanalViewModel.CCANAL;
                _servicesCanales.ActualizarCanales(nuevoCanal);
                return true;



            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar Canal" + ex.Message);
            }
        }


        public IEnumerable<TGENCanalesViewModel> ListarCanales()
        {
            var canalList = _servicesCanales.GetCanales();
            List<TGENCanalesViewModel> listaCanalesViewModel = new List<TGENCanalesViewModel>();

            try
            {
                foreach (var item in canalList)
                {
                    listaCanalesViewModel.Add(new TGENCanalesViewModel
                    {
                        CCANAL = item.CCANAL,
                        NOMBRE = item.NOMBRE,
                        OPTLOCK= item.OPTLOCK
                       
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
