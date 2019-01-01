
using CodeSquirl.System;
using CodeSquirl.RecipeApp.Model;
using System;
using System.Linq;

namespace CodeSquirl.RecipeApp.Service
{
    // public class DayService : IRepositoryService<DayPlan>
    // {
    //     private readonly IRepository<DayPlan> _repository;

    //     public DayService(IRepository<DayPlan> repository)
    //     {
    //         _repository = repository;
    //     }

    //     public bool Add(DayPlan day)
    //     {
    //         _repository.Add(day);
    //         return _repository.SaveChanges() > 0;
    //     }

    //     public IQueryable<DayPlan> Get(Func<DayPlan, bool> predicate)
    //     {
    //         return _repository.Get(predicate);
    //     }

    //     public DayPlan Get(Guid id)
    //     {
    //         return Get(d => d.UniqueID == id)?.FirstOrDefault();
    //     }

    //     public bool Remove(Guid id)
    //     {
    //         _repository.Remove<DayPlan>(d => d.UniqueID == id);
    //         return _repository.SaveChanges() > 0;
    //     }

    //     public bool Update(DayPlan day)
    //     {
    //         _repository.Update(day);
    //         return _repository.SaveChanges() > 0;
    //     }
    // }
}
