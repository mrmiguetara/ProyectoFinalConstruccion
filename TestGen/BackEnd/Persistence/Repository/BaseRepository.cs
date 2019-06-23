using System;
using System.Collections.Generic;
using System.Linq;
using Core.Models;
using Core.Repository;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repository
{
    public class BaseRepository<TEntity>: IGenericRepository<TEntity>
        where TEntity: BaseEntity
    {
        private readonly GeneratorDbContext _context;
        private readonly DbSet<TEntity> _set;
        
        public BaseRepository(GeneratorDbContext context)
        {
            _context = context;
            _set = context.Set<TEntity>();
        }
        
        public void Create(TEntity entity)
        {
            _set.Add(entity);
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public ISet<TEntity> Get() => _set.ToHashSet();

        public TEntity Find(int id) => _set.Find(id);

        public void Delete(int id)
        { 
            _set.Remove(_set.Find(id));
        }

        public ISet<TEntity> FindAll(Func<TEntity, bool> predicate) => _set.Where(predicate).ToHashSet();
        
        public void Save() => _context.SaveChanges();
    }
}