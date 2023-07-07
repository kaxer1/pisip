using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Model.Abstractions;
using Dominio.Model.Entities;

namespace Infra.DataAccess.Repository
{
    public class TsegUsuarioSessionRepository : BaseRepository<TSEGUSUARIOSESSION>, ITsegUsuarioSessionRepository
    {
        public IEnumerable<TSEGUSUARIOSESSION> listarSessionesActivas()
        {
            try
            {
                using (var context = new pisipEntities())
                {
                    var resultadoSession = from session in context.TSEGUSUARIOSESSION // origen de infor BD.tabla
                                            where session.ACTIVO == "1" // filtro aplicarse a los datos
                                            select session; // seleccion de informacion
                    return resultadoSession.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar empleados (Repository): " + ex.Message);
            }
        }
    }
}
