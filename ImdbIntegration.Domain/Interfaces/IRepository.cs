using System;
using System.Linq;
using System.Linq.Expressions;

namespace ImdbIntegration.Domain.Interfaces
{
    public interface IRepository<TModel> where TModel : class
    {
        public IQueryable<TModel> Get();
        public TModel Find(Expression<Func<TModel, bool>> expression);
        public void Create(TModel model);
        public void Update(TModel model);
        public void Delete(TModel model);
    }
}
