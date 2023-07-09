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
    public class TsegUsuarioDetalleServices
    {
        readonly ITsegUsuarioDetalleRepository tsegUsuarioDetalleRepository;

        public TsegUsuarioDetalleServices()
        {
            tsegUsuarioDetalleRepository = new TsegUsuarioDetalleRepository();
        }

        public IEnumerable<TSEGUSUARIODETALLE> ListarUsuarioDetalle()
        {
            return tsegUsuarioDetalleRepository.GetAll();
        }

        public void InsertarUsuarioDetalle(TSEGUSUARIODETALLE nuevoUsuarioDetalle)
        {
            tsegUsuarioDetalleRepository.Add(nuevoUsuarioDetalle);
        }

        public void ActualizarUsuarioDetalle(TSEGUSUARIODETALLE nuevoUsuarioDetalle)
        {
            tsegUsuarioDetalleRepository.Modify(nuevoUsuarioDetalle);
        }

        public void EliminarUsuarioDetalle(TSEGUSUARIODETALLE usuarioDetalle)
        {
            tsegUsuarioDetalleRepository.Delete(usuarioDetalle);
        }

        public TSEGUSUARIODETALLE IniciarSession(string usuario, string contrasenia, decimal ccompania, string ccanal, decimal crol)
        {
            return tsegUsuarioDetalleRepository.IniciarSesion(usuario, contrasenia, ccompania, ccanal, crol);
        }
    }
}
