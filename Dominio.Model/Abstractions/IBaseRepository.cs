using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Model.Abstractions
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        // insertar
        void Add(TEntity entity);
        // actualizar
        void Modify(TEntity entity);
        // eliminar
        void Delete(int id);
        // select * from
        IEnumerable<TEntity> GetAll();
        // Buscar por ID
        TEntity Get(int id);
        //Prueba Push
    }
}
