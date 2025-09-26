using SbRf.Gestao.Core.Entities.CatalogoProduto;

namespace SbRf.Gestao.Core.Entities
{
    public class MapeamentoProdutoFornecedorItem
    {
        public MapeamentoProdutoFornecedorItem(Produto produto, string codigoProdutoFornecedor)
        {
            Produto = produto;
            CodigoProdutoFornecedor = codigoProdutoFornecedor;
        }
        public Produto Produto { get; set; }
        public string CodigoProdutoFornecedor { get; set; }
    }

}
