using CinemaDomain;
using Microsoft.Extensions.DependencyInjection;
using CinemaRepository.Context;
using Microsoft.EntityFrameworkCore;
using CinemaRepository.Base;
using CinemaService.Base;
using AutoMapper;
using Microsoft.Extensions.Logging.Abstractions;
using CinemaService.Validators;
using System.Text.Json;

namespace CinemaTest
{
    [TestClass]
    public class TestCinemaService
    {
        private ServiceCollection services;

        public ServiceProvider ConfigureServices()
        {
            var conStr = $"Host=localhost;Port=5432;Database=CinemaDB;Username=postgres;Password=ifsp";

            services = new ServiceCollection();
            services.AddDbContext<MyDBContext>(options =>options.UseNpgsql(conStr));
            services.AddScoped<IBaseRepository<Genero>, BaseRepository<Genero>>();
            services.AddScoped<IBaseService<Genero>, BaseService<Genero>>();
            services.AddSingleton(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Genero, Genero>();
            }, NullLoggerFactory.Instance).CreateMapper());
            return services.BuildServiceProvider();
        }

      [TestMethod]
        public void TestGeneroService()
        {
            var serviceProvider = ConfigureServices();
            var generoService = serviceProvider.GetService<IBaseService<Genero>>();
            var genero = new Genero { Id = 6, Nome = "Romance" };
            var result = generoService.Create<Genero, Genero, GeneroValidator>(genero);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }
    }
}
