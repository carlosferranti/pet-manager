using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Empresas;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Empresas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Empresas.ObterEmpresa;

public class ObterEmpresaQueryValidator : ApplicationRequestValidator<ObterEmpresaQuery, EmpresaDto>
{
    private readonly IEmpresaRepository _empresaRepository;

    public ObterEmpresaQueryValidator(
        IEmpresaRepository empresaRepository,
        INotificationContext notificationContext)
        : base(notificationContext)
    {
        _empresaRepository  = empresaRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave da empresa é obrigatória.")
            .MustAsync(ValidarEmpresaExistenteAsync).WithMessage("A chave da empresa não foi encontrada.");
    }

    private async Task<bool> ValidarEmpresaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _empresaRepository.ExistsAsync(key, token);
    }
}
