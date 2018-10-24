
using CodeSquirl.System;
using CodeSquirl.RecipeApp.Model;
using System;
using System.Linq;

namespace CodeSquirl.RecipeApp.Service
{
    public class DayService : IRepositoryService<Day>
    {
        private readonly IRepository _repository;

        public DayService(IRepository repository)
        {
            _repository = repository;
        }

        public bool Add(Day day)
        {
            _repository.Add(day);
            return _repository.SaveChanges() > 0;
        }

        public IQueryable<Day> Get(Func<Day, bool> predicate)
        {
            return _repository.Get(predicate);
        }

        public Day Get(Guid id)
        {
            return Get(d => d.UniqueID == id)?.FirstOrDefault();
        }

        public bool Remove(Guid id)
        {
            _repository.Remove<Day>(d => d.UniqueID == id);
            return _repository.SaveChanges() > 0;
        }

        public bool Update(Day day)
        {
            _repository.Update(day);
            return _repository.SaveChanges() > 0;
        }
    }
}
