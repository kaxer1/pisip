﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicacion.Aplicacion.Services;
using Dominio.Model.Entities;
using UI.Windows.ViewModel;

namespace UI.Windows.AplicationController
{
    public class TgenCompaniaController : BaseController<TGENCOMPANIA, TgenCompaniaViewModel>
    {
        private TgenCompaniaServices serviceCompania;
        public TgenCompaniaController() : base()
        {
            serviceCompania = new TgenCompaniaServices();
        }

        public bool InsertarCompania(TgenCompaniaViewModel nuevoCompaniaViewModel)
        {
            try
            {
                TGENCOMPANIA nuevo = mapearViewModelToEntidad(new TGENCOMPANIA(), nuevoCompaniaViewModel);
                nuevo.OPTLOCK = 0; // valor por defecto al insertar
                serviceCompania.InsertarCompania(nuevo);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Compania" + ex.Message);
            }
        }

        public bool ActualizarCompania(TgenCompaniaViewModel nuevoCompaniaViewModel)
        {
            try
            {
               TGENCOMPANIA nuevo = mapearViewModelToEntidad(new TGENCOMPANIA(), nuevoCompaniaViewModel);
                nuevo.OPTLOCK = nuevo.OPTLOCK + 1;
                serviceCompania.ActualizarCompania(nuevo);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar Compania" + ex.Message);
            }
        }

        public TgenCompaniaViewModel ObtenerRegistroPorPk(Dictionary<string, object> idcompuesto)
        {
            try
            {
                TGENCOMPANIA registro = serviceCompania.ObtenerRegistroPorPk(idcompuesto);
                return mapearEntityToViewModel(registro, new TgenCompaniaViewModel());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar la Compania " + ex.Message);
            }
        }

        public IEnumerable<TgenCompaniaViewModel> ListarCompania()
        {
            try
            {
                return mapearIEnumerableToLista(serviceCompania.ListarCompanias());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los Companias " + ex.Message);
            }
        }

    }
}
