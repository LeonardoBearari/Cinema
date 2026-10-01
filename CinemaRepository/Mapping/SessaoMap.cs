using CinemaDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaRepository.Mapping
{
    public class SessaoMap : IEntityTypeConfiguration<Sessao>
    {
        public void Configure(EntityTypeBuilder<Sessao> builder)
        {
            builder.ToTable("Sessao");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Data).IsRequired(true);
            builder.Property(x => x.Sala).IsRequired(true);
            builder.Property(x => x.Preco).IsRequired(true);
        }
    }
}
