using CinemaDomain;
using FluentValidation;
using System.Linq;
using System.Collections.Generic;

namespace CinemaService.Validators
{
    internal class IngressoValidator : AbstractValidator<Ingresso>
    {
        public IngressoValidator()
        {
            RuleFor(i => i.Documento)
                .NotEmpty().WithMessage("Documento do comprador deve ser informado")
                .Length(5, 30).WithMessage("Documento deve conter entre 5 e 30 caracteres");

            RuleFor(i => i.Sessao)
                .NotNull().WithMessage("Sessão deve ser informada para o ingresso")
                .Must(s => s != null && s.Id > 0).WithMessage("Sessão inválida");

            RuleFor(i => i.DataCompra)
                .NotEmpty().WithMessage("Data da compra deve ser informada")
                .LessThanOrEqualTo(System.DateTime.Now).WithMessage("Data da compra não pode ser futura");

            RuleFor(i => i.IngressoItens)
                .NotNull().WithMessage("Itens do ingresso devem ser informados")
                .Must(list => list != null && list.Any()).WithMessage("É necessário ao menos um item no ingresso");

            RuleFor(i => i.ValorTotal)
                .GreaterThan(0).WithMessage("Valor total deve ser maior que zero");

            // Valida cada item básico (validator separado em IngressoItemValidator.cs)
            RuleForEach(i => i.IngressoItens).SetValidator(new IngressoItemValidator());

            // Valida consistência entre sessão/sala e itens, duplicidade e valor total
            RuleFor(i => i).Custom((ingresso, context) => {
                if (ingresso.Sessao == null)
                    return; // já tratado em outro rule

                var sala = ingresso.Sessao.Sala;
                if (sala == null)
                {
                    context.AddFailure("Sessão deve conter uma sala válida");
                    return;
                }

                // Verifica limites de fileiras/assentos e duplicatas
                var duplicates = ingresso.IngressoItens
                    .GroupBy(it => (it.Fileira, it.Assento))
                    .Where(g => g.Count() > 1)
                    .Select(g => g.Key)
                    .ToList();

                if (duplicates.Any())
                {
                    foreach (var d in duplicates)
                    {
                        context.AddFailure($"Assento duplicado na fileira {d.Fileira}, assento {d.Assento}");
                    }
                }

                foreach (var item in ingresso.IngressoItens ?? Enumerable.Empty<IngressoItem>())
                {
                    if (item.Fileira <= 0 || item.Assento <= 0)
                        continue; // já tratado

                    if (item.Fileira > sala.Fileiras)
                        context.AddFailure($"Fileira {item.Fileira} é inválida para a sala (máx {sala.Fileiras})");

                    if (item.Assento > sala.Assentos)
                        context.AddFailure($"Assento {item.Assento} é inválido para a sala (máx {sala.Assentos})");
                }

                // Verifica valor total com base no preço da sessão e meia entrada
                var precoSessao = ingresso.Sessao.Preco;
                decimal soma = 0m;
                foreach (var item in ingresso.IngressoItens ?? Enumerable.Empty<IngressoItem>())
                {
                    var fator = item.MeiaEntrada ? 0.5m : 1m;
                    soma += precoSessao * fator;
                }

                // Considera uma margem mínima para diferenças de casas decimais
                if (decimal.Round(soma, 2) != decimal.Round(ingresso.ValorTotal, 2))
                {
                    context.AddFailure($"ValorTotal ({ingresso.ValorTotal}) não corresponde ao somatório dos itens ({soma})");
                }
            });
        }
    }
}
