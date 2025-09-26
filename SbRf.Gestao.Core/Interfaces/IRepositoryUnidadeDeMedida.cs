using SbRf.Gestao.Core.Entities.CatalogoProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbRf.Gestao.Core.Interfaces
{
    public interface IRepositoryUnidadeDeMedida
    {

        Task<IEnumerable<UnidadeDeMedida>> GetAllAsync();
        Task<UnidadeDeMedida?> GetBySimboloAsync(string simbolo);
    }
}
