using CodeSquirrel.System;
using CodeSquirrel.RecipeApp.Model;
using CodeSquirrel.RecipeApp.DataProvider;
using System;
using System.Linq;

namespace CodeSquirrel.RecipeApp.Service
{
    // public class RecipeService : IRepositoryService<Recipe>
    // {
    //     private readonly IRepository _repository;

    //     public RecipeService(IRepository repository)
    //     {
    //         _repository = repository;
    //     }

    //     public bool Add(Recipe recipy)
    //     {
    //         _repository.Add(recipy);
    //         return _repository.SaveChanges() > 0;
    //     }

    //     public IQueryable<Recipe> Get(Func<Recipe, bool> predicate)
    //     {
    //         return _repository.Get(predicate);
    //     }

    //     public Recipe Get(Guid id)
    //     {
    //         return _repository.Get<Recipe>(r => r.UniqueID == id)?.FirstOrDefault();
    //     }

    //     public bool Remove(Guid id)
    //     {
    //         _repository.Remove<Recipe>(r => r.UniqueID == id);
    //         return _repository.SaveChanges() > 0;
    //     }

    //     public bool Update(Recipe entity)
    //     {
    //         _repository.Update(entity);
    //         return _repository.SaveChanges() > 0;
    //     }
    // }
}
