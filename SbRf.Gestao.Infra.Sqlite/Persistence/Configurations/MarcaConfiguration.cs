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
    public class MarcaConfiguration : IEntityTypeConfiguration<MarcaModel>
    {
        public void Configure(EntityTypeBuilder<MarcaModel> builder)
        {
            builder.ToTable("produto_marca");
            builder.HasKey(x => x.Id);
        }
    }
}
