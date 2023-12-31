﻿using Aplicacion.Aplicacion.Services;
using Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Windows.ViewModel;

namespace UI.Windows.AplicationController
{
    public class TgenCanalesController : BaseController<TGENCANALES, TgenCanalesViewModel>
    {
        private TgenCanalesServices _servicesCanales;
        public TgenCanalesController() : base()
        {
            _servicesCanales = new TgenCanalesServices();
        }

        public bool InsertarCanal(TgenCanalesViewModel nuevoCanalViewModel)
        {
            TGENCANALES nuevoCanal = new TGENCANALES();
            try
            {
                nuevoCanal.CCANAL = nuevoCanalViewModel.CCANAL;
                nuevoCanal.NOMBRE = nuevoCanalViewModel.NOMBRE;
                nuevoCanal.OPTLOCK = 0;

                _servicesCanales.InsertarCanales(nuevoCanal);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Canal" + ex.Message);
            }
        }

        public bool ModificarCanal(TgenCanalesViewModel nuevoCanalViewModel)
        {
            TGENCANALES nuevoCanal = new TGENCANALES();
            try
            {
                nuevoCanal.NOMBRE = nuevoCanalViewModel.NOMBRE;
                nuevoCanal.CCANAL = nuevoCanalViewModel.CCANAL;
                nuevoCanal.OPTLOCK = nuevoCanalViewModel.OPTLOCK + 1;
                _servicesCanales.ActualizarCanales(nuevoCanal);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar Canal" + ex.Message);
            }
        }

        public IEnumerable<TgenCanalesViewModel> ListarCanales()
        {
            var canalList = _servicesCanales.GetCanales();
            List<TgenCanalesViewModel> listaCanalesViewModel = new List<TgenCanalesViewModel>();

            try
            {
                foreach (var item in canalList)
                {
                    listaCanalesViewModel.Add(new TgenCanalesViewModel
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

        public TgenCanalesViewModel ObtenerRegistroPorPk(Dictionary<string, object> idcompuesto)
        {
            try
            {
                TGENCANALES registro = _servicesCanales.ObtenerRegistroPorPk(idcompuesto);
                return mapearEntityToViewModel(registro, new TgenCanalesViewModel());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar las Sessiones de Usuario" + ex.Message);
            }
        }

    }
}
