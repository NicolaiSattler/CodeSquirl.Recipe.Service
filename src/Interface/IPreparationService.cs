using System;
using System.Linq;
using CodeSquirl.RecipeApp.Model;

namespace CodeSquirl.RecipeApp.Service
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