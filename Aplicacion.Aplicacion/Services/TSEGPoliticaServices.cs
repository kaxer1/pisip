using Dominio.Model.Abstractions;
using Dominio.Model.Entities;
using Infra.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Aplicacion.Services
{
    public class TsegPoliticaServices
    {
        readonly TsegPoliticaRepository _TSEGPoliticaRepository;
        public TsegPoliticaServices()
        {
            _TSEGPoliticaRepository = new TsegPoliticaRepository();

        }

        public IEnumerable<TSEGPOLITICA> GetPoliticas()
        {
            return _TSEGPoliticaRepository.GetAll();

        }

        public void InsertarPoliticas(TSEGPOLITICA TSEGPOLITICA)
        {
            _TSEGPoliticaRepository.Add(TSEGPOLITICA);

        }

        public void ActualizarPoliticas(TSEGPOLITICA TSEGPOLITICA)
        {
            _TSEGPoliticaRepository.Modify(TSEGPOLITICA);

        }

        public void EliminarPoliticas(int id)
        {
            _TSEGPoliticaRepository.Delete(id);
        }

        public TSEGPOLITICA ObtenerRegistroPorPk(Dictionary<string, object> idcompuesto)
        {
            return _TSEGPoliticaRepository.GetEntidadPk(idcompuesto);
        }


    }
}
