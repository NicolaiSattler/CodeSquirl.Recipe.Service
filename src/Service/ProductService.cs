using CodeSquirl.System;
using CodeSquirl.RecipeApp.Model;
using CodeSquirl.RecipeApp.DataProvider;
using System;
using System.Linq;
using System.Collections.Generic;

namespace CodeSquirl.RecipeApp.Service
{
    public class ProductService : IRepositoryService<Product>
    {
        private readonly IRepository<ProductDTO> _repository;

        public ProductService(IRepository<ProductDTO> repository)
        {
            _repository = repository;
        }

        public bool Add(Product entity)
        {
            try
            {
                var dto = new ProductDTO
                {
                    UniqueID = Guid.NewGuid(),
                    Name = entity.Name,
                    Type = (int)entity.Type,
                    Perishable = entity.Perishable,
                    Deleted = false
                };
                _repository.Add(dto);

                return true;
            }
            catch(Exception ex)
            {
                //TODO: Log Exception
                return false;
            }
        }

        public Product Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IList<Product> Get(Func<Product, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
