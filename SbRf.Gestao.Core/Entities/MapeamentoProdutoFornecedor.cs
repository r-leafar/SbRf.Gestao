namespace SbRf.Gestao.Core.Entities
{
    public class MapeamentoProdutoFornecedor
    {
        public Fornecedor Fornecedor { get; set; }
        public IEnumerable<MapeamentoProdutoFornecedorItem> Itens { get; set; }

        public MapeamentoProdutoFornecedor(Fornecedor fornecedor, IEnumerable<MapeamentoProdutoFornecedorItem> itens)
        {
            Fornecedor = fornecedor;
            Itens = itens;
        }
    }
}
