using Ecommerce.Domain.Interfaces;
using Ecommerce.Infurastructure.Presistence;
using Ecommerce.Infurastructure.Repositories.Base;
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
            options.UseSqlServer(configuration.GetConnectionString("DefualtConnection"))
            );
            services.AddScoped<IEcommerceUnitOfWork, EcommerceUnitOfWork>();


            return services;

        }
    }
}
