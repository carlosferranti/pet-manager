using Anima.Inscricao.Domain.Empresas;
using Anima.Inscricao.Domain.Empresas.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Empresas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovaEmpresaDomainValidatorTests
{
    private readonly IEmpresaRepository _empresaRepository;
    private readonly NovaEmpresaDomainValidator _validator;

    public NovaEmpresaDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _empresaRepository = databaseFixture.ServiceProvider.GetRequiredService<IEmpresaRepository>();
        _validator = new(_empresaRepository);
    }

    [Fact]
    public void DeveValidarCnpjUnicos()
    {
        // Arrange
        string cnpj = EmpresaConstants.Compass.Cnpj;

        // Act
        var resultado = _validator.Validate(cnpj);

        // Assert
        resultado.Should().BeFalse();
    }
}