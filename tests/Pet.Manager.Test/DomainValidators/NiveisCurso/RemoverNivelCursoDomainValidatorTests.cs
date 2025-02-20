using Anima.Inscricao.Domain.NiveisCurso.Entities;
using Anima.Inscricao.Domain.NiveisCurso.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

namespace Anima.Inscricao.Test.DomainValidators.NiveisCurso
{
    [Collection(DatabaseCollectionConstants.ServicoInscricao)]
    public class RemoverNivelCursoDomainValidatorTests
    {
        private readonly RemoverNivelCursoDomainValidator _validator;

        public RemoverNivelCursoDomainValidatorTests(DatabaseFixture databaseFixture)
        {
            _validator = new();
        }

        [Fact]
        public void DeveValidarQuePodeExcluirRegistro()
        {
            // Arrange
            NivelCursoId nivelCursoId = NivelCursoConstants.Licenciatura.Id;

            // Act
            var resultado = _validator.Validate(nivelCursoId);

            // Assert
            resultado.Should().BeTrue();
        }
    }
}
