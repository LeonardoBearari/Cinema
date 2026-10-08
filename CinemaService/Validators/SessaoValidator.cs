using CinemaDomain;
using FluentValidation;

namespace CinemaService.Validators
{
    public class SessaoValidator : AbstractValidator<Sessao>
    {
        public SessaoValidator()
        {
            RuleFor(s => s.Filme)
                .NotNull().WithMessage("Filme deve ser informado para a sessão")
                .Must(f => f != null && f.Id > 0).WithMessage("Filme inválido");

            RuleFor(s => s.Sala)
                .NotNull().WithMessage("Sala deve ser informada para a sessão")
                .Must(sala => sala != null && sala.Id > 0).WithMessage("Sala inválida");

            RuleFor(s => s.Data)
                .NotEmpty().WithMessage("Data da sessão deve ser informada");

            RuleFor(s => s.Preco)
                .GreaterThan(0).WithMessage("Preço da sessão deve ser maior que zero");
        }
    }
}
