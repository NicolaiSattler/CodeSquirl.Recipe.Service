using Autofac;
using CodeSquirl.RecipeApp.Model;

namespace CodeSquirl.RecipeApp.Service
{
    public class ServiceModule : Module 
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<IRepositoryService<Day>>().As<DayService>();
            builder.RegisterType<IRepositoryService<GroceryList>>().As<GroceryListService>();
            builder.RegisterType<IRepositoryService<Ingredient>>().As<IngredientService>();
            builder.RegisterType<IRepositoryService<Meal>>().As<MealService>();
            builder.RegisterType<IRepositoryService<Necessity>>().As<NecessityService>();
            builder.RegisterType<IRepositoryService<Preparation>>().As<PreparationService>();
            builder.RegisterType<IRepositoryService<Product>>().As<ProductService>();
            builder.RegisterType<IRepositoryService<Recipe>>().As<RecipeService>();
        }
    }
}