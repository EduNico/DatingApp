using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace API.Extensions
{
    public static class IdentityServiceExtensions
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration config)
        {

             services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme) //need a paquete from nuget
              .AddJwtBearer(options =>
             {
                  options.TokenValidationParameters = new TokenValidationParameters
               {
                    ValidateIssuerSigningKey = true,                        //Rules for a server to validate  token 
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["TokenKey"])),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };

            });

            return services;
        }
    }
}