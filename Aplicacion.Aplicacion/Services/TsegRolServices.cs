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
    public class TsegRolServices
    {
        readonly ITsegRolRepository tsegRolRepository;

        public TsegRolServices()
        {
            tsegRolRepository = new TsegRolRepository();
        }

        public IEnumerable<TSEGROL> ListarRol()
        {
            return tsegRolRepository.GetAll();
        }

        public void InsertarRol(TSEGROL nuevoRol)
        {
            tsegRolRepository.Add(nuevoRol);
        }

        public void ActualizarRol(TSEGROL nuevoRol)
        {
            tsegRolRepository.Modify(nuevoRol);
        }

        public void EliminarRol(TSEGROL rol)
        {
            tsegRolRepository.Delete(rol);
        }
    }
}
