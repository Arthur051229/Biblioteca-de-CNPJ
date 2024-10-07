using System.Collections.Generic;
using System;
using System.Linq.Expressions;

namespace Biblioteca.Infrastructure.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetSingle(Expression<Func<TEntity, bool>> expression);
        TEntity GetById(long id);
        IList<TEntity> GetAll(Expression<Func<TEntity, bool>> expression);
        IList<TEntity> GetAll();
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Add(TEntity entity);
        void AddValidation(TEntity entity);
    }
}
