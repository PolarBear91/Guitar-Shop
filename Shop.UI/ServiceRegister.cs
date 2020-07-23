using Microsoft.Extensions.DependencyInjection;
using Data_Access_Layer.Interfaces;
using Business_layer.Services;
using Data_Access_Layer.Models;
using Data_Access_Layer.MockRepository;

namespace Shop.UI
{
    public static class ServiceRegister
    {
        public static void AddApplicationServises(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IGuitarRepository, GuitarRepository>();
            services.AddScoped<ShoppingCart>(sp => ShoppingCart.GetCart(sp));
        }
    }
}


