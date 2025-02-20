using Anima.Inscricao.Application.UseCases.OfertaConcursos.RemoverOfertaConcurso;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.OfertaConcursos;
using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.OfertaConcursos;

public class RemoverOfertaConcursoCommandValidatorTests
{
    private readonly Mock<IOfertaConcursoRepository> _ofertaConcursoRepositoryMock = new();
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly RemoverOfertaConcursoCommandValidator _validator;

    public RemoverOfertaConcursoCommandValidatorTests()
    {
        _validator = new(
                _ofertaConcursoRepositoryMock.Object,
                _notificationContext.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveObrigatoriaAsync()
    {
        var command = new RemoverOfertaConcursoCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave da ofertaConcurso é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveNaoEncontradaAsync()
    {
        _ofertaConcursoRepositoryMock.Setup(x => x.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(false);

        var command = new RemoverOfertaConcursoCommand
        {
            Key = Guid.NewGuid(),
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave da ofertaConcurso não foi encontrada.");
    }
}
