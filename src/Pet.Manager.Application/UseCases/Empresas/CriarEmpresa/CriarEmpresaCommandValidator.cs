using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.Utils;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.IntegracaoSistemas;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Empresas.CriarEmpresa;

public class CriarEmpresaCommandValidator : ApplicationRequestValidator<CriarEmpresaCommand, EntityKeyDto?>
{
    private const int LimiteCaracteresNome = 250;
    private const int LimiteCaracteresCodigoOrigem = 100;
    private const int LimiteCaracteresCep = 50;

    private readonly ICidadeRepository _cidadeRepository;
    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;

    public CriarEmpresaCommandValidator(
        INotificationContext notificationContext,
        ICidadeRepository cidadeRepository,
        IIntegracaoSistemaRepository integracaoSistemaRepository)
        : base(notificationContext)
    {
        _cidadeRepository = cidadeRepository;
        _sistemasIntegracaoRepository = integracaoSistemaRepository;

        When(x => !string.IsNullOrWhiteSpace(x.NomeFantasia), () =>
        {
            RuleFor(x => x.NomeFantasia)
            .MaximumLength(LimiteCaracteresNome)
            .WithMessage("O nome fantasia da empresa deve ter no máximo {MaxLength} caracteres.");
        });
        
        RuleFor(x => x.RazaoSocial)
            .NotEmpty().WithMessage("A razão social da empresa é obrigatória.")
            .MaximumLength(LimiteCaracteresNome)
            .WithMessage("A razão social da empresa deve ter no máximo {MaxLength} caracteres.");

        RuleFor(x => x.Cnpj)
            .NotEmpty().WithMessage("O cnpj da empresa é obrigatório.")
            .Must(x => CnpjUtils.ValidarCnpj(x))
            .WithMessage("O cnpj é inválido.");

        When(x => x.Integracao != null, () =>
        {
            RuleFor(x => x.Integracao!.NomeSistema)
                .MaximumLength(LimiteCaracteresNome)
                .WithMessage("O nome do sistema de integração deve ter no máximo {MaxLength} caracteres.")
                .MustAsync(ValidarNomeSistemaIntegracaoExistenteAsync)
                .WithMessage("Nome do sistema de integração não encontrado.");

            RuleFor(x => x.Integracao!.CodigoOrigem)
                .MaximumLength(LimiteCaracteresCodigoOrigem)
                .WithMessage("O código de origem da integração deve ter no máximo {MaxLength} caracteres.");
        });

        When(x => x.Enderecos != null && x.Enderecos.Any(), () =>
        {
            RuleForEach(x => x.Enderecos).ChildRules(endereco =>
            {
                endereco.When(e => e.Cep != null, () =>
                {
                    endereco.RuleFor(x => x.Cep)
                    .MaximumLength(LimiteCaracteresCep)
                    .WithMessage("O valor do CEP deve ter no máximo {MaxLength} caracteres.");
                });

                endereco.When(e => e.Numero != null, () =>
                {
                    endereco.RuleFor(x => x.Numero)
                    .MaximumLength(LimiteCaracteresCep)
                    .WithMessage("O valor do número do endereço deve ter no máximo {MaxLength} caracteres.");
                });

                endereco.When(e => e.Logradouro != null, () =>
                {
                    endereco.RuleFor(x => x.Logradouro)
                    .MaximumLength(LimiteCaracteresNome)
                    .WithMessage("O valor do logradouro do endereço deve ter no máximo {MaxLength} caracteres.");
                });

                endereco.When(e => e.Complemento != null, () =>
                {
                    endereco.RuleFor(x => x.Complemento)
                    .MaximumLength(LimiteCaracteresNome)
                    .WithMessage("O valor do complemento do endereço deve ter no máximo {MaxLength} caracteres.");
                });

                endereco.When(e => e.Bairro != null, () =>
                {
                    endereco.RuleFor(x => x.Bairro)
                    .MaximumLength(LimiteCaracteresNome)
                    .WithMessage("O valor do bairro do endereço deve ter no máximo {MaxLength} caracteres.");
                });

                endereco.RuleFor(x => x.CidadeKey)
                .MustAsync(ValidarCidadeExistenteAsync)
                .WithMessage("A chave da cidade não foi encontrada.");
            });
        });
    }

    private async Task<bool> ValidarNomeSistemaIntegracaoExistenteAsync(string nome, CancellationToken token = default)
    {
        return await _sistemasIntegracaoRepository.GetAsync(x => x.Nome.ToUpper() == nome.ToUpper()) != null;
    }

    private async Task<bool> ValidarCidadeExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _cidadeRepository.ExistsAsync(key, token);
    }
}