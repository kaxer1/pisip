using Dominio.Model.Entities;
using Infra.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Aplicacion.Services
{
    public class TSegUsuarioSessionServices
    {
        readonly TSegUsuarioSessionRepository _TSegUSuarioSessionRepository;
        public TSegUsuarioSessionServices()
        {
            _TSegUSuarioSessionRepository = new TSegUsuarioSessionRepository();

        }

        public IEnumerable<TSEGUSUARIOSESSION> GetSegUsuarioSession()
        {
            return _TSegUSuarioSessionRepository.GetAll();

        }

        public void InsertarSegUsuarioSession(TSEGUSUARIOSESSION TSEGUSUARIOSESSION)
        {
            _TSegUSuarioSessionRepository.Add(TSEGUSUARIOSESSION);

        }

        public void InsertarUsuarioSession(TSEGUSUARIOSESSION nuevo)
        {
            throw new NotImplementedException();
        }

        public void ActualizarSegUsuarioSession(TSEGUSUARIOSESSION TSEGUSUARIOSESSION)
        {
            _TSegUSuarioSessionRepository.Modify(TSEGUSUARIOSESSION);

        }

        public void EliminarSegUsuarioSession(int id)
        {
            _TSegUSuarioSessionRepository.Delete(id);

        }

        public void ActualizarUsuario(TSEGUSUARIOSESSION nuevo)
        {
            throw new NotImplementedException();
        }

        public object ListarUsuario()
        {
            throw new NotImplementedException();
        }
    }
}
