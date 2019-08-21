using Autofac;
using AutoMapper;
using CodeSquirrel.RecipeApp.Model;

namespace CodeSquirrel.RecipeApp.Service
{
    public class ServiceModule : Module 
    {
       private IMapper ConfigureAutoMapper()
        {
            var config = new MapperConfiguration(mc => {
                mc.AddProfile(new ServiceMappingProfile());
            });
            return config.CreateMapper();
        }

        protected override void Load(ContainerBuilder builder)
        {
            var mapper = ConfigureAutoMapper();
            builder.RegisterType<ProductService>().As<IRepositoryService<Product>>();
            builder.RegisterType<NecessityService>().As<IRepositoryService<Necessity>>();
            builder.RegisterInstance(mapper).As<IMapper>().SingleInstance();
        }
    }
}