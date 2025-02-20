using Anima.Inscricao.Application.UseCases.Ofertas.CriarOferta;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Produtos;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Ofertas;

public class CriarOfertaCommandValidatorTests
{
    private readonly Mock<IProdutoRepository> _produtoRepositoryMock = new();
    private readonly Mock<IIntakeRepository> _intakeRepositoryMock = new();
    private readonly Mock<IIntegracaoSistemaRepository> _integracaoSistemasRepository = new();
    private readonly Mock<INotificationContext> _notificationContext = new();

    private readonly CriarOfertaCommandValidator _validator;

    public CriarOfertaCommandValidatorTests()
    {
        _validator = new CriarOfertaCommandValidator(
            _produtoRepositoryMock.Object,
            _intakeRepositoryMock.Object,
            _integracaoSistemasRepository.Object,
            _notificationContext.Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoProdutoForVazia()
    {
        var command = new CriarOfertaCommand
        {
            ProdutoKey = Guid.Empty,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.ProdutoKey)
            .WithErrorMessage("A chave do produto é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoProdutoNaoForEncontrada()
    {
        _produtoRepositoryMock.Setup(x => x.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(false);

        var command = new CriarOfertaCommand
        {
            ProdutoKey = Guid.NewGuid(),
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.ProdutoKey)
            .WithErrorMessage("A chave do produto não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoIntakeForVazia()
    {
        var command = new CriarOfertaCommand
        {
            IntakeKey = Guid.Empty,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.IntakeKey)
            .WithErrorMessage("A chave do intake é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoIntakeNaoForEncontrada()
    {
        _intakeRepositoryMock.Setup(x => x.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(false);

        var command = new CriarOfertaCommand
        {
            IntakeKey = Guid.NewGuid(),
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.IntakeKey)
            .WithErrorMessage("A chave do intake não foi encontrada.");
    }
}
