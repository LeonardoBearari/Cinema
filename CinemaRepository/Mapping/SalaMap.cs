using CinemaDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaRepository.Mapping
{
    public class SalaMap : IEntityTypeConfiguration<Sala>
    {
    public void Configure(EntityTypeBuilder<Sala> builder)
        {
            builder.ToTable("Filme");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Numero).IsRequired(true);
            builder.Property(x => x.Capacidade).IsRequired(true);
            builder.Property(x => x.Fileiras).IsRequired(true);
            builder.Property(x => x.Assentos).IsRequired(true);
        }
    }
}
