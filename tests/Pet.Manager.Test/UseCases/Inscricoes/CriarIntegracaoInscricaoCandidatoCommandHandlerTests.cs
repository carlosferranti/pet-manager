using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.UseCases.Inscricoes.CriarIntegracaoInscricaoCandidato;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Inscricoes.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;
using Anima.Inscricoes.Domain.Inscricoes;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Inscricoes;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class CriarIntegracaoInscricaoCandidatoCommandHandlerTests
{
    private readonly INotificationContext _notificationContext;
    private readonly IInscricaoRepository _inscricaoRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemasRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CriarIntegracaoInscricaoCandidatoCommandHandlerTests(DatabaseFixture databaseFixture)
    {
        _notificationContext = databaseFixture.ServiceProvider.GetRequiredService<INotificationContext>();
        _inscricaoRepository = databaseFixture.ServiceProvider.GetRequiredService<IInscricaoRepository>();
        _integracaoSistemasRepository = databaseFixture.ServiceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
        _unitOfWork = databaseFixture.ServiceProvider.GetRequiredService<IUnitOfWork>();
    }

    [Fact]
    public async Task DeveCriarIntegracaoInscricaoComSucessoAsync()
    {
        // Arrange
        var command = new CriarIntegracaoInscricaoCandidatoCommand
        {
            InscricaoCandidatoKey = InscricaoConstants.InscricaoCorreta.Key,
            Integracao = new SistemaIntegracaoDto
            {
                CodigoOrigem = "123",
                NomeSistema = IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Nome,
            },
        };

        // Act
        var useCase = ObterUseCase();
        var resultado = await useCase.Handle(command, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado!.Key.Should().Be(InscricaoConstants.InscricaoCorreta.Key);
        var inscricao = await ObterInscricaoCandidato(InscricaoConstants.InscricaoCorreta.Key);
        inscricao.IntegracoesInscricao.Should().NotBeNull();
        inscricao.IntegracoesInscricao.FirstOrDefault()!.CodigoOrigem.Should().Be(command.Integracao.CodigoOrigem);
        inscricao.IntegracoesInscricao.FirstOrDefault()!.IntegracaoSistemaId.Should().Be(IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Id);
    }

    [Fact]
    public async Task NaoDeveCriarIntegracaoInscricaoAsync()
    {
        // Arrange
        var command = new CriarIntegracaoInscricaoCandidatoCommand
        {
            InscricaoCandidatoKey = InscricaoConstants.InscricaoComIntegracao.Key,
            Integracao = new SistemaIntegracaoDto
            {
                CodigoOrigem = "123",
                NomeSistema = IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Nome,
            },
        };

        // Act
        var useCase = ObterUseCase();
        var resultado = await useCase.Handle(command, default);

        // Assert
        resultado.Should().BeNull();
        _notificationContext.HasNotifications.Should().BeTrue();
        _notificationContext.Notifications.Any(n => n.Mensagem == "Já existe uma integração para o sistema integrador informado.").Should().BeTrue();
    }

    private async Task<InscricaoCandidato> ObterInscricaoCandidato(Guid key)
    {
        return await _inscricaoRepository.GetAsync(key);
    }

    private CriarIntegracaoInscricaoCandidatoCommandHandler ObterUseCase()
    {
        return new CriarIntegracaoInscricaoCandidatoCommandHandler(
            _notificationContext,
            _inscricaoRepository,
            _integracaoSistemasRepository,
            _unitOfWork);
    }
}