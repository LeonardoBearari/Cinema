using CinemaDomain;
using FluentValidation;

namespace CinemaService.Validators
{
    public class SalaValidator : AbstractValidator<Sala>
    {
        public SalaValidator()
        {
            RuleFor(s => s.Numero)
                .GreaterThan(0).WithMessage("Número da sala deve ser maior que zero");

            RuleFor(s => s.Capacidade)
                .GreaterThan(0).WithMessage("Capacidade deve ser maior que zero");

            RuleFor(s => s.Fileiras)
                .GreaterThan(0).WithMessage("Fileiras deve ser maior que zero");

            RuleFor(s => s.Assentos)
                .GreaterThan(0).WithMessage("Assentos por fileira deve ser maior que zero");

            RuleFor(s => s)
                .Must(s => s.Capacidade == s.Fileiras * s.Assentos)
                .WithMessage("Capacidade deve ser igual a Fileiras x Assentos por fileira");



        }
    }
}
