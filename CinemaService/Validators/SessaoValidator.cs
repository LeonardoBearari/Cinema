using CinemaDomain;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaService.Validators
{
    public class SessaoValidator : AbstractValidator<Sessao>
    {
        public SessaoValidator()
        {
            RuleFor(s => s.Filme).NotNull().WithMessage("Filme deve ser informado");
            RuleFor(s => s.Sala).NotNull().WithMessage("Sala deve ser informada");
            RuleFor(s => s.Data).NotEmpty().WithMessage("Data deve ser informada").NotNull().WithMessage("Data deve ser informada")
                .Must(d => d > DateTime.Now).WithMessage("Data da sessão deve ser no futuro");
            RuleFor(s => s.Preco).GreaterThan(0).WithMessage("Preço da sessão deve ser maior que 0!");
        }
    }
}
