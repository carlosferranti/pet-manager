using Anima.Inscricao.Application.UseCases.Empresas.ObterEmpresa;
using Anima.Inscricao.Domain.Empresas;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Empresas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class ObterEmpresaQueryHandlerTests
{
    private readonly IEmpresaRepository _empresaRepository;
    private readonly ICidadeRepository _cidadeRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;

    public ObterEmpresaQueryHandlerTests(DatabaseFixture databaseFixture)
    {
        _empresaRepository = databaseFixture.ServiceProvider.GetRequiredService<IEmpresaRepository>();
        _cidadeRepository = databaseFixture.ServiceProvider.GetRequiredService<ICidadeRepository>();
        _integracaoSistemaRepository = databaseFixture.ServiceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
    }

    [Fact]
    public async Task DeveRetornarEmpresasComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new ObterEmpresaQuery
        {
            Key = EmpresaConstants.Oracle.Key,
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.Key.Should().Be(EmpresaConstants.Oracle.Key);
        resultado.NomeFantasia.Should().Be(EmpresaConstants.Oracle.NomeFantasia);
    }

    private ObterEmpresaQueryHandler ObterUseCase()
    {
        return new(_empresaRepository, _cidadeRepository, _integracaoSistemaRepository);
    }
}
