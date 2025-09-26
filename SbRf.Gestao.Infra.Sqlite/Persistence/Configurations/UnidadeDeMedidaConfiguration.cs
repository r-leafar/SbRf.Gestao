using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SbRf.Gestao.Infra.Sqlite.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbRf.Gestao.Infra.Sqlite.Persistence.Configurations
{
    public class UnidadeDeMedidaConfiguration : IEntityTypeConfiguration<UnidadeDeMedidaModel>
    {
        public void Configure(EntityTypeBuilder<UnidadeDeMedidaModel> builder)
        {
            builder.ToTable("produto_unidade_medida");

            builder.HasKey(x => x.Simbolo);

            builder.HasData(
            //Embalagem
            new UnidadeDeMedidaModel("Unidade", "UN", 1),
            new UnidadeDeMedidaModel("Caixa", "CX", 1),
            new UnidadeDeMedidaModel("Duzia ", "DZ", 12),
            new UnidadeDeMedidaModel("Par", "PA ", 2),
            new UnidadeDeMedidaModel("Pacote", "PC", 1),
            new UnidadeDeMedidaModel("Rolo", "RL ", 1),
            //Peso
            new UnidadeDeMedidaModel("Quilograma", "KG", 1),
            new UnidadeDeMedidaModel("Grama ", "G ", 0.001),
            //Volume
            new UnidadeDeMedidaModel("Litro", "L", 1),
            new UnidadeDeMedidaModel("Metro Cúbico", "M3 ", 1000),
            new UnidadeDeMedidaModel("Mililitro", "ML ", 0.001));
        }
    }
}
