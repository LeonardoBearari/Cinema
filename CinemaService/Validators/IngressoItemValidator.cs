using CinemaDomain;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaService.Validators
{
    public class IngressoItemValidator : AbstractValidator<IngressoItem>
    {
        public IngressoItemValidator()
        {

            RuleFor(ii => ii.Assento)
                .GreaterThan(0)
                .WithMessage("Assento deve ser maior que 0!");

            RuleFor(ii => ii.Fileira)
                .GreaterThan(0)
                .WithMessage("Fileira deve ser maior que 0!");
            // Ingresso reference may be null during creation; validar apenas se presente
            When(ii => ii.Ingresso != null, () => {
                RuleFor(ii => ii.Ingresso).NotNull().WithMessage("Ingresso deve ser informado");
            });
        }
    }
}
