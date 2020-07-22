using Microsoft.Extensions.DependencyInjection;
using Data_Access_Layer.Interfaces;
using Business_layer.Services;

namespace Shop.UI
{
    public static class ServiceRegister
    {
        public static void AddApplicationServises(this IServiceCollection services)
        {
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IGuitarRepository, GuitarRepository>();
        }
    }
}


