using Desafio.Domain.Interfaces;
using Desafio.Service.Data;
using Desafio.Service.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using System.Data.SqlClient;

namespace Desafio.Service.Tools
{
    public static class ResolveInjection
    {
        public static IServiceCollection Resolve(this IServiceCollection services, IConfiguration configuration)
        {


            services.AddTransient<IDbConnection>(db => new SqlConnection(
                   configuration.GetConnectionString("DbDesafio")));

            services.AddDbContext<ContextDb>(options => options.UseSqlServer(configuration.GetConnectionString("DbDesafio")));


            services.AddScoped<ISubscribe, SubscribeRepository>();

            return services;
        }
    }
}
