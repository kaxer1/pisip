using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Model.Entities;

namespace Dominio.Model.Abstractions
{
    public interface ITsegUsuarioDetalleRepository : IBaseRepository<TSEGUSUARIODETALLE>
    {
        TSEGUSUARIODETALLE IniciarSesion(string usuario, string contrasenia, decimal ccompania, string ccanal, decimal crol);

    }
}
