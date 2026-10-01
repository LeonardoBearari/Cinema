using CinemaDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaRepository.Mapping
{
    public class IngressoMap : IEntityTypeConfiguration<Ingresso>
    {
        public void Configure(EntityTypeBuilder<Ingresso> builder)
        {
            builder.ToTable("Ingresso");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DataCompra).IsRequired(true);
            builder.Property(x => x.Sessao).IsRequired(true);
            builder.Property(x => x.ValorTotal).IsRequired(true);
            builder.Property(x => x.FormaPagamento).HasMaxLength(50).IsRequired(true);
            builder.HasMany(x => x.IngressoItens).WithOne(x=> x.Ingresso).OnDelete(DeleteBehavior.Cascade).IsRequired(true);
        }
    }

    public class IngressoItemMap : IEntityTypeConfiguration<IngressoItem>
    {
        public void Configure(EntityTypeBuilder<IngressoItem> builder)
        {
            builder.ToTable("Ingresso");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Assento).IsRequired(true);
            builder.Property(x => x.Fileira).IsRequired(true);
            builder.Property(x => x.MeiaEntrada).IsRequired(true);
            builder.HasOne(x => x.Ingresso).WithMany(x => x.IngressoItens).OnDelete(DeleteBehavior.Cascade).IsRequired(true);
        }
    }
}
