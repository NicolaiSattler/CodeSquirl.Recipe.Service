using CodeSquirl.System;
using CodeSquirl.RecipeApp.Model;
using System;
using System.Linq;

namespace CodeSquirl.RecipeApp.Service
{
    public class GroceryListService : IRepositoryService<GroceryList>
    {
        private readonly IRepository _repository;

        public GroceryListService(IRepository repository)
        {
            _repository = repository;
        }

        public bool Add(GroceryList groceryList)
        {
            _repository.Add(groceryList);
            return _repository.SaveChanges() > 0;
        }

        public IQueryable<GroceryList> Get(Func<GroceryList, bool> predicate)
        {
            return _repository.Get(predicate);
        }

        public GroceryList Get(Guid id)
        {
            return Get(g => g.UniqueID == id)?.FirstOrDefault();
        }

        public bool Remove(Guid id)
        {
            _repository.Remove<GroceryList>(g => g.UniqueID == id);
            return _repository.SaveChanges() > 0;
        }

        public bool Update(GroceryList groceryList)
        {
            _repository.Update(groceryList);
            return _repository.SaveChanges() > 0;
        }
    }
}
