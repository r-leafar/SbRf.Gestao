using Microsoft.EntityFrameworkCore;
using SbRf.Gestao.Core.Interfaces;
using SbRf.Gestao.Infra.Sqlite.Context;
using SbRf.Gestao.Infra.Sqlite.Persistence.Models;
using SbRf.Gestao.Infra.Sqlite.Persistence.Mapper;
using SbRf.Gestao.Core.Entities.CatalogoProduto;

namespace SbRf.Gestao.Infra.Sqlite.Persistence.Repositories
{
    public class RepositoryUnidadeDeMedida : IRepositoryUnidadeDeMedida
    {
        private readonly AppDbContext _context;

        public RepositoryUnidadeDeMedida(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<UnidadeDeMedida>> GetAllAsync()
        {
            var entities = await _context.Set<UnidadeDeMedidaModel>()
                 .AsNoTracking()
                 .OrderBy(x => x.Simbolo)
                 .ToListAsync();
                

            return entities.ToModel();
        }

        public async Task<UnidadeDeMedida?> GetBySimboloAsync(string simbolo)
        {
            var entity =  await _context.Set<UnidadeDeMedidaModel>()
                .AsNoTracking()
                .Where( x => x.Simbolo == simbolo).FirstAsync();

            return entity.ToModel();
        }
    }
}
