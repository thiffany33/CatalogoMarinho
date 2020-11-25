using CatalogoMarinho.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CatalogoMarinho.Domain.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        TEntity GetById(Guid id);
        IEnumerable<TEntity> GetAll();
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(Guid id);
    }
}
