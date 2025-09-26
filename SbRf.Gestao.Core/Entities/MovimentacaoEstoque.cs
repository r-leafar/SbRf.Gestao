using App.Core.Enums;
using SbRf.Gestao.Core.Entities.CatalogoProduto;
using SbRf.Gestao.Core.Interfaces;

namespace SbRf.Gestao.Core.Entities
{
    public class MovimentacaoEstoque
    {
        public Produto Produto { get; set; }
        public decimal Quantidade { get; set; }
        public TipoMovimentacao Tipo { get; set; }
        public IOrigemMovimentacaoEstoque Origem { get; set; }
        public int OrigemId { get; set; }

    }
}
