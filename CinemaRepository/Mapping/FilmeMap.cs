using CinemaDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaRepository.Mapping
{
    public class FilmeMap : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder.ToTable("Filme");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired(true).HasMaxLength(50);
            builder.Property(x => x.Classificacao).IsRequired(true).HasMaxLength(20);
            builder.HasOne(x => x.Nome).WithMany().IsRequired(true); // relacionamento com genero
            builder.Property(x => x.Duracao).HasDefaultValue(20);
        }
    }
}
