using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Model.Abstractions;
using Dominio.Model.Entities;

namespace Infra.DataAccess.Repository
{
    public class TsegUsuarioDetalleRepository : BaseRepository<TSEGUSUARIODETALLE>, ITsegUsuarioDetalleRepository
    {
        public TSEGUSUARIODETALLE IniciarSesion(string usuario, string contrasenia)
        {
            try
            {
                using (var context = new pisipEntities())
                {
                    var resultado= from session in context.TSEGUSUARIODETALLE
                                           where session.PASSWORD == contrasenia 
                                           && session.CUSUARIO == usuario
                                           select session;

                    return resultado.Single();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
