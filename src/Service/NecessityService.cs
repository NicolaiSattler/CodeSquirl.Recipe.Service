using CodeSquirl.System;
using CodeSquirl.RecipeApp.Model;
using System;
using System.Linq;

namespace CodeSquirl.RecipeApp.Service
{
    // public class NecessityService : IRepositoryService<Necessity>
    // {
    //     private readonly IRepository _repository;

    //     public NecessityService(IRepository repositoy)
    //     {
    //         _repository = repositoy;
    //     }

    //     public bool Add(Necessity appliance)
    //     {
    //         _repository.Add(appliance);
    //         return _repository.SaveChanges() > 0;
    //     }
    //     public Necessity Get(Guid id)
    //     {
    //         return Get(a => a.UniqueID == id)?.FirstOrDefault();
    //     }

    //     public IQueryable<Necessity> Get(Func<Necessity, bool> predicate)
    //     {
    //         return _repository.Get(predicate);
    //     }
    //     public bool Update(Necessity appliance)
    //     {
    //         _repository.Update(appliance);
    //         return _repository.SaveChanges() > 0;
    //     }

    //     public bool Remove(Guid id)
    //     {
    //         _repository.Remove<Necessity>(a => a.UniqueID == id);
    //         return _repository.SaveChanges() > 0;
    //     }
    // }
}
