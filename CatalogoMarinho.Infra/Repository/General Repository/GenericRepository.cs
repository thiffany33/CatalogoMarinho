using CatalogoMarinho.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using CatalogoMarinho.Domain.Interfaces;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace CatalogoMarinho.Infra.Repository.GeneralRepository
{
    public class GenericRepository: IGenericRepository
    {
        public abstract class GenericRepository<TEntity>
            : IGenericRepository<TEntity> where TEntity : BaseEntity
        {

            private readonly Context _context;
            protected readonly DbSet<TEntity> _dbSet;

            public GenericRepository(Context dbContext)
            {
                _context = dbContext;
                _dbSet = dbContext.Set<TEntity>();
            }

            public TEntity GetById(Guid id)
            {
                return Query().FirstOrDefault(entity => entity.Id == id);
            }

            public virtual IEnumerable<TEntity> GetAll()
            {
                return Query().ToList();
            }

            public void Create(TEntity entity)
            {
                _dbSet.Add(entity);
                _context.SaveChanges();
            }

            public void Update(TEntity entity)
            {
                _dbSet.Update(entity);
                _context.SaveChanges();
            }

            public void Delete(Guid id)
            {
                var entityToDelete = _dbSet.Find(id);
                _dbSet.Remove(entityToDelete);
                _context.SaveChanges();
            }
            protected IQueryable<TEntity> Query() => _dbSet.AsNoTracking();
        }

    }
}
