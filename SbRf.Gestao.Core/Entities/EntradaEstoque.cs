using SbRf.Gestao.Core.Interfaces;

namespace SbRf.Gestao.Core.Entities
{
    public class EntradaEstoque
    {
        public Fornecedor Fornecedor { get; set; }

        public IOrigemMovimentacaoEstoque Origem { get => new OrigemEntrada(); }
        public List<EntradaEstoqueItem> Itens { get; set; }

        private List<MapeamentoProdutoFornecedorItem> ItensMapeamento;
        public decimal Quantidade { get; set; }
        public decimal Total { get; set; }

        public EntradaEstoque(Fornecedor fornecedor, List<EntradaEstoqueItem> itens, decimal quantidade, decimal total)
        {
            Fornecedor = fornecedor;
            Itens = itens;
            Quantidade = quantidade;
            Total = total;
        }
    }
}
