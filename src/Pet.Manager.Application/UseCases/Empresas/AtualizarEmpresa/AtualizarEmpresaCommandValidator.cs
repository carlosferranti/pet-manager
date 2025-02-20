using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.Utils;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Empresas;
using Anima.Inscricao.Domain.Enderecos;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Empresas.AtualizarEmpresa;

public class AtualizarEmpresaCommandValidator : ApplicationRequestValidator<AtualizarEmpresaCommand>
{
    private const int LimiteCaracteresNome = 250;
    private const int LimiteCaracteresCep = 50;

    private readonly ICidadeRepository _cidadeRepository;
    private readonly IEmpresaRepository _empresaRepository;

    public AtualizarEmpresaCommandValidator(
        INotificationContext notificationContext,
        ICidadeRepository cidadeRepository,
        IEmpresaRepository empresaRepository)
        : base(notificationContext)
    {
        _cidadeRepository = cidadeRepository;
        _empresaRepository = empresaRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave da empresa é obrigatória.")
            .MustAsync(ValidarEmpresaExistenteAsync)
            .WithMessage("Chave da empresa não encontrada.");

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

    private async Task<bool> ValidarCidadeExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _cidadeRepository.ExistsAsync(key, token);
    }

    private async Task<bool> ValidarEmpresaExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _empresaRepository.ExistsAsync(key, token);
    }
}