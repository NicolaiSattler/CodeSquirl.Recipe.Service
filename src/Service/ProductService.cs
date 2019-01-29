using CodeSquirl.System;
using CodeSquirl.RecipeApp.Model;
using CodeSquirl.RecipeApp.DataProvider;
using System;
using System.Linq;
using System.Collections.Generic;
using AutoMapper;

namespace CodeSquirl.RecipeApp.Service
{
    public class ProductService : IRepositoryService<Product>
    {
        private readonly IRepository<ProductDTO> _repository;
        private readonly IMapper _mapper;

        public ProductService(IRepository<ProductDTO> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
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
            return _mapper.Map<IList<Product>>(_repository.GetAll());
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
