

namespace SbRf.Gestao.Infra.Sqlite.Persistence.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public UnidadeDeMedidaModel Unidade { get; set; }
        public string DescricaoCurta { get; set; }
        public MarcaModel Marca { get; set; }
        public int Estoque { get; set; }
        public string Localizacao { get; set; }
    }
}
