using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SbRf.Gestao.Core.Entities;
using SbRf.Gestao.Infra.Sqlite.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SbRf.Gestao.Infra.Sqlite.Persistence.Configurations
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<ProdutoModel>
    {
        public void Configure(EntityTypeBuilder<ProdutoModel> builder)
        {
            builder.ToTable("produtos");
            builder.HasKey(x => x.Id);
        }
    }
}
