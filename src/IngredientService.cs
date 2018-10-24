using CodeSquirl.System;
using CodeSquirl.RecipeApp.Model;
using System;
using System.Linq;

namespace CodeSquirl.RecipeApp.Service
{
    public class IngredientService : IRepositoryService<Ingredient>
    {
        private readonly IRepository _repository;

        public IngredientService(IRepository repository)
        {
            _repository = repository;
        }

        public bool Add(Ingredient entity)
        {
            _repository.Add(entity);
            return _repository.SaveChanges() > 0;
        }

        public Ingredient Get(Guid id)
        {
            return Get(i => i.UniqueID == id)?.FirstOrDefault();
        }
        public IQueryable<Ingredient> Get(Func<Ingredient, bool> predicate)
        {
            return _repository.Get(predicate);
        }

        public bool Remove(Guid id)
        {
            _repository.Remove<Ingredient>(i => i.UniqueID == id);
            return _repository.SaveChanges() > 0;
        }

        public bool Update(Ingredient entity)
        {
            _repository.Update(entity);
            return _repository.SaveChanges() > 0;
        }
    }
}
