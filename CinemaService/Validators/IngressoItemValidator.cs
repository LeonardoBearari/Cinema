using CinemaDomain;
using FluentValidation;

namespace CinemaService.Validators
{
    internal class IngressoItemValidator : AbstractValidator<IngressoItem>
    {
        public IngressoItemValidator()
        {
            RuleFor(ii => ii.Assento)
                .GreaterThan(0).WithMessage("Assento deve ser maior que zero");

            RuleFor(ii => ii.Fileira)
                .GreaterThan(0).WithMessage("Fileira deve ser maior que zero");
        }
    }
}
