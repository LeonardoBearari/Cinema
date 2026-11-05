using CinemaDomain;
using FluentValidation;

namespace CinemaService.Validators
{
    public class FilmeValidator : AbstractValidator<Filme>
    {
        public FilmeValidator()
        {
            RuleFor(melancia => melancia.Nome)
               .NotEmpty().WithMessage("Nome deve ser informado!")
               .NotNull().WithMessage("nome deve ser informado!")
               .Length(5, 50).WithMessage("Nome deve conter entre 5 e 50 caracteres!");
            RuleFor(g => g.Classificacao)
               .NotEmpty().WithMessage("Classificação deve ser informada!")
               .NotNull().WithMessage("Classificação deve ser informada!")
               .Length(5, 50).WithMessage("Classificação deve conter entre 5 e 50 caracteres!");
            RuleFor(g => g.Genero)
              .NotNull().WithMessage("Genero deve ser informado!");
            RuleFor(g => g.Duracao)
              .GreaterThanOrEqualTo(1).WithMessage("Duração deve ser maior que 0!");
        }
    }
}