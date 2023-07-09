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
    public class TsegUsuarioDetalleHistServices
    {
        readonly ITsegUsuarioDetalleHistRepository tsegUsuarioDetalleHistRepository;

        public TsegUsuarioDetalleHistServices()
        {
            tsegUsuarioDetalleHistRepository = new TsegUsuarioDetalleHistRepository();
        }

        public IEnumerable<TSEGUSUARIODETALLEHIST> ListarUsuarioDetalleHist()
        {
            return tsegUsuarioDetalleHistRepository.GetAll();
        }

        public void InsertarUsuarioDetalleHist(TSEGUSUARIODETALLEHIST nuevoUsuarioDetalle)
        {
            tsegUsuarioDetalleHistRepository.Add(nuevoUsuarioDetalle);
        }

        public void ActualizarUsuarioDetalleHist(TSEGUSUARIODETALLEHIST nuevoUsuarioDetalle)
        {
            tsegUsuarioDetalleHistRepository.Modify(nuevoUsuarioDetalle);
        }

        public void EliminarUsuarioDetalleHist(TSEGUSUARIODETALLEHIST usuarioDetalle)
        {
            tsegUsuarioDetalleHistRepository.Delete(usuarioDetalle);
        }
    }
}
