using System;
using System.Linq;
using CodeSquirrel.RecipeApp.Model;

namespace CodeSquirrel.RecipeApp.Service
{
    public interface IPreparationService
    {
        bool Add(Preparation entity);
        Preparation Get(Guid id);
        IQueryable<Preparation> Get(Func<Preparation, bool> predicate);
        bool Remove(Guid id);
        bool Update(Preparation entity);
    }
}