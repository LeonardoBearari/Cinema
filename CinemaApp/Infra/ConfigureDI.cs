using CinemaApp.Cadastros;
using CinemaApp.Models;
using CinemaDomain;
using AutoMapper;
using CinemaRepository.Base;
using CinemaRepository.Context;
using CinemaService.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;

namespace CinemaApp.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection Services;
        public static IServiceProvider ServiceProvider;
        public static void Configure()
        {
            Services = new ServiceCollection();

            #region Banco de Dados Injeção de Dependência            
            var strCon = File.ReadAllText("Config/ConfigDB.txt");
            Services.AddDbContext<MyDBContext>(options => options.UseNpgsql(strCon));
            #endregion

            #region Repositórios Injeção de Dependência
            Services.AddScoped<IBaseRepository<Genero>, BaseRepository<Genero>>();
            Services.AddScoped<IBaseRepository<Filme>, BaseRepository<Filme>>();
            Services.AddScoped<IBaseRepository<Sala>, BaseRepository<Sala>>();
            Services.AddScoped<IBaseRepository<Sessao>, BaseRepository<Sessao>>();
            Services.AddScoped<IBaseRepository<Ingresso>, BaseRepository<Ingresso>>();
            #endregion

            #region Serviços Injeção de Dependência
            Services.AddScoped<IBaseService<Genero>, BaseService<Genero>>();
            Services.AddScoped<IBaseService<Filme>, BaseService<Filme>>();
            Services.AddScoped<IBaseService<Sala>, BaseService<Sala>>();
            Services.AddScoped<IBaseService<Sessao>, BaseService<Sessao>>();
            Services.AddScoped<IBaseService<Ingresso>, BaseService<Ingresso>>();
            #endregion

            #region AutoMapper Injeção de Dependência
            var mapperConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Genero, GeneroViewModel>().ReverseMap();

                config.CreateMap<Filme, FilmeViewModel>()
                    .ForMember(dest => dest.GeneroId, opt => opt.MapFrom(src => src.Genero.Id))
                    .ForMember(dest => dest.GeneroNome, opt => opt.MapFrom(src => src.Genero.Nome));

                config.CreateMap<Sala, SalaViewModel>().ReverseMap();

                config.CreateMap<Sessao, SessaoViewModel>().ForMember(d => d.FilmeId, o => o.MapFrom(s => s.Filme.Id)).ForMember(d => d.FilmeNome, o => o.MapFrom(s => s.Filme.Nome)).ForMember(d => d.Classificacao, o => o.MapFrom(s => s.Filme.Classificacao)).ForMember(d => d.SalaId, o => o.MapFrom(s => s.Sala.Id)).ForMember(d => d.SalaNome, o => o.MapFrom(s => s.Sala.Numero.ToString()));

                config.CreateMap<Ingresso, IngressoViewModel>().ForMember(d => d.SessaoId, o => o.MapFrom(i => i.Sessao.Id)).ForMember(d => d.Filme, o => o.MapFrom(i => i.Sessao.Filme.Nome)).ForMember(d => d.Classificacao, o => o.MapFrom(i => i.Sessao.Filme.Classificacao)).ForMember(d => d.DataVenda, o => o.MapFrom(i => i.DataCompra));

                config.CreateMap<IngressoItem, IngressoItemViewModel>().ReverseMap(); }, NullLoggerFactory.Instance);

            Services.AddSingleton(mapperConfig.CreateMapper());

            #endregion

            #region Injeção de Dependência de Formulários
            Services.AddTransient<CadastroGenero, CadastroGenero>();
            Services.AddTransient<CadastroFilme, CadastroFilme>();
            Services.AddTransient<CadastroSala, CadastroSala>();
            Services.AddTransient<CadastroSessao, CadastroSessao>();
            Services.AddTransient<CadastroIngresso>();
            #endregion

            ServiceProvider = Services.BuildServiceProvider();
        }
    }
}