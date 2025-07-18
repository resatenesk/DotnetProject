using System.Data;
using System.Linq.Expressions;
using Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework
{
    public class EFentityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new() where TContext : DbContext, new()
    {
        public void Add(TEntity ENTITY)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(ENTITY);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity ENTITY)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(ENTITY);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }

        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity ENTITY)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(ENTITY);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}