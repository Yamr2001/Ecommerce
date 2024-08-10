//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;

//namespace Ecommerce.SharedLib.Configurations
//{
//    public static class SwaggerExtensions
//    {
//        public static void AddSwaggerGen(this IServiceCollection services, string serviceName)
//        {
//            services.AddSwaggerGen(c =>
//            {
//                c.SwaggerDoc(docName, new OpenApiInfo { Title = serviceName, Version = versionName });
//                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
//                {
//                    Description = @"Enter 'Bearer' [space] and your token ",
//                    Name = "Authorization",
//                    In = ParameterLocation.Header,
//                    Type = SecuritySchemeType.ApiKey,
//                    Scheme = "Bearer"
//                });
//                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
//                {
//                    {
//                        new OpenApiSecurityScheme
//                        {
//                            Reference = new OpenApiReference
//                            {
//                                Type = ReferenceType.SecurityScheme,
//                                Id = "Bearer"
//                            },
//                            Scheme = "oauth2",
//                            Name = "Bearer",
//                            In = ParameterLocation.Header,

//                        },
//                        new List<string>()
//                    }
//                });
//            });


//        }
//    }
//}
