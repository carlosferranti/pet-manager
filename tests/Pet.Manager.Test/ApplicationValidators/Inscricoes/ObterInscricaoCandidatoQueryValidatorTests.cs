using Anima.Inscricao.Application.UseCases.Cursos.ObterCurso;
using Anima.Inscricao.Application.UseCases.Inscricoes.ObterInscricaoCandidato;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricoes.Domain.Inscricoes;

using FluentValidation;
using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Inscricoes;

public class ObterInscricaoCandidatoQueryValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IInscricaoRepository> _inscricaoRepository = new();
    private readonly ObterInscricaoCandidatoQueryValidator _validationRules;

    public ObterInscricaoCandidatoQueryValidatorTests()
    {
        _validationRules = new ObterInscricaoCandidatoQueryValidator(
            _inscricaoRepository.Object,
           _notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveObrigatoriaAsync()
    {
        var command = new ObterInscricaoCanditadoQuery
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave da inscrição é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveNaoEncontradaAsync()
    {
        var command = new ObterInscricaoCanditadoQuery
        {
            Key = Guid.NewGuid(),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave da inscrição não foi encontrada.");
    }
}
