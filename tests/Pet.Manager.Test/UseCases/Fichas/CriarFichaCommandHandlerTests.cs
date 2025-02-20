using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.UseCases.Fichas.CriarFicha;
using Anima.Inscricao.Application.UseCases.FormasEntrada.CriarFormaEntrada;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campos;
using Anima.Inscricao.Domain.Etapas;
using Anima.Inscricao.Domain.Fichas;
using Anima.Inscricao.Domain.Fichas.Entities;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Fichas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class CriarFichaCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IFichaRepository> _fichaRepository = new();
    private readonly Mock<IEtapaTemplateRepository> _etapaTemplateRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();
    private readonly Mock<ICampoRepository> _campoRepository = new();

    public CriarFichaCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveInserirFichaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarFichaCommand
        {
            Nome = "Nova ficha",
            Descricao = "Descrição da ficha",
            Padrao = false,
        }, default);

        // Assert
        _fichaRepository.Verify(x => x.InsertAsync(It.IsAny<Ficha>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveInserirQuandoFichaJaExisteAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarFichaCommand
        {
            Nome = FichaConstants.FichaPadrao.Nome,
            Descricao = FichaConstants.FichaPadrao.Descricao,
            Padrao = FichaConstants.FichaPadrao.Padrao,
            Etapas = FichaConstants.FichaPadrao.Etapas
            .Select(e => new CriarFichaCommand.CriarEtapaFichaCommand(EtapaConstants.EtapaDadosPessoais.Key, e.Sequencia))
            .ToList(),
        }, default);

        // Assert
        _fichaRepository.Verify(x => x.InsertAsync(It.IsAny<Ficha>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    private CriarFichaCommandHandler ObterUseCase()
    {
        return new(
            _fichaRepository.Object,
            _etapaTemplateRepository.Object,
            _unitOfWork.Object,
            _notificationContext.Object,
            _campoRepository.Object);
    }
}