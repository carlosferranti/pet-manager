﻿using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.UseCases.FormasEntrada.RemoverFormaEntrada;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Etapas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Etapas.RemoverEtapaTemplate;

public class RemoverEtapaTemplateCommandValidator : ApplicationRequestValidator<RemoverEtapaTemplateCommand>
{
    private readonly IEtapaTemplateRepository _etapaTemplateRepository;

    public RemoverEtapaTemplateCommandValidator(
        IEtapaTemplateRepository etapaTemplateRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _etapaTemplateRepository = etapaTemplateRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave da etapa é obrigatória.")
            .MustAsync(ValidarEtapaExistenteAsync).WithMessage("A chave da etapa não foi encontrada.");
    }

    private async Task<bool> ValidarEtapaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _etapaTemplateRepository.ExistsAsync(key, token);
    }
}