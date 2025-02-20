using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Campi;
using Anima.Inscricao.Domain._Shared.Notifications;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Campi.PesquisarCampus;

public class PesquisarCampusQueryValidator : ApplicationRequestValidator<PesquisarCampusQuery, ResultadoPaginadoDto<CampusDto>>
{
    public PesquisarCampusQueryValidator(INotificationContext notificationContext) 
        : base(notificationContext)
    {
        RuleFor(p => p.Paginacao)
            .NotNull()
            .WithMessage("A paginação precisa ser informada.");

        When(p => p.Paginacao is not null, () => {
            RuleFor(p => p.Paginacao).SetValidator(new PaginacaoApplicationRequestValidator());
        });
    }
}
