using Autofac;
using AutoMapper;
using CodeSquirl.RecipeApp.Model;

namespace CodeSquirl.RecipeApp.Service
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
            // builder.RegisterType<IRepositoryService<DayPlan>>().As<DayService>();
            // builder.RegisterType<IRepositoryService<GroceryList>>().As<GroceryListService>();
            // builder.RegisterType<IRepositoryService<Ingredient>>().As<IngredientService>();
            // builder.RegisterType<IRepositoryService<Meal>>().As<MealService>();
            // builder.RegisterType<IRepositoryService<Necessity>>().As<NecessityService>();
            // builder.RegisterType<IRepositoryService<Preparation>>().As<PreparationService>();
            // builder.RegisterType<IRepositoryService<Recipe>>().As<RecipeService>();
            builder.RegisterInstance(mapper).As<IMapper>().SingleInstance();
        }
    }
}