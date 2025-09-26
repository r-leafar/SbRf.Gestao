using SbRf.Gestao.Core.Dtos;

namespace SbRf.Gestao.Core.Interfaces
{
    public interface IRepositoryMapeamentoProdutoFornecedor
    {
        public IEnumerable<MapeamentoProdutoFornecedorItemResponse> Obter();
    }
}
