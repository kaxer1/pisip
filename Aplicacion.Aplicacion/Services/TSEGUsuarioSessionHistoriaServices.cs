﻿using Dominio.Model.Entities;
using Infra.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Aplicacion.Services
{
    public class TSEGUsuarioSessionHistoriaServices
    {
        readonly TSEGUSUARIOHISTORIAREPOSITORY _TSEGUSUARIOHISTORIAREPOSITORY;
        public TSEGUsuarioSessionHistoriaServices()
        {
            _TSEGUSUARIOHISTORIAREPOSITORY = new TSEGUSUARIOHISTORIAREPOSITORY();

        }

        public IEnumerable<TSEGUSUARIOSESSIONHISTORIA> GetUsuarioSessionHistory()
        {
            return _TSEGUSUARIOHISTORIAREPOSITORY.GetAll();

        }

        public void InsertarUsuarioSessionHistory(TSEGUSUARIOSESSIONHISTORIA TSEGUSUARIOSESSIONHISTORIA)
        {
            _TSEGUSUARIOHISTORIAREPOSITORY.Add(TSEGUSUARIOSESSIONHISTORIA);

        }

        public void ActualizarUsuarioSessionHistory(TSEGUSUARIOSESSIONHISTORIA TSEGUSUARIOSESSIONHISTORIA)
        {
            _TSEGUSUARIOHISTORIAREPOSITORY.Modify(TSEGUSUARIOSESSIONHISTORIA);

        }

        public void EliminarUsuarioSessionHistory(int id)
        {
            _TSEGUSUARIOHISTORIAREPOSITORY.Delete(id);

        }


    }
}