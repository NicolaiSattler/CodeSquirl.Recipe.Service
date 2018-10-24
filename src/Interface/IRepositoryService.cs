using System;
using System.Linq;

namespace CodeSquirl.RecipeApp.Service
{
    public interface IRepositoryService<T> where T : class
    {
        bool Add(T entity);
        T Get(Guid id);
        IQueryable<T> Get(Func<T, bool> predicate);
        bool Update(T entity);
        bool Remove(Guid id);
    }
}