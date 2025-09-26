using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SbRf.Gestao.Core.Interfaces;
using SbRf.Gestao.Infra.Sqlite.Context;
using SbRf.Gestao.Infra.Sqlite.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbRf.Gestao.Infra.Sqlite
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraSqlite(this IServiceCollection services, IConfiguration config)
        {
            // DbContext
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite($"Data Source={config["ConnectionStrings:DefaultConnection"]}"));

            // Repositórios
            services.AddScoped<IRepositoryUnidadeDeMedida, RepositoryUnidadeDeMedida>();            

            return services;
        }

        private static string GetConnectionString(IConfiguration config)
        {
            string baseFolder = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string systemFolderName = "sbrf_gestao";
            baseFolder = System.IO.Path.Join(baseFolder, systemFolderName);
            string dbName = "gestao.db";
            string connStr = Path.Combine(baseFolder, dbName);
            return $"Data Source={connStr}";
        }
    }
}
