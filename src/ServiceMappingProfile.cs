using AutoMapper;
using CodeSquirl.RecipeApp.DataProvider;
using CodeSquirl.RecipeApp.Model;

namespace CodeSquirl.RecipeApp.Service
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
	    }
    }
}