using Anima.Inscricao.Domain.Empresas;
using Anima.Inscricao.Domain.Empresas.Entities;
using Anima.Inscricao.Domain.Empresas.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Empresas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizacaoEmpresaDomainValidatorTests
{
    private readonly IEmpresaRepository _empresaRepository;
    private readonly AtualizacaoEmpresaDomainValidator _validator;

    public AtualizacaoEmpresaDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _empresaRepository = databaseFixture.ServiceProvider.GetRequiredService<IEmpresaRepository>();
        _validator = new(_empresaRepository);
    }

    [Fact]
    public void DeveValidarCnpjUnico()
    {
        // Arrange
        EmpresaId empresaId = EmpresaConstants.Compass.Id;
        string cnpj = EmpresaConstants.Oracle.Cnpj;

        // Act
        var resultado = _validator.Validate(empresaId, cnpj);

        // Assert
        resultado.Should().BeFalse();
    }

    [Fact]
    public void DevePermitirAtualizarSeForMesmoRegistro()
    {
        // Arrange
        EmpresaId empresaId = EmpresaConstants.Compass.Id;
        string cnpj = EmpresaConstants.Compass.Cnpj;

        // Act
        var resultado = _validator.Validate(empresaId, cnpj);

        // Assert
        resultado.Should().BeTrue();
    }
}