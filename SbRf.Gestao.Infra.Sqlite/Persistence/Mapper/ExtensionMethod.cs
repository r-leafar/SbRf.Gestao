using SbRf.Gestao.Core.Entities.CatalogoProduto;
using SbRf.Gestao.Infra.Sqlite.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbRf.Gestao.Infra.Sqlite.Persistence.Mapper
{
    public static class ExtensionMethod
    {

        public static UnidadeDeMedida ToModel(this UnidadeDeMedidaModel entity)
        {
            if (entity == null) return null;
            return new UnidadeDeMedida
            {
                Nome = entity.Nome,
                Simbolo = entity.Simbolo,
                FatorConversaoBase = entity.FatorConversaoBase
            };
        }
        public static List<UnidadeDeMedida> ToModel(this IEnumerable<UnidadeDeMedidaModel> list)
        {
            if (list == null) return null;
            return list.Select(x => x.ToModel()).ToList();
        }
    }
}
