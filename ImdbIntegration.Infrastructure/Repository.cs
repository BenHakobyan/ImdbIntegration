using ImdbIntegration.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ImdbIntegration.Infrastructure
{
    public class Repository<TModel> : IRepository<TModel> where TModel : class
    {
        private readonly IImdbContext _dbContext;
        private readonly DbSet<TModel> _dbSet;

        public Repository(IImdbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TModel>();
        }

        public void Create(TModel entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Delete(TModel entity)
        {
            var entry = _dbContext.Entry(entity);
            entry.State = EntityState.Deleted;
        }

        public TModel Find(Expression<Func<TModel, bool>> expression)
        {
            return _dbSet.FirstOrDefault(expression);
        }

        public IQueryable<TModel> Get()
        {
            return _dbSet;
        }

        public virtual void Update(TModel entity)
        {
            var entry = _dbContext.Entry(entity);
            _dbSet.Attach(entity);
            entry.State = EntityState.Modified;
        }
    }
}
