using AutoMapper;
using CodeSquirrel.System;
using CodeSquirrel.RecipeApp.DataProvider;
using CodeSquirrel.RecipeApp.Model;
using System;
using System.Linq;
using System.Collections.Generic;

namespace CodeSquirrel.RecipeApp.Service
{
    public class NecessityService : IRepositoryService<Necessity>
    {
        private readonly IRepository<NecessityDTO> _repository;
        private readonly IMapper _mapper;

        public NecessityService(IRepository<NecessityDTO> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        private NecessityDTO CreateDTO(Necessity entity)
        {
            return new NecessityDTO
            {
                UniqueID = Guid.NewGuid(),
                Name = entity.Name,
                Description = entity.Description,
                Electrical = entity.Electrical,
                Deleted = false
            };
        }
        public bool Add(Necessity entity)
        {
            var dto = CreateDTO(entity);
            return _repository.Add(dto);
        }

        public bool AddRange(IEnumerable<Necessity> entities)
        {
            var dtoCollection = entities.Select(CreateDTO);
            return _repository.AddRange(dtoCollection);
        }

        public Necessity Get(Guid id)
        {
            return _mapper.Map<Necessity>(_repository.GetByID(id));
        }

        public IList<Necessity> GetAll()
        {
            return _mapper.Map<IList<Necessity>>(_repository.Get());
        }

        public bool Remove(Guid id)
        {
            return _repository.Remove(id);
        }

        public bool Update(Necessity entity)
        {
            var dto = _mapper.Map<NecessityDTO>(entity);
            return _repository.Update(dto);
        }
    }
}
