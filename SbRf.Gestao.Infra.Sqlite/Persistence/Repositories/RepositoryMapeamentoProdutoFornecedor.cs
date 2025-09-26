using SbRf.Gestao.Core.Dtos;
using SbRf.Gestao.Core.Entities;
using SbRf.Gestao.Core.Interfaces;


namespace SbRf.Gestao.Infra.Sqlite.Persistence.Repositories
{
    public class RepositoryMapeamentoProdutoFornecedor : IRepositoryMapeamentoProdutoFornecedor
    {

        private readonly Fornecedor _fornecedor;

        public RepositoryMapeamentoProdutoFornecedor(Fornecedor fornecedor)
        {
            _fornecedor = fornecedor;
        }

        public IEnumerable<MapeamentoProdutoFornecedorItemResponse> Obter()
        {

             var lista = new List<MapeamentoProdutoFornecedorItemResponse> {
                 new MapeamentoProdutoFornecedorItemResponse( "Fornecedor A", "5" ),
                 new MapeamentoProdutoFornecedorItemResponse( "Fornecedor B", "15" ),
                 new MapeamentoProdutoFornecedorItemResponse( "Fornecedor C", "511" ),
                 new MapeamentoProdutoFornecedorItemResponse( "Fornecedor D", "45" ),
                 new MapeamentoProdutoFornecedorItemResponse( "Fornecedor E", "56" )
                 };


            return lista;
          
        }
    }
}
