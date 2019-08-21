using AutoMapper;
using CodeSquirrel.RecipeApp.DataProvider;
using CodeSquirrel.RecipeApp.Model;

namespace CodeSquirrel.RecipeApp.Service
{
    public class ServiceMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "ServiceMapping";
            }
        }

        public ServiceMappingProfile()
	    {
            CreateMap<Product, ProductDTO>();
            CreateMap<ProductDTO, Product>();
            CreateMap<Necessity, NecessityDTO>();
            CreateMap<NecessityDTO, Necessity>();
	    }
    }
}