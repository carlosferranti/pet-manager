using Anima.Inscricao.Application.UseCases.OfertaConcursos.PesquisarCursosOfertados;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Links;
using Anima.Inscricao.Domain.Marcas;

using FluentValidation.TestHelper;

using Moq;

using static Anima.Inscricao.Application.UseCases.OfertaConcursos.PesquisarCursosOfertados.PesquisarCursosOfertadosQuery;

namespace Anima.Inscricao.Test.ApplicationValidators.OfertaConcursos;

public class PesquisarCursosOfertadosQueryValidatorTests
{
    private readonly PesquisarCursosOfertadosQueryValidator _validator;
    private readonly Mock<IMarcaRepository> _marcaRepositoryMock = new();
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<ILinkRepository> _linkRepositoryMock = new();

    public PesquisarCursosOfertadosQueryValidatorTests()
    {
        _validator = new PesquisarCursosOfertadosQueryValidator(
            _notificationContextMock.Object,
            _marcaRepositoryMock.Object,
            _linkRepositoryMock.Object);
    }

    [Fact]
    public async Task DeveValidarChaveDaMarcaObrigatoria()
    {
        // Arrange
        var query = new PesquisarCursosOfertadosQuery 
        { 
            Filtros = new PesquisarCursoOfertadoFiltros
            {
                LinkKey = null,
                MarcaKey = null,
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(query);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Filtros!.MarcaKey)
            .WithErrorMessage("A chave da marca é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarChaveDaMarcaExistente()
    {
        // Arrange
        var query = new PesquisarCursosOfertadosQuery
        {
            Filtros = new PesquisarCursoOfertadoFiltros
            {
                LinkKey = Guid.NewGuid(),
                MarcaKey = Guid.NewGuid(),
            }
        };
        
        _marcaRepositoryMock
            .Setup(x => x.ExistsAsync(It.IsAny<Guid>(), default))
            .ReturnsAsync(true);

        // Act
        var result = await _validator.TestValidateAsync(query);

        // Assert
        result.ShouldNotHaveValidationErrorFor(x => x.Filtros!.MarcaKey!.Value);
    }

    [Fact]
    public async Task DeveValidarChaveDaMarcaNaoEncontrada()
    {
        // Arrange
        var query = new PesquisarCursosOfertadosQuery
        {
            Filtros = new PesquisarCursoOfertadoFiltros
            {
                LinkKey = null,
                MarcaKey = Guid.NewGuid(),
            }
        };
        
        _marcaRepositoryMock
            .Setup(x => x.ExistsAsync(It.IsAny<Guid>(), default))
            .ReturnsAsync(false);

        // Act
        var result = await _validator.TestValidateAsync(query);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Filtros!.MarcaKey!.Value)
            .WithErrorMessage("A chave da marca não foi encontrada.");
    }

    [Fact]
    public async Task DeveValidarChaveDoLinkObrigatoria()
    {
        // Arrange
        var query = new PesquisarCursosOfertadosQuery
        {
            Filtros = new PesquisarCursoOfertadoFiltros
            {
                LinkKey = null,
                MarcaKey = null,
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(query);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Filtros!.LinkKey)
            .WithErrorMessage("A chave do link é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarChaveDoLinkExistente()
    {
        // Arrange
        var query = new PesquisarCursosOfertadosQuery
        {
            Filtros = new PesquisarCursoOfertadoFiltros
            {
                LinkKey = Guid.NewGuid(),
                MarcaKey = null,
            }
        };

        _linkRepositoryMock
            .Setup(x => x.ExistsAsync(It.IsAny<Guid>(), default))
            .ReturnsAsync(true);

        // Act
        var result = await _validator.TestValidateAsync(query);

        // Assert
        result.ShouldNotHaveValidationErrorFor(x => x.Filtros!.LinkKey!.Value);
    }

    [Fact]
    public async Task DeveValidarChaveDoLinkNaoEncontrada()
    {
        // Arrange
        var query = new PesquisarCursosOfertadosQuery
        {
            Filtros = new PesquisarCursoOfertadoFiltros
            {
                LinkKey = Guid.NewGuid(),
                MarcaKey = null,
            }
        };

        _linkRepositoryMock
            .Setup(x => x.ExistsAsync(It.IsAny<Guid>(), default))
            .ReturnsAsync(false);

        // Act
        var result = await _validator.TestValidateAsync(query);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Filtros!.LinkKey!.Value)
            .WithErrorMessage("A chave do link não foi encontrada.");
    }
}