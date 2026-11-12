using CinemaDomain;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaService.Validators
{
    public class SalaValidator : AbstractValidator<Sala>
    {

        public SalaValidator()
        {
            RuleFor(s => s.Numero)
                .GreaterThan(0)
                .WithMessage("Número da sala deve ser maior que 0!");

            RuleFor(s => s.Capacidade)
                .GreaterThan(0)
                .WithMessage("Capacidade deve ser maior que 0!");

            RuleFor(s => s.Fileiras)
                .GreaterThan(0)
                .WithMessage("Fileiras devem ser maiores que 0!");

            RuleFor(s => s.Assentos)
                .GreaterThan(0)
                .WithMessage("Assentos devem ser maiores que 0!");

            RuleFor(s => s.Capacidade)
                .Equal(s => s.Fileiras * s.Assentos)
                .When(s => s.Fileiras > 0 && s.Assentos > 0)
                .WithMessage(
                    "Capacidade deve ser igual a Fileiras * Assentos.");
        }

    }
}
