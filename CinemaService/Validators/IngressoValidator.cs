using CinemaDomain;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaService.Validators
{
    public class IngressoValidator : AbstractValidator<Ingresso>
    {
        public IngressoValidator()
        {
            RuleFor(i => i.Documento).NotEmpty().WithMessage("Documento deve ser informado").NotNull().WithMessage("Documento deve ser informado").Length(11, 20).WithMessage("Documento deve conter entre 11 e 20 caracteres");
            RuleFor(i => i.Sessao).NotNull().WithMessage("Sessão deve ser informada");
            RuleFor(i => i.DataCompra).NotEmpty().WithMessage("Data da compra deve ser informada").NotNull().WithMessage("Data da compra deve ser informada").Must(d => d <= DateTime.Now).WithMessage("Data da compra não pode ser no futuro");
            RuleFor(i => i.IngressoItens)
                .NotNull()
                .WithMessage("Itens do ingresso devem ser informados!")
                .NotEmpty()
                .WithMessage("Deve haver pelo menos um item no ingresso!");
            RuleForEach(i => i.IngressoItens)
                .SetValidator(new IngressoItemValidator());
            RuleFor(i => i.ValorTotal)
                .GreaterThan(0)
                .WithMessage("Valor total deve ser maior que 0!");
            RuleFor(i => i.FormaPagamento).NotEmpty().WithMessage("Forma de pagamento deve ser informada").NotNull().WithMessage("Forma de pagamento deve ser informada").Length(3, 30).WithMessage("Forma de pagamento deve conter entre 3 e 30 caracteres");
        }
    }
}
