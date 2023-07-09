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
    public class TsegUsuarioRolServices
    {
        readonly ITsegUsuarioRolRepository tsegUsuarioRolRepository;

        public TsegUsuarioRolServices()
        {
            tsegUsuarioRolRepository = new TsegUsuarioRolRepository();
        }

        public IEnumerable<TSEGUSUARIOROL> ListarUsuarioRol()
        {
            return tsegUsuarioRolRepository.GetAll();
        }

        public void InsertarUsuarioRol(TSEGUSUARIOROL nuevoUsuarioRol)
        {
            tsegUsuarioRolRepository.Add(nuevoUsuarioRol);
        }

        public void ActualizarUsuarioRol(TSEGUSUARIOROL nuevoUsuarioRol)
        {
            tsegUsuarioRolRepository.Modify(nuevoUsuarioRol);
        }

        public void EliminarUsuarioRol(TSEGUSUARIOROL usuarioRol)
        {
            tsegUsuarioRolRepository.Delete(usuarioRol);
        }

        public TSEGUSUARIOROL ObtenerRegistroPorPk(Dictionary<string, object> idcompuesto)
        {
            return tsegUsuarioRolRepository.GetEntidadPk(idcompuesto);
        }
    }
}
