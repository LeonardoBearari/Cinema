using CinemaDomain;
using FluentValidation;

namespace CinemaService.Validators
{
    public class FilmeValidator : AbstractValidator<Filme>
    {
        public FilmeValidator()
        {
            RuleFor(f => f.Nome)
                .NotEmpty().WithMessage("Nome do filme deve ser informado!")
                .Length(3, 150).WithMessage("Nome do filme deve conter entre 3 e 150 caracteres");

            RuleFor(f => f.Classificacao)
                .NotEmpty().WithMessage("Classificação deve ser informada!")
                .MaximumLength(10).WithMessage("Classificação inválida");

            RuleFor(f => f.Genero)
                .NotNull().WithMessage("Gênero deve ser informado!")
                .Must(g => g != null && g.Id > 0).WithMessage("Gênero inválido");

            RuleFor(f => f.Duracao)
                .GreaterThan(0).WithMessage("Duração deve ser maior que zero (minutos)")
                .LessThanOrEqualTo(600).WithMessage("Duração parece excessiva");
        }
    }
}
