using CinemaDomain;
using System.Diagnostics;
using System.Text.Json;

namespace CinemaTest
{
    [TestClass]
    public sealed class TestCinemaDomain
    {
        private JsonSerializerOptions OptionsJson()
        {
            return new JsonSerializerOptions {  WriteIndented = true };
        }

        [TestMethod]
        public void TestGenero()
        {
            var genero = new Genero{  
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
            var genero1 = new Genero{
                Id = 1,
                Nome = "Suspense"
            };
            var genero2 = new Genero{
                Id = 2,
                Nome = "Comedia"
            };
            var filme = new Filme{
                Id = 1,
                Nome = "Jurassic PArk", Genero = genero1,
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
            var numero = 1;
            var capacidade = 45;
            var fileira = 9;
            var assentos = 5;

        }
    }
}
