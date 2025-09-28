using SbRf.Gestao.Core.Shared.Ensure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbRf.Gestao.Core.Entities.CatalogoProduto
{
    public class ProdutoClassificacao
    {
        private string _id;
        private string _nome;

        public required string Id
        {
            get { return _id; }
            set
            {
               Ensure.NotNullOrWhiteSpace(value, nameof(Id));
               ValidarId(value);
               _id = RemoverZerosAEsquerda(value);
            }
        }
        public required string Nome
        {
            get { return _nome; }
            set
            {
                Ensure.NotNullOrWhiteSpace(value, nameof(Nome));
                _nome = value;
            }
        }

        private void ValidarId(string id)
        {
            string[] partes = id.Split('.');

            if (partes.Length != 4)
            {
                throw new ArgumentException("A classificação precisa ter 4 níveis", nameof(Id));
            }

            foreach (string parte in partes)
            {
                // Verifica se há pontos duplos, no início ou no fim (resultando em parte vazia)
                if (string.IsNullOrEmpty(parte))
                {
                    throw new ArgumentException("Classificação deve estar no formato X.X.X.X (ex: 1.1.0.0)", nameof(Id));
                }

                // Verifica se a parte é um número inteiro válido
                if (!int.TryParse(parte, out _))
                {
                    throw new ArgumentException("Foi informado um valor que não é um número.", nameof(Id));
                }
            }
        }
        private string RemoverZerosAEsquerda(string id)
        {
            string[] partes = id.Split('.');
            int[] final = new int[partes.Length];

            for (int i = 0; i < final.Length; i++)
            {
                int.TryParse(partes[i], out final[i]);
            }
            return string.Join('.', final);
        }
    }
}
