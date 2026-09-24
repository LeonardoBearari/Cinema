using CinemaDomain;
using System.Diagnostics;
using System.Text.Json;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
using static System.Net.WebRequestMethods;

namespace CinemaTest
{
    [TestClass]
    public sealed class TestCinemaDomain
    {
        private JsonSerializerOptions OptionsJson()
        {
            return new JsonSerializerOptions { WriteIndented = true };
        }

        [TestMethod]
        public void TestGenero()
        {
            var genero = new Genero
            {
                Id = 1,
                Nome = "Suspense"
            };

            var generoJson = JsonSerializer.Serialize(genero, OptionsJson());
            Debug.WriteLine(generoJson);
            Assert.IsNotNull(generoJson);
        }

        [TestMethod]
        public void TestFilme()
        {
            var genero1 = new Genero
            {
                Id = 1,
                Nome = "Suspense"
            };
            var genero2 = new Genero
            {
                Id = 2,
                Nome = "Comedia"
            };
            var filme = new Filme
            {
                Id = 1,
                Nome = "Jurassic PArk",
                Genero = genero1,
                Classificacao = "+18",
                Duracao = 120
            };

            var filmeJson = JsonSerializer.Serialize(filme, OptionsJson());
            Debug.WriteLine(filmeJson);
            Assert.IsNotNull(filmeJson);
        }

        [TestMethod]
        public void TestSala()
        {
            var sala = new Sala
            {
                Numero = 1,
                Capacidade = 45,
                Fileiras = 9,
                Assentos = 5
            };

            var salaJson = JsonSerializer.Serialize(sala, OptionsJson());
            Debug.WriteLine(salaJson);
            Assert.IsNotNull(salaJson);
        }

        [TestMethod]
        public void Sessao()
        {
            var genero = new Genero { Id = 1, Nome = "Ação" };
            var filme = new Filme { Id = 1, Nome = "Matrix", Genero = genero, Classificacao = "+16", Duracao = 136 };
            var sala = new Sala { Id = 1, Numero = 2, Capacidade = 100, Assentos = 20, Fileiras = 5 };

            var sessao = new Sessao
            {
                Id = 1,
                Filme = filme,
                Sala = sala,
                Data = DateTime.Now,
                Preco = 30.00m
            };

            var sessaoJson = JsonSerializer.Serialize(sessao, OptionsJson());
            Debug.WriteLine(sessaoJson);
            Assert.IsNotNull(sessaoJson);
        }

        [TestMethod]
        public void Ingresso()
        {
            var ingresso = new Ingresso
            {
                Id = 1,
                Documento = "493.196.628-43",
                DataCompra = DateTime.Now,
                ValorTotal = 30.00m,
                FormaPagamento = "Cartao de Credito",
                IngressoItens = new List<IngressoItem>()
            };

            var ingressoJson = JsonSerializer.Serialize(ingresso, OptionsJson());
            Debug.WriteLine(ingressoJson);
            Assert.IsNotNull(ingressoJson);
        }

        [TestMethod]
        public void TestIngressoItem()
        {

            var ingressoitem = new IngressoItem
            {
                Id = 1,
                Assento = 3,
                Fileira = 5,
                MeiaEntrada = true

            };

            var ingressoitemJson = JsonSerializer.Serialize(ingressoitem, OptionsJson());
            Debug.WriteLine(ingressoitemJson);
            Assert.IsNotNull(ingressoitemJson);
        }
    }
}
