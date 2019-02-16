using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeSquirl.RecipeApp.Service
{
    public interface IRepositoryService<T> where T : class
    {
        bool Add(T entity);
        bool AddRange(IEnumerable<T> entities);
        bool Update(T entity);
        bool Remove(Guid id);
        T Get(Guid id);
        IList<T> GetAll();
    }
}