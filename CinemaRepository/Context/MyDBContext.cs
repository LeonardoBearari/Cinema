using CinemaDomain;
using CinemaRepository.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace CinemaRepository.Context
{
    public class MyDBContext : DbContext
    {
        public DbSet<Genero> Genero { get; set; }
        public DbSet<Filme> Filme { get; set; }
        public DbSet<Sala> Sala { get; set; }
        public DbSet<Sessao> Sessao { get; set; }
        public DbSet<Ingresso> Ingresso { get; set; }
        public DbSet<IngressoItem> IngressoItem { get; set; }

        public MyDBContext()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Genero>(new GeneroMap().Configure);
            modelBuilder.Entity<Filme>(new FilmeMap().Configure);
            modelBuilder.Entity<Sala>(new SalaMap().Configure);
            modelBuilder.Entity<Sessao>(new SessaoMap().Configure);
            modelBuilder.Entity<Ingresso>(new IngressoMap().Configure);
            modelBuilder.Entity<IngressoItem>(new IngressoItemMap().Configure);
        }

    }
}
