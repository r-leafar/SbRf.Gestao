namespace SbRf.Gestao.Core.Dtos
{
    public class MapeamentoProdutoFornecedorItemResponse
    {
        public MapeamentoProdutoFornecedorItemResponse(string fornecedorNome, string codigoProdutoFornecedor)
        {
            FornecedorNome = fornecedorNome;
            CodigoProdutoFornecedor = codigoProdutoFornecedor;
        }

        public string FornecedorNome { get; set; }
        public string CodigoProdutoFornecedor { get; set; }

    }
}
