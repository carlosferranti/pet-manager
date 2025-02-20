using System.Net;
using Anima.Inscricao.Application.DTOs.Instituicao;
using Anima.Inscricao.Application.UseCases.Instituicoes.PesquisarLinkRedirecionamentoCandidato;
using MediatR;
using System.Linq.Expressions;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.UseCases.Instituicoes.CriarInstituicao;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Instituicoes.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Anima.Inscricao.Controllers;
using Anima.Inscricao.CrossCutting.Middlewares;
using System.Threading;

namespace Anima.Inscricao.Test.UseCases.Instituicoes
{
    public class PesquisarLinkRedireconamentoInstituicaoQueryHandlerTests
    {
        private readonly Mock<IMediator> _mediatorMock;
        private readonly InstituicoesController _controller;

        public PesquisarLinkRedireconamentoInstituicaoQueryHandlerTests()
        {
            _mediatorMock = new Mock<IMediator>();
            _controller = new InstituicoesController(_mediatorMock.Object);
        }

        [Fact]
        public async Task LinkAreaCandidatoLogin_ReturnsOk_WhenLinkIsFound()
        {
            var inscricaocandidatokey = new PesquisarLinkRedireconamentoInstituicaoQuery {key =new Guid("a3070b9f-bcfd-4c38-9f11-7a4af2ccb165")};
            var expectedResponse = new InstituicaoLinkDto { Id = 1 };

            _mediatorMock
                .Setup(m => m.Send(inscricaocandidatokey, It.IsAny<CancellationToken>()))
                .ReturnsAsync(expectedResponse);

            var result = await _controller.LinkAreaCandidatoLogin(inscricaocandidatokey, CancellationToken.None);

            var okResult = Assert.IsType<Microsoft.AspNetCore.Mvc.OkObjectResult>(result);
            Assert.Equal((int)HttpStatusCode.OK, okResult.StatusCode);
            Assert.Equal(expectedResponse, okResult.Value);
        }

        [Fact]
        public async Task LinkAreaCandidatoLogin_ReturnsNotFound_WhenLinkIsNotFound()
        {
            var inscricaocandidatokey = new PesquisarLinkRedireconamentoInstituicaoQuery {key =new Guid("70333b35-7afd-4b94-9a7a-5091a8319ec4")};
            var expectedResponse = new InstituicaoLinkDto { Id = 0 };

            _mediatorMock
                .Setup(m => m.Send(inscricaocandidatokey, It.IsAny<CancellationToken>()))
                .ReturnsAsync(expectedResponse);

            var result = await _controller.LinkAreaCandidatoLogin(inscricaocandidatokey, CancellationToken.None);

            var notFoundResult = Assert.IsType<Microsoft.AspNetCore.Mvc.NotFoundResult>(result);
            Assert.Equal((int)HttpStatusCode.NotFound, notFoundResult.StatusCode);
        }

        [Fact(Skip = "validar em outro momento")]
        public async Task LinkAreaCandidatoLogin_ReturnsBadRequest_WhenQueryIsInvalid()
        {
            _controller.ModelState.AddModelError("Key", "Required");

            var result = await _controller.LinkAreaCandidatoLogin(null, CancellationToken.None);

            var badRequestResult = Assert.IsType<Microsoft.AspNetCore.Mvc.BadRequestObjectResult>(result);
            Assert.Equal((int)HttpStatusCode.BadRequest, badRequestResult.StatusCode);
        }
    }
}
