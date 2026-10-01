using CinemaDomain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;



namespace CinemaTest
{
    [TestClass]
    public class TestCinemaRepository
    {
        public partial class MyDBContext : DbContext
        {
            public DbSet <Genero> Genero { get; set; }
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

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                base.OnConfiguring(optionsBuilder);
                var server = "localhost";
                var port = "5432";
                var username = "postgres";
                var password = "ifsp";
                var database = "CinemaDB";
                var conStr = $"Host={server};Port={port};Database={database};Username={username};Password={password}";

                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseNpgsql(conStr);
                }
            }
        }
        [TestMethod]
        public void CriarBanco()
        {
            using (var db = new MyDBContext())
            {
                Assert.IsNotNull(db);
            }
        }

        [TestMethod]
        public void InsereGenero()
        {
            using (var db = new MyDBContext())
            {
                var genero = new Genero { Id = 1, Nome = "Comedia" };
                db.Genero.Add(genero);
                genero = new Genero { Id = 2, Nome = "Ação" };
                db.Genero.Add(genero);
                genero = new Genero { Id = 3, Nome = "Drama" };
                db.Genero.Add(genero);
                genero = new Genero { Id = 4, Nome = "Terror" };
                db.Genero.Add(genero);
                genero = new Genero { Id = 5, Nome = "Animação" };
                db.Genero.Add(genero);
                db.SaveChanges();
            }
        }

        [TestMethod]
        public void ListarGenero()
        {
            using (var db = new MyDBContext())
            {
                foreach (var item in db.Genero)
                {
                    Console.WriteLine(JsonSerializer.Serialize(item));
                }
            }
        }
        
        [TestMethod]
        public void InsereFilme()
        {
            using (var db = new MyDBContext())
            {
                var generoComedia = db.Genero.FirstOrDefault(x=>x.Id==1);
                var generoAcao = db.Genero.FirstOrDefault(x => x.Id == 2);
                var generoDrama = db.Genero.FirstOrDefault(x => x.Id == 3);
                var generoTerror = db.Genero.FirstOrDefault(x => x.Id == 4);
                var generoAnimacao = db.Genero.FirstOrDefault(x => x.Id == 5);

                var filme = new Filme { Id = 1, Nome = "Gente Grande", Classificacao = "+14", Genero = generoComedia, Duracao = 240 };
                db.Filme.Add(filme);
                filme = new Filme { Id = 2, Nome = "Velozes e furiosos", Classificacao = "+14", Genero = generoAcao, Duracao = 240 };
                db.Filme.Add(filme);
                filme = new Filme { Id = 3, Nome = "A garota do trem", Classificacao = "+16", Genero = generoDrama, Duracao = 240 };
                db.Filme.Add(filme);
                filme = new Filme { Id = 4, Nome = "Ghost", Classificacao = "+18", Genero = generoTerror, Duracao = 240 };
                db.Filme.Add(filme);
                filme = new Filme { Id = 5, Nome = "Divertidamente", Classificacao = "+10", Genero = generoAnimacao, Duracao = 240 };
                db.Filme.Add(filme);
                db.SaveChanges();
            }
        }

        [TestMethod]
        public void ListarFilme()
        {
            using (var db = new MyDBContext())
            {
                foreach (var item in db.Filme)
                {
                    Console.WriteLine(JsonSerializer.Serialize(item));
                }
            }
        }

        [TestMethod]
        public void InsereSala()
        {
            using (var db = new MyDBContext())
            {
                
                var sala = new Sala { Id = 1, Numero = 1, Assentos = 20, Capacidade = 100, Fileiras = 5 };
                db.Sala.Add(sala);
                sala = new Sala { Id = 2, Numero = 2, Assentos = 20, Capacidade = 140, Fileiras = 7 };
                db.Sala.Add(sala);
                
                db.SaveChanges();
            }
        }

        [TestMethod]
        public void ListarSala()
        {
            using (var db = new MyDBContext())
            {
                foreach (var item in db.Sala)
                {
                    Console.WriteLine(JsonSerializer.Serialize(item));
                }
            }
        }

        [TestMethod]
        public void InsereSessao()
        {
            using (var db = new MyDBContext())
            {
                var filmeGenteGrande = db.Filme.FirstOrDefault(x => x.Id == 1);
                var filmeGhost = db.Filme.FirstOrDefault(x => x.Id == 4);
                var sala1 = db.Sala.FirstOrDefault(x => x.Id == 1);
                var sala2 = db.Sala.FirstOrDefault(x => x.Id == 2);

                var dataSessao1 = new DateTime(2026, 10, 15, 18, 30, 0); // 15/10/2026 às 18:30
                var dataSessao2 = new DateTime(2026, 10, 15, 21, 00, 0); // 15/10/2026 às 21:00

                var sessao = new Sessao { Id = 1, Filme = filmeGenteGrande, Data = dataSessao1, Preco = 30, Sala = sala1 }; // perguntar como coloca data normal pro murilo
                db.Sessao.Add(sessao);
                sessao = new Sessao { Id = 2, Filme = filmeGhost, Data = dataSessao2, Preco = 30, Sala = sala2 };
                db.Sessao.Add(sessao);

                db.SaveChanges();
            }
        }

        [TestMethod]
        public void ListarSessao()
        {
            using (var db = new MyDBContext())
            {
                foreach (var item in db.Sessao)
                {
                    Console.WriteLine(JsonSerializer.Serialize(item));
                }
            }
        }

        [TestMethod]
        public void InsereIngresso()
        {
            using (var db = new MyDBContext())
            {
                var sessao1 = db.Sessao.FirstOrDefault(x => x.Id == 1);
                var sessao2 = db.Sessao.FirstOrDefault(x => x.Id == 2);

                var dataCompra1 = new DateTime(2026, 10, 15, 18, 30, 0); // 15/10/2026 às 18:30
                var dataCompra2 = new DateTime(2026, 10, 15, 21, 00, 0); // 15/10/2026 às 21:00

                var ingresso = new Ingresso { Id = 1, DataCompra = dataCompra1, Documento = "491239123", FormaPagamento = "Credito", IngressoItens = new List<IngressoItem>(), Sessao = sessao1, ValorTotal = 15};
                
                ingresso.IngressoItens.Add(new IngressoItem { Id = 1, Assento = 3, Fileira = 4, Ingresso = ingresso, MeiaEntrada = true });
                ingresso.IngressoItens.Add(new IngressoItem { Id = 2, Assento = 4, Fileira = 4, Ingresso = ingresso, MeiaEntrada = true });
                db.Ingresso.Add(ingresso);
                
                
                
                ingresso = new Ingresso { Id = 2, DataCompra = dataCompra1, Documento = "2374878231", FormaPagamento = "Debito", IngressoItens = new List<IngressoItem>(), Sessao = sessao1, ValorTotal = 30 };
                ingresso.IngressoItens.Add(new IngressoItem { Id = 3, Assento = 45, Fileira = 7, Ingresso = ingresso, MeiaEntrada = false });
                db.Ingresso.Add(ingresso);

                ingresso = new Ingresso { Id = 3, DataCompra = dataCompra2, Documento = "7120319123", FormaPagamento = "Credito", IngressoItens = new List<IngressoItem>(), Sessao = sessao2, ValorTotal = 15 };
                ingresso.IngressoItens.Add(new IngressoItem { Id = 4, Assento = 15, Fileira = 8, Ingresso = ingresso, MeiaEntrada = false });
                ingresso.IngressoItens.Add(new IngressoItem { Id = 5, Assento = 16, Fileira = 8, Ingresso = ingresso, MeiaEntrada = true });
                ingresso.IngressoItens.Add(new IngressoItem { Id = 6, Assento = 17, Fileira = 8, Ingresso = ingresso, MeiaEntrada = false });
                db.Ingresso.Add(ingresso);

                ingresso = new Ingresso { Id = 4, DataCompra = dataCompra1, Documento = "1823812030", FormaPagamento = "Dinheiro", IngressoItens = new List<IngressoItem>(), Sessao = sessao1, ValorTotal = 30 };
                ingresso.IngressoItens.Add(new IngressoItem { Id = 7, Assento = 67, Fileira = 6, Ingresso = ingresso, MeiaEntrada = false });
                db.Ingresso.Add(ingresso);

                ingresso = new Ingresso { Id = 5, DataCompra = dataCompra2, Documento = "1923213123", FormaPagamento = "Pix", IngressoItens = new List<IngressoItem>(), Sessao = sessao2, ValorTotal = 15 };
                ingresso.IngressoItens.Add(new IngressoItem { Id = 8, Assento = 127, Fileira = 9, Ingresso = ingresso, MeiaEntrada = false });
                db.Ingresso.Add(ingresso);

                db.SaveChanges();
            }
        }

        [TestMethod]
        public void ListarIngresso()
        {
            using (var db = new MyDBContext())
            {
                foreach (var item in db.Ingresso)
                {
                    Console.WriteLine(JsonSerializer.Serialize(item));
                }
            }
        }

      
    }
}
