using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Model.Abstractions;
using Dominio.Model.Entities;
using Infra.DataAccess.Repository;

namespace Aplicacion.Aplicacion.Services
{
    public class TgenCompaniaServices
    {
        readonly ITgenCompaniaRepository tgenCompaniaRepository;

        public TgenCompaniaServices()
        {
            tgenCompaniaRepository = new TgenCompaniaRepository();
        }

        public IEnumerable<TGENCOMPANIA> ListarCompanias()
        {
            return tgenCompaniaRepository.GetAll();
        }

        public void InsertarCompania(TGENCOMPANIA nuevaCompania)
        {
            // caso especial porque no se usa secuencia atomatica en la base.
            var companialista = ListarCompanias();
            nuevaCompania.CCOMPANIA = companialista.Count() + 1;
            tgenCompaniaRepository.Add(nuevaCompania);
        }

        public void ActualizarCompania(TGENCOMPANIA nuevaCompania)
        {
            tgenCompaniaRepository.Modify(nuevaCompania);
        }

        public void EliminarCompania(TGENCOMPANIA compania)
        {
            tgenCompaniaRepository.Delete(compania);
        }

    }
}
