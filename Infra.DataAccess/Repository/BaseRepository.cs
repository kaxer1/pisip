using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
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

        public void Delete(TEntity entity)
        {
            try
            {
                using (var context = new pisipEntities())
                {
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

        public TEntity GetEntidadPk(Dictionary<string, object> idCompuesto)
        {
            TEntity entity = null;
            try
            {
                using (var context = new pisipEntities())
                {
                    var query = context.Set<TEntity>().AsQueryable();

                    foreach (var propiedad in idCompuesto)
                    {
                        string nombrePropiedad = propiedad.Key;
                        object valorPropiedad = propiedad.Value;


                        var parameter = Expression.Parameter(typeof(TEntity));
                        var property = Expression.Property(parameter, nombrePropiedad);
                        var constant = Expression.Constant(valorPropiedad);
                        var equal = Expression.Equal(property, constant);
                        var lambda = Expression.Lambda<Func<TEntity, bool>>(equal, parameter);

                        query = query.Where(lambda);
                    }
                    entity = query.FirstOrDefault();
                    return entity;
                }
            }
            catch (Exception ex)
            {
                return entity;
            }
        }
    }
}
