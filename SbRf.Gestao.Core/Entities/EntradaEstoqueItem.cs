using SbRf.Gestao.Core.Entities.CatalogoProduto;

namespace SbRf.Gestao.Core.Entities
{
    public class EntradaEstoqueItem
    {
        public string CodigoFornecedor { get; set; }
        public Produto Produto { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get { return Quantidade * ValorUnitario; } }

    }
}
