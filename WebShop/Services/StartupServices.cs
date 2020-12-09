using Core.Interfaces;
using Infrastructure;
using Infrastructure.Data;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebShop.Services {
    public static class StartupServices {
        public static IServiceCollection ServiceCollection(this IServiceCollection services,
            IConfigurationRoot configuration) {
            
            services.AddControllers();
           
            
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductTypeRepository, ProductTypeRepository>();
            services.AddScoped(typeof(IGenericRepository<>), (typeof(GenericRepository<>)));

            return services;
        }
    }
}