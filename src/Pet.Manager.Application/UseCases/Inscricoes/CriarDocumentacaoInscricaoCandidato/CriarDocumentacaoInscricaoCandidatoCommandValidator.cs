using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Inscricoes;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricoes.Domain.Inscricoes;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Inscricoes.CriarDocumentacaoInscricaoCandidato;

public class CriarDocumentacaoInscricaoCandidatoCommandValidator : ApplicationRequestValidator<CriarDocumentacaoInscricaoCandidatoCommand, List<InscricaoDocumentacaoDto>?>
{
    private const int LimiteCaracteresObservacoes = 500;
    private const int BytesPorMegaByte = 1024 * 1024;
    private const int LimiteTamanhoArquivoEmMegabytes = 10;
    private readonly string[] ExtensoesPermitidas = [".jpeg", ".jpg", ".png", ".pdf"];

    private readonly IInscricaoRepository _inscricaoRepository;

    public CriarDocumentacaoInscricaoCandidatoCommandValidator(
        INotificationContext notificationContext,
        IInscricaoRepository inscricaoRepository)
        : base(notificationContext)
    {
        _inscricaoRepository = inscricaoRepository;

        RuleFor(x => x.InscricaoKey)
            .NotEmpty()
                .WithMessage("A chave da inscrição é obrigatória.")
            .MustAsync(ValidarInscricaoExistenteAsync)
                .WithMessage("A chave da inscrição não foi encontrada.");

        RuleFor(x => x.Documentos)
            .NotEmpty()
                .WithMessage("A lista de documentos é obrigatória.");

        When(x => x.Documentos != null, () =>
        {
            RuleForEach(x => x.Documentos)
                .ChildRules(documento =>
                {
                    documento.RuleFor(x => x.Arquivo)
                    .Cascade(CascadeMode.Stop)
                    .NotNull()
                        .WithMessage("O arquivo é obrigatório.")
                    .Must(x => x!.Length <= (LimiteTamanhoArquivoEmMegabytes * BytesPorMegaByte))
                        .WithMessage("O tamanho máximo do arquivo é 10MB.")
                    .Must(x => x!.Length > 0)
                        .WithMessage("O arquivo não pode ser vazio.")
                    .Must(x => ValidarExtensaoArquivo(x!.FileName))
                        .WithMessage("O formato do arquivo é inválido.");

                    documento.When(x => x.Observacoes != null, () =>
                    {
                        documento.RuleFor(x => x.Observacoes)
                        .MaximumLength(LimiteCaracteresObservacoes)
                            .WithMessage("A observação do arquivo deve ter no máximo {MaxLength} caracteres.");
                    });
                });
        });
    }

    private async Task<bool> ValidarInscricaoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _inscricaoRepository.ExistsAsync(key, token);
    }

    private bool ValidarExtensaoArquivo(string nome)
    {
        return ExtensoesPermitidas.Contains(Path.GetExtension(nome.ToLowerInvariant()));
    }
}