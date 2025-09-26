using SbRf.Gestao.Core.Interfaces;

namespace SbRf.Gestao.Core.Entities
{
    public class OrigemEntrada : IOrigemMovimentacaoEstoque
    {
        public int OrigemId { get; }
        public string OrigemNome { get; }

        public OrigemEntrada()
        {
            OrigemId = 1;
            OrigemNome = "Entrada de Estoque";
        }
    }
}
