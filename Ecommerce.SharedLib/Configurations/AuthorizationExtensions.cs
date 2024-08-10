//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;

//namespace Ecommerce.SharedLib.Configurations
//{
//    public static class AuthorizationExtensions
//    {
//        public static IServiceCollection AddAuthorization(this IServiceCollection services , IConfiguration configuration)
//        {
//            services.AddAuthentication("Bearer").AddJwtBearer("Bearer", options =>
//            {
//                options.Authority = configuration["Authentication:AuthorityUrl"];
//                options.RequireHttpsMetadata = false;
//                options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
//                {
//                    ValidateAudience = true
//                };
//            });

//            return services;

//        }
//    }
//}
