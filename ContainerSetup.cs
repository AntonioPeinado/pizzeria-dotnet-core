using API.Application;
using API.Infraestructure;
using Microsoft.Extensions.DependencyInjection;

namespace API
{
    public class ContainerSetup
    {
        public static void Setup(IServiceCollection services)
        {
            _setupInfraestructure(services);
            _setupApplication(services);
        }
        private static void _setupInfraestructure(IServiceCollection services)
        {
            services.AddScoped(typeof(ICommentContext), typeof(PizzeriaContext));
            services.AddScoped(typeof(IIngredientContext), typeof(PizzeriaContext));
            services.AddScoped(typeof(IPizzaContext), typeof(PizzeriaContext));
            services.AddScoped(typeof(IPizzaIngredientContext), typeof(PizzeriaContext));
            services.AddScoped(typeof(IUserContext), typeof(PizzeriaContext));
        }
        private static void _setupApplication(IServiceCollection services)
        {
            services.AddScoped(typeof(ICommentService), typeof(CommentService));
            services.AddScoped(typeof(ICommentMapper), typeof(CommentMapper));
            services.AddScoped(typeof(IIngredientService), typeof(IngredientService));
            services.AddScoped(typeof(IIngredientMapper), typeof(IngredientMapper));
            services.AddScoped(typeof(IPizzaService), typeof(PizzaService));
            services.AddScoped(typeof(IPizzaMapper), typeof(PizzaMapper));
            services.AddScoped(typeof(IPizzaIngredientService), typeof(PizzaIngredientService));
            services.AddScoped(typeof(IUserService), typeof(UserService));
            services.AddScoped(typeof(IUserMapper), typeof(UserMapper));
        }
    }
}