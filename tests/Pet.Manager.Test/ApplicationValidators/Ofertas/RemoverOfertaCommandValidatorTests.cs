using Anima.Inscricao.Application.UseCases.Ofertas.RemoverOferta;
using Anima.Inscricao.Application.UseCases.Produtos.RemoverProduto;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Ofertas;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Ofertas
{
    public class RemoverOfertaCommandValidatorTests
    {
        private readonly Mock<IOfertaRepository> _ofertaRepositoryMock = new();
        private readonly Mock<INotificationContext> _notificationContext = new();
        private readonly RemoverOfertaCommandValidator _validationRules;

        public RemoverOfertaCommandValidatorTests()
        {
            _validationRules = new(
                _ofertaRepositoryMock.Object,
                _notificationContext.Object);
        }

        [Fact]
        public async Task DeveValidarMensagemDeErroChaveObrigatoriaAsync()
        {
            var command = new RemoverOfertaCommand
            {
                Key = Guid.Empty,
            };

            var result = await _validationRules.TestValidateAsync(command);

            result.ShouldHaveValidationErrorFor(x => x.Key)
                .WithErrorMessage("A chave da oferta é obrigatória.");
        }

        [Fact]
        public async Task DeveValidarMensagemDeErroChaveNaoEncontradaAsync()
        {
            _ofertaRepositoryMock.Setup(x => x.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(false);

            var command = new RemoverOfertaCommand
            {
                Key = Guid.NewGuid(),
            };

            var result = await _validationRules.TestValidateAsync(command);

            result.ShouldHaveValidationErrorFor(x => x.Key)
                .WithErrorMessage("A chave da oferta não foi encontrada.");
        }
    }
}
