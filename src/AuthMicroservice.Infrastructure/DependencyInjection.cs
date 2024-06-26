
using AuthMicroservice.Infrastructure.Common.Mapping;
using AuthMicroservice.Domain.Interfaces;
using AuthMicroservice.Domain.Interfaces.Repositories;
using AuthMicroservice.Application.Interfaces.Services;
using AuthMicroservice.Infrastructure.Controllers;
using AuthMicroservice.Infrastructure.DataAccess;
using AuthMicroservice.Infrastructure.DataAccess.Repositories;
using AuthMicroservice.Application.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using AuthMicroservice.Domain.Configurations;
using AuthMicroservice.Infrastructure.Services.Interfaces;
using AuthMicroservice.Infrastructure.Services.Implementations;

namespace AuthMicroservice.Infrastructure.DependencyInjection;

public static class DependencyInjection
{
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddGrpc();
            services.AddGrpcReflection();
            services.ConfigureDbContext(configuration);
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserDomainService, UserDomainService>();
            services.AddScoped<IJwtService, JwtService>();
            services.AddScoped<IPasswordService, PasswordService>();
            services.AddScoped<IAuthDbContext, AuthDbContext>();
            services.AddScoped<IUserService, UserService>();


            return services;
        }

        private static IServiceCollection ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<AuthDbContext>();
            services.AddDbContext<AuthDbContext>(options =>
            {
                options.UseSqlite(configuration.GetConnectionString("DefaultConnection"));
            });

            return services;
        }


        public static IServiceCollection AddJwtAuthentication(this IServiceCollection services)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = JwtOptions.ISSUER,
                        ValidAudience = JwtOptions.AUDIENCE,
                        IssuerSigningKey = JwtOptions.GetSymmetricSecurityKey()
                    };
                });

                return services;
        }

        public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGrpcService<UserController>();
                endpoints.MapGrpcService<AuthorizationController>();
                endpoints.MapGrpcReflectionService();
            });

            return app;
        }
}