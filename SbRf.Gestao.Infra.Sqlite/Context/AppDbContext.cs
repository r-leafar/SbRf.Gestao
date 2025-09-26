using Microsoft.EntityFrameworkCore;
using SbRf.Gestao.Core.Entities;
using SbRf.Gestao.Infra.Sqlite.Persistence.Configurations;
using SbRf.Gestao.Infra.Sqlite.Persistence.Models;

namespace SbRf.Gestao.Infra.Sqlite.Context
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<ProdutoModel> Produtos { get; set; }
        public virtual DbSet<MarcaModel> Marcas { get; set; }
        public virtual DbSet<UnidadeDeMedidaModel> Unidades { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //  string baseFolder = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        //  string systemFolderName = "sbrf_gestao";
        //  baseFolder = System.IO.Path.Join(baseFolder, systemFolderName);
        //  string dbName = "gestao.db";
        //  string connStr = Path.Combine(baseFolder, dbName);

        //  optionsBuilder.UseSqlite($"Data Source={connStr}");
        //}
        public AppDbContext(DbContextOptions<AppDbContext> options)
      : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MarcaConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new UnidadeDeMedidaConfiguration());
        }
    }
}
