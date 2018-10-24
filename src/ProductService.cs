using CodeSquirl.System;
using CodeSquirl.RecipeApp.Model;
using System;
using System.Linq;

namespace CodeSquirl.RecipeApp.Service
{
    public class ProductService : IRepositoryService<Product>
    {
        private readonly IRepository _repository;

        public ProductService(IRepository repository)
        {
            _repository = repository;
        }

        public bool Add(Product product)
        {
            product.UniqueID = Guid.NewGuid();
            _repository.Add(product);
            return _repository.SaveChanges() > 0;
        }
        public Product Get(Guid id)
        {
            return Get(c => c.UniqueID == id).FirstOrDefault();
        }

        public IQueryable<Product> Get(Func<Product, bool> predicate)
        {
            return _repository.Get(predicate);
        }

        public bool Remove(Guid id)
        {
            _repository.Remove<Product>(p => p.UniqueID == id);
            return _repository.SaveChanges() > 0;
        }

        public bool Update(Product product)
        {
            var entity = Get(product.UniqueID);
            entity.Name = product.Name;
            entity.Perishable = product.Perishable;
            entity.Type = product.Type;
            return _repository.SaveChanges() > 0;
        }
    }
}
