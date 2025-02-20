using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Inscricoes;
using Anima.Inscricao.Domain._Shared.Notifications;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Inscricoes.PesquisarInscricoesCandidatos;

public class PesquisarInscricoesCandidatosQueryValidator : ApplicationRequestValidator<PesquisarInscricoesCandidatosQuery, ResultadoPaginadoDto<CandidatoDto>>
{
    private const int LimiteCaracteresNome = 100;
    private const int LimiteCaracteresCpf = 14;
    private const int LimiteCaracteresConcursoId = 100;

    public PesquisarInscricoesCandidatosQueryValidator(INotificationContext notificationContext)
    : base(notificationContext)
    {
        When(x => x.Filtros is not null, () =>
        {
            RuleFor(x => x.Filtros!.CandidatoId)
                .GreaterThan(0)
                .WithMessage("O id do candidato deve ser um número positivo.");

            When(x => !string.IsNullOrEmpty(x.Filtros!.ConcursoId), () =>
            {
                RuleFor(x => x.Filtros!.ConcursoId)
                 .MaximumLength(LimiteCaracteresConcursoId)
                      .WithMessage("Id do concurso deve ter no máximo {MaxLength} caracteres.");
            });

            When(x => !string.IsNullOrEmpty(x.Filtros!.Nome), () =>
            {
                RuleFor(x => x.Filtros!.Nome)
                 .MaximumLength(LimiteCaracteresNome)
                      .WithMessage("Nome deve ter no máximo {MaxLength} caracteres.");
            });

            When(x => !string.IsNullOrEmpty(x.Filtros!.Cpf), () =>
            {
                RuleFor(x => x.Filtros!.Cpf)
                 .MaximumLength(LimiteCaracteresCpf)
                      .WithMessage("Cpf deve ter no máximo {MaxLength} caracteres.");
            });

            When(x => x.Filtros.StatusInscricaoIds != null, () =>
            {
                RuleFor(x => x.Filtros!.StatusInscricaoIds)
                    .Must(list => list!.All(id => id > 0))
                    .WithMessage("Os ids de status de inscrição devem ser números inteiros maior que 0");
            });
        });

        RuleFor(p => p.Paginacao)
            .NotNull()
            .WithMessage("A paginação precisa ser informada.");

        When(p => p.Paginacao is not null, () =>
        {
            RuleFor(p => p.Paginacao).SetValidator(new PaginacaoApplicationRequestValidator());
        });
    }
}

