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
    public class TsegUsuarioServices
    {
        readonly ITsegUsuarioRepository tsegUsuarioRepository;

        public TsegUsuarioServices()
        {
            tsegUsuarioRepository = new TsegUsuarioRepository();
        }

        public IEnumerable<TSEGUSUARIO> ListarUsuario()
        {
            return tsegUsuarioRepository.GetAll();
        }

        public void InsertarUsuario(TSEGUSUARIO nuevoUsuario)
        {
            tsegUsuarioRepository.Add(nuevoUsuario);
        }

        public void ActualizarUsuario(TSEGUSUARIO nuevoUsuario)
        {
            tsegUsuarioRepository.Modify(nuevoUsuario);
        }

        public void EliminarUsuario(TSEGUSUARIO usuario)
        {
            tsegUsuarioRepository.Delete(usuario);
        }
    }
}
