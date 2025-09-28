using SbRf.Gestao.Core.Entities.CatalogoProduto;

namespace SbRf.Gestao.Core.Tests
{
    public class ProdutoClassificacaoTest
    {
        [Fact]
        public void ClassificaoComMenosDeQuatroNiveisLancaExcessao()
        {
            var exception = Assert.Throws<ArgumentException>(() => new ProdutoClassificacao() { Id = "1.1", Nome = "Setor" });

            Assert.Equal("A classificação precisa ter 4 níveis (Parameter 'Id')", exception.Message);
        }
        [Fact]
        public void ClassificacaoLancaExcecaoQuandoIdEhNullOuVazia()
        {
            var exception = Assert.Throws<ArgumentException>(() => new ProdutoClassificacao() { Id = "",Nome="Setor" });

            Assert.Equal("O valor não pode ser vazio. (Parameter 'Id')", exception.Message);
        }

        [Fact]
        public void ClassificacaoLancaExcecaoQuandoNomeEhNullOuVazia()
        {
            var exception = Assert.Throws<ArgumentException>(() => new ProdutoClassificacao() { Id = "1.0.0.0", Nome = "" });

            Assert.Equal("O valor não pode ser vazio. (Parameter 'Nome')", exception.Message);
        }
        [Fact]
        public void ClassificacaoLancaExcecaoQuandoFormatoEhInvalido()
        {
            var exception = Assert.Throws<ArgumentException>(() => new ProdutoClassificacao() { Id = "1.2.3.", Nome = "Setor" });

            Assert.Equal("Classificação deve estar no formato X.X.X.X (ex: 1.1.0.0) (Parameter 'Id')", exception.Message);
        }
        [Fact]
        public void ClassificacaoLancaExcecaoQuandoFormatoLetra()
        {
            var exception = Assert.Throws<ArgumentException>(() => new ProdutoClassificacao() { Id = "1.2.3.A", Nome = "Setor" });

            Assert.Equal("Foi informado um valor que não é um número. (Parameter 'Id')", exception.Message);
        }
    }
}
