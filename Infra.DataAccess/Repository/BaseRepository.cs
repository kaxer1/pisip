using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Model.Abstractions;

namespace Infra.DataAccess.Repository
{
    public class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class
    {
        public void Add(TEntity entity)
        {
            try
            {
                using (var context = new pisipEntities())
                {
                    context.Set<TEntity>().Add(entity);
                    context.SaveChanges();
                }


            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar registros: " + ex.Message, ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (var context = new pisipEntities())
                {
                    var entity = context.Set<TEntity>().Find(id);
                    context.Set<TEntity>().Remove(entity);
                    context.SaveChanges();
                }


            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar registros: " + ex.Message, ex);
            }

        }

        public TEntity Get(int id)
        {
            try
            {
                using (var context = new pisipEntities())
                {

                    return context.Set<TEntity>().Find(id);

                }


            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar registros: " + ex.Message, ex);
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                using (var context = new pisipEntities())
                {

                    return context.Set<TEntity>().ToList();

                }


            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar registros: " + ex.Message, ex);
            }
        }

        public void Modify(TEntity entity)
        {
            try
            {
                using (var context = new pisipEntities())
                {
                    context.Entry(entity).State = EntityState.Modified;
                    context.SaveChanges();
                }


            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar registros: " + ex.Message, ex);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
