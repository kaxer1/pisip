using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Model.Abstractions;
using Dominio.Model.Entities;

namespace Infra.DataAccess.Repository
{
    public class TsegUsuarioSessionHistoriaRepository : BaseRepository<TSEGUSUARIOSESSIONHISTORIA>, ITsegUsuarioSessionHistoriaRepository
    {
        public IEnumerable<TSEGUSUARIOSESSIONHISTORIA> ListarSesiones(string usuario)
        {
            try
            {
                using (var context = new pisipEntities())
                {

                    var clientes = from cli in context.TSEGUSUARIOSESSIONHISTORIA
                                   where cli.CUSUARIO == usuario
                                   select cli;
                    return clientes.ToList();

                }


            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar registros: " + ex.Message, ex);
            }
        }
    }
}
