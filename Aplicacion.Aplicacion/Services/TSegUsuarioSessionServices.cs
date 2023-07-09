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
    public class TsegUsuarioSessionServices
    {
        readonly ITsegUsuarioSessionRepository tsegUsuarioSessionRepository;

        public TsegUsuarioSessionServices()
        {
            tsegUsuarioSessionRepository = new TsegUsuarioSessionRepository();
        }

        public IEnumerable<TSEGUSUARIOSESSION> ListarUsuarioSession()
        {
            return tsegUsuarioSessionRepository.GetAll();
        }

        public void InsertarUsuarioSession(TSEGUSUARIOSESSION nuevoUsuarioSession)
        {
            tsegUsuarioSessionRepository.Add(nuevoUsuarioSession);
        }

        public void ActualizarUsuarioSession(TSEGUSUARIOSESSION nuevoUsuarioSession)
        {
            tsegUsuarioSessionRepository.Modify(nuevoUsuarioSession);
        }

        public void EliminarUsuarioSession(TSEGUSUARIOSESSION usuarioSession)
        {
            tsegUsuarioSessionRepository.Delete(usuarioSession);
        }

        public IEnumerable<TSEGUSUARIOSESSION> listarSessionesActivas()
        {
            return tsegUsuarioSessionRepository.listarSessionesActivas();
        }

        public TSEGUSUARIOSESSION ObtenerRegistroPorPk(Dictionary<string, object> idcompuesto)
        {
            return tsegUsuarioSessionRepository.GetEntidadPk(idcompuesto);
        }
    }
}
