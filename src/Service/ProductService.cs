using CodeSquirrel.System;
using CodeSquirrel.RecipeApp.Model;
using CodeSquirrel.RecipeApp.DataProvider;
using System;
using System.Linq;
using System.Collections.Generic;
using AutoMapper;

namespace CodeSquirrel.RecipeApp.Service
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
        private ProductDTO CreateDTO(Product entity)
        {
            return new ProductDTO
            {
                UniqueID = Guid.NewGuid(),
                Name = entity.Name,
                Type = (int)entity.Type,
                Perishable = entity.Perishable,
                Deleted = false
            };
        }
        public bool Add(Product entity)
        {
            var dto = CreateDTO(entity);
            return _repository.Add(dto);
        }
        public bool AddRange(IEnumerable<Product> entities)
        {
            var dtoCollection = entities.Select(CreateDTO);
            return _repository.AddRange(dtoCollection);
        }

        public Product Get(Guid id)
        {
            return _mapper.Map<Product>(_repository.GetByID(id));
        }

        public IList<Product> GetAll()
        {
            return _mapper.Map<IList<Product>>(_repository.Get());
        }

        public bool Remove(Guid id)
        {
            return _repository.Remove(id);
        }

        public bool Update(Product entity)
        {
            var dto = _mapper.Map<ProductDTO>(entity);
            return _repository.Update(dto);
        }
    }
}
