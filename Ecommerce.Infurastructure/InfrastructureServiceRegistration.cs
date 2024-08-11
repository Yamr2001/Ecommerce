using Ecommerce.Domain.Interfaces;
using Ecommerce.Infurastructure.Presistence;
using Ecommerce.Infurastructure.Repositories.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Infurastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfurastructureService(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<EcommerceContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefualtConncetion"))
            );
            services.AddScoped<IEcommerceUnitOfWork, EcommerceUnitOfWork>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            return services;

        }
    }
}
