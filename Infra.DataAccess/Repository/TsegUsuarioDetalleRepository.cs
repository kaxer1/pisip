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
        public TSEGUSUARIODETALLE IniciarSesion(string usuario, string contrasenia, decimal ccompania, string ccanal, decimal crol)
        {
            try
            {
                TSEGUSUARIOROL tsegusuariorol = new TSEGUSUARIOROL();
                using (var context = new pisipEntities())
                {
                    var resultado = from usuariodetalle in context.TSEGUSUARIODETALLE
                                           where usuariodetalle.PASSWORD == contrasenia 
                                           && usuariodetalle.CUSUARIO == usuario
                                           && usuariodetalle.CCANAL == ccanal
                                           && usuariodetalle.CCOMPANIA == ccompania
                                   select usuariodetalle;

                    var rol = from usuariorol in context.TSEGUSUARIOROL
                                    where usuariorol.CUSUARIO == usuario
                                    && usuariorol.CCOMPANIA == ccompania
                                    && usuariorol.CROL == crol
                              select usuariorol;

                    tsegusuariorol = rol.Single();

                    return resultado.Single();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR EN REPOSITORIO TsegUsuarioDetalleRepository: " + ex.Message);
                return null;
            }
        }

        public TSEGUSUARIODETALLE ValidaUsuarioRolExiste(string usuario, string contrasenia, decimal ccompania, string ccanal, decimal crol)
        {
            try
            {
                TSEGUSUARIOROL tsegusuariorol = new TSEGUSUARIOROL();
                using (var context = new pisipEntities())
                {
                    var resultado = from usuariodetalle in context.TSEGUSUARIODETALLE
                                    where usuariodetalle.PASSWORD == contrasenia
                                    && usuariodetalle.CUSUARIO == usuario
                                    && usuariodetalle.CCANAL == ccanal
                                    && usuariodetalle.CCOMPANIA == ccompania
                                    select usuariodetalle;

                    var rol = from usuariorol in context.TSEGUSUARIOROL
                              where usuariorol.CUSUARIO == usuario
                              && usuariorol.CCOMPANIA == ccompania
                              && usuariorol.CROL == crol
                              select usuariorol;

                    tsegusuariorol = rol.Single();

                    return resultado.Single();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR EN REPOSITORIO TsegUsuarioDetalleRepository: " + ex.Message);
                return null;
            }
        }
    }
}
