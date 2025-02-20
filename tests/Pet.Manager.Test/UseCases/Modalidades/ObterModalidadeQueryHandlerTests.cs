using Anima.Inscricao.Application.UseCases.Modalidades.ObterModalidade;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Modalidades;

public class ObterModalidadeQueryHandlerTests
{
    private readonly Mock<IModalidadeRepository> _modalidadeRepository = new();

    public ObterModalidadeQueryHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRetornarModalidadeComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new ObterModalidadeQuery
        {
            Key = ModalidadeConstants.ModalidadePresencial.Key,
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.Key.Should().Be(ModalidadeConstants.ModalidadePresencial.Key);
        resultado.Nome.Should().Be(ModalidadeConstants.ModalidadePresencial.Nome);
    }

    private ObterModalidadeQueryHandler ObterUseCase()
    {
        _modalidadeRepository
            .Setup(x => x.GetAsync(ModalidadeConstants.ModalidadePresencial.Key))
            .ReturnsAsync(ModalidadeConstants.ModalidadePresencial);

        return new(_modalidadeRepository.Object);
    }
}
