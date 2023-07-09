using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Model.Entities;

namespace Dominio.Model.Abstractions
{
    public interface ITsegUsuarioSessionRepository : IBaseRepository<TSEGUSUARIOSESSION>
    {
        // Select * from TSEGUSUARIOSESSION where activo = '1'
        IEnumerable<TSEGUSUARIOSESSION> listarSessionesActivas();

    }
}
