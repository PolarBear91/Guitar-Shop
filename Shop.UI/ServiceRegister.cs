using Microsoft.Extensions.DependencyInjection;
using Data_Access_Layer.Interfaces;
using Data_Access_Layer.MockRepository;

namespace Shop.UI
{
    public static class ServiceRegister
    {
        public static void AddApplicationServises(this IServiceCollection services)
        {
            services.AddTransient<ICategoryRepository, MockCategoryRepository>();
            services.AddTransient<IGuitarRepository, MockGuitarRepository>();
        }
    }
}


