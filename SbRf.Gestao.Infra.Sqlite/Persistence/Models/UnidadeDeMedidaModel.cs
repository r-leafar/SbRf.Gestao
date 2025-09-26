using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbRf.Gestao.Infra.Sqlite.Persistence.Models
{
    public class UnidadeDeMedidaModel
    {
        public string Nome { get; set; }
        public string Simbolo { get; set; }
        public double FatorConversaoBase { get; set; } // ex.: base = kg

        public UnidadeDeMedidaModel() { }
        public UnidadeDeMedidaModel(string nome, string simbolo, double fator)
        {
            Nome = nome;
            Simbolo = simbolo;
            FatorConversaoBase = fator;
        }
    }
}
