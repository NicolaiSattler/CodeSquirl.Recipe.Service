using CodeSquirl.System;
using CodeSquirl.RecipeApp.Model;
using System;
using System.Linq;

namespace CodeSquirl.RecipeApp.Service
{
    // public class MealService : IRepositoryService<Meal>
    // {
    //     private readonly IRepository _repository;

    //     public MealService(IRepository repository)
    //     {
    //         _repository = repository;
    //     }

    //     public bool Add(Meal meal)
    //     {
    //         _repository.Add(meal);
    //         return _repository.SaveChanges() > 0;
    //     }

    //     public IQueryable<Meal> Get(Func<Meal, bool> predicate)
    //     {
    //         return _repository.Get(predicate);
    //     }

    //     public Meal Get(Guid id)
    //     {
    //         return Get(m => m.UniqueID == id)?.FirstOrDefault();
    //     }

    //     public bool Remove(Guid id)
    //     {
    //         _repository.Remove<Meal>(m => m.UniqueID == id);
    //         return _repository.SaveChanges() > 0;
    //     }

    //     public bool Update(Meal meal)
    //     {
    //         _repository.Update(meal);
    //         return _repository.SaveChanges() > 0;
    //     }
    // }
}
