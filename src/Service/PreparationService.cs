using CodeSquirrel.System;
using CodeSquirrel.RecipeApp.Model;
using System;
using System.Linq;

namespace CodeSquirrel.RecipeApp.Service
{
    // public class PreparationService : IPreparationService
    // {
    //     private readonly IRepository _repository;

    //     public PreparationService(IRepository repository)
    //     {
    //         _repository = repository;
    //     }

    //     public bool Add(Preparation preparation)
    //     {
    //         _repository.Add(preparation);
    //         return _repository.SaveChanges() > 0;
    //     }

    //     public IQueryable<Preparation> Get(Func<Preparation, bool> predicate)
    //     {
    //         return _repository.Get(predicate);
    //     }

    //     public Preparation Get(Guid id)
    //     {
    //         return _repository.Get<Preparation>(p => p.UniqueID == id).FirstOrDefault();
    //     }

    //     public bool Remove(Guid id)
    //     {
    //         _repository.Remove<Preparation>(p => p.UniqueID == id);
    //         return _repository.SaveChanges() > 0;
    //     }

    //     public bool Update(Preparation entity)
    //     {
    //         _repository.Update(entity);
    //         return _repository.SaveChanges() > 0;
    //     }
    // }
}
