using SbRf.Gestao.Core.Entities.CatalogoProduto;

namespace SbRf.Gestao.Core.Tests
{
    public class ProdutoClassificacaoTest
    {
        [Fact]
        public void ClassificaoComUmNivel()
        {
            var classificacao = new ProdutoClassificacao
            {
                Id = "1",
                Nome = "Eletrônicos"
            };

            Assert.False(classificacao.Id.Contains('.'));
        }
    }
}
