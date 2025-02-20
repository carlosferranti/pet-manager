﻿using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Instituicao;
using Anima.Inscricao.Domain._Shared.Notifications;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Instituicoes.PesquisarInstituicao;

public class PesquisarInstituicaoQueryValidator : ApplicationRequestValidator<PesquisarInstituicaoQuery, ResultadoPaginadoDto<InstituicaoDto>>
{
    public PesquisarInstituicaoQueryValidator(INotificationContext notificationContext) 
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
