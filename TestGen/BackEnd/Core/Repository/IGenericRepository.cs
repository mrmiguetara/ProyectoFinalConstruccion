using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Models;

namespace Core.Repository
{
    public interface IGenericRepository<TEntity> where  TEntity : BaseEntity
    {
        void Create(TEntity entity);

        void Update(TEntity entity);

        ISet<TEntity> Get();

        TEntity Find(int id);

        void Delete(int id);
        
        ISet<TEntity> FindAll(Func<TEntity, bool> predicate);

        void Save();

    }
}