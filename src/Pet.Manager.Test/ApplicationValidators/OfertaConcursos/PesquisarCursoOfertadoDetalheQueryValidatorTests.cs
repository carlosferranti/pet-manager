using Anima.Inscricao.Application.UseCases.OfertaConcursos.PesquisarCursoOfertadoDetalhe;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.Links;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Domain.NiveisCurso;
using Anima.Inscricao.Domain.Ofertas;

using FluentValidation.TestHelper;

using Moq;

using static Anima.Inscricao.Application.UseCases.OfertaConcursos.PesquisarCursoOfertadoDetalhe.PesquisarCursoOfertadoDetalheQuery;

namespace Anima.Inscricao.Test.ApplicationValidators.OfertaConcursos;

public class PesquisarCursoOfertadoDetalheQueryValidatorTests
{
    private readonly PesquisarCursoOfertadoDetalheQueryValidator _validator;
    private readonly Mock<IMarcaRepository> _marcaRepositoryMock;
    private readonly Mock<IIntakeRepository> _intakeRepositoryMock;
    private readonly Mock<INivelCursoRepository> _nivelCursoRepositoryMock;
    private readonly Mock<ILinkRepository> _linkRepositoryMock;
    private readonly Mock<IOfertaRepository> _ofertaRepositoryMock;

    public PesquisarCursoOfertadoDetalheQueryValidatorTests()
    {
        _marcaRepositoryMock = new Mock<IMarcaRepository>();
        _intakeRepositoryMock = new Mock<IIntakeRepository>();
        _nivelCursoRepositoryMock = new Mock<INivelCursoRepository>();
        _linkRepositoryMock = new Mock<ILinkRepository>();
        _ofertaRepositoryMock = new Mock<IOfertaRepository>();

        _validator = new PesquisarCursoOfertadoDetalheQueryValidator(
            new NotificationContext(),
            _marcaRepositoryMock.Object,
            _intakeRepositoryMock.Object,
            _nivelCursoRepositoryMock.Object,
            _linkRepositoryMock.Object,
            _ofertaRepositoryMock.Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDaMarcaForVazia()
    {
        // Arrange
        var query = new PesquisarCursoOfertadoDetalheQuery
        {
            Filtros = new PesquisarCursoOfertadoDetalheFiltros
            {
                MarcaKey = null,
                IntakeKey = Guid.NewGuid(),
                NivelCursoKey = Guid.NewGuid(),
                LinkKey = Guid.NewGuid(),
                CursoNome = "Nome do Curso",
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(query);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Filtros!.MarcaKey)
            .WithErrorMessage("A chave da marca é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDaMarcaNaoExistir()
    {
        // Arrange
        var marcaKey = Guid.NewGuid();
        _marcaRepositoryMock
            .Setup(x => x.ExistsAsync(marcaKey, default))
            .ReturnsAsync(false);

        var query = new PesquisarCursoOfertadoDetalheQuery
        {
            Filtros = new PesquisarCursoOfertadoDetalheFiltros
            {
                MarcaKey = marcaKey,
                IntakeKey = Guid.NewGuid(),
                NivelCursoKey = Guid.NewGuid(),
                LinkKey = Guid.NewGuid(),
                CursoNome = "Nome do Curso",
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(query);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Filtros!.MarcaKey!.Value)
            .WithErrorMessage("A chave da marca não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoNivelForVazia()
    {
        // Arrange
        var query = new PesquisarCursoOfertadoDetalheQuery
        {
            Filtros = new PesquisarCursoOfertadoDetalheFiltros
            {
                MarcaKey = Guid.NewGuid(),
                IntakeKey = Guid.NewGuid(),
                NivelCursoKey = null,
                LinkKey = null,
                CursoNome = "Nome do Curso",
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(query);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Filtros!.NivelCursoKey)
            .WithErrorMessage("A chave do nível é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoNivelNaoExistir()
    {
        // Arrange
        var nivelKey = Guid.NewGuid();
        _nivelCursoRepositoryMock
            .Setup(x => x.ExistsAsync(nivelKey, default))
            .ReturnsAsync(false);

        var query = new PesquisarCursoOfertadoDetalheQuery
        {
            Filtros = new PesquisarCursoOfertadoDetalheFiltros
            {
                MarcaKey = Guid.NewGuid(),
                IntakeKey = Guid.NewGuid(),
                NivelCursoKey = nivelKey,
                LinkKey = Guid.NewGuid(),
                CursoNome = "Nome do Curso",
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(query);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Filtros!.NivelCursoKey!.Value)
            .WithErrorMessage("A chave do nível não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoIntakeForVazia()
    {
        // Arrange
        var query = new PesquisarCursoOfertadoDetalheQuery
        {
            Filtros = new PesquisarCursoOfertadoDetalheFiltros
            {
                MarcaKey = Guid.NewGuid(),
                IntakeKey = null,
                NivelCursoKey = Guid.NewGuid(),
                LinkKey = Guid.NewGuid(),
                CursoNome = "Nome do Curso",
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(query);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Filtros!.IntakeKey)
            .WithErrorMessage("A chave do intake é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoIntakeNaoExistir()
    {
        // Arrange
        var intakeKey = Guid.NewGuid();
        _intakeRepositoryMock
            .Setup(x => x.ExistsAsync(intakeKey, default))
            .ReturnsAsync(false);

        var query = new PesquisarCursoOfertadoDetalheQuery
        {
            Filtros = new PesquisarCursoOfertadoDetalheFiltros
            {
                MarcaKey = Guid.NewGuid(),
                IntakeKey = intakeKey,
                NivelCursoKey = Guid.NewGuid(),
                LinkKey = Guid.NewGuid(),
                CursoNome = "Nome do Curso",
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(query);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Filtros!.IntakeKey!.Value)
            .WithErrorMessage("A chave do intake não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeDoCursoForVazio()
    {
        // Arrange
        var query = new PesquisarCursoOfertadoDetalheQuery
        {
            Filtros = new PesquisarCursoOfertadoDetalheFiltros
            {
                MarcaKey = Guid.NewGuid(),
                IntakeKey = Guid.NewGuid(),
                NivelCursoKey = Guid.NewGuid(),
                LinkKey = Guid.NewGuid(),
                CursoNome = string.Empty,
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(query);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Filtros!.CursoNome)
            .WithErrorMessage("O nome do curso é obrigatório.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDaOfertaNaoExistir()
    {
        // Arrange
        var intakeKey = Guid.NewGuid();
        _intakeRepositoryMock
            .Setup(x => x.ExistsAsync(intakeKey, default))
            .ReturnsAsync(false);

        var query = new PesquisarCursoOfertadoDetalheQuery
        {
            Filtros = new PesquisarCursoOfertadoDetalheFiltros
            {
                MarcaKey = Guid.NewGuid(),
                IntakeKey = Guid.NewGuid(),
                NivelCursoKey = Guid.NewGuid(),
                CursoNome = string.Empty,
                OfertaKey = Guid.NewGuid(),
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(query);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Filtros!.OfertaKey!.Value)
            .WithErrorMessage("A chave da oferta não foi encontrada.");
    }
}