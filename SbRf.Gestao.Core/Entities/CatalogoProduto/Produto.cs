namespace SbRf.Gestao.Core.Entities.CatalogoProduto
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public UnidadeDeMedida Unidade { get; set; }
        public string DescricaoCurta { get; set; }
        public Marca Marca { get; set; }
        public int Estoque { get; set; }
        public string Localizacao { get; set; }
    }
}
