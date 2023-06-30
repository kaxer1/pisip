using Dominio.Model.Entities;
using Infra.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Aplicacion.Services
{
    public class TGENCanalesServices
    {


        readonly TGENCanalesRepository _TGENCanalesRepository;
        public TGENCanalesServices()
        {
            _TGENCanalesRepository = new TGENCanalesRepository();

        }

        public IEnumerable<TGENCANALES> GetCanales()
        {
            return _TGENCanalesRepository.GetAll();

        }

        public void InsertarCanales(TGENCANALES TGENCANALES)
        {
            _TGENCanalesRepository.Add(TGENCANALES);

        }

        public void ActualizarCanales(TGENCANALES TGENCANALES)
        {
            _TGENCanalesRepository.Modify(TGENCANALES);

        }

        public void EliminarCanales(int id)
        {
            _TGENCanalesRepository.Delete(id);

        }


    }
}
