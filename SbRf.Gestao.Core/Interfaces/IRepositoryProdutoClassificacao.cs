using SbRf.Gestao.Core.Entities.CatalogoProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbRf.Gestao.Core.Interfaces
{
    interface IRepositoryProdutoClassificacao
    {
        public  Task<ProdutoClassificacao> CriarAsync(ProdutoClassificacao entidade);

        public Task<ProdutoClassificacao?> ObterPorIdAsync(string id);

        public Task AtualizarAsync(ProdutoClassificacao entidade);

        public Task ApagarAsync(ProdutoClassificacao entidade);
    }
}
