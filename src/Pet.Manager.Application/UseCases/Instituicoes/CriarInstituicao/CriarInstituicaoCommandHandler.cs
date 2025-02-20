using System.Security.AccessControl;

using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Instituicoes.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Marcas;

namespace Anima.Inscricao.Application.UseCases.Instituicoes.CriarInstituicao;

public class CriarInstituicaoCommandHandler : ICommandHandler<CriarInstituicaoCommand, EntityKeyDto?>
{
    private readonly INotificationContext _notificationContext;
    private readonly IInstituicaoRepository _instituicaoRepository;
    private readonly IMarcaRepository _marcaRepository;
    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CriarInstituicaoCommandHandler(
        INotificationContext notificationContext, 
        IInstituicaoRepository instituicaoRepository, 
        IMarcaRepository marcaRepository,
        IIntegracaoSistemaRepository sistemasIntegracaoRepository, 
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _instituicaoRepository = instituicaoRepository;
        _marcaRepository = marcaRepository;
        _sistemasIntegracaoRepository = sistemasIntegracaoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<EntityKeyDto?> Handle(CriarInstituicaoCommand request, CancellationToken cancellationToken)
    {
        var marca = await _marcaRepository.GetAsync(request.MarcaKey);

        var instituicao = Instituicao
            .Criar(request.Nome, request.Sigla, marca.Id)
            .NotificarFalhas(_notificationContext)
            .ObterRetorno();

        if (instituicao == null)
        {
            return null;
        }

        if (request.Integracao != null)
        {
            var sistema = await _sistemasIntegracaoRepository.GetAsync(s => s.Nome.ToUpper() == request.Integracao.NomeSistema.ToUpper());
            instituicao.AdicionarIntegracao(sistema.Id, request.Integracao.CodigoOrigem);
        }

        await _instituicaoRepository.InsertAsync(instituicao);
        await _unitOfWork.CommitAsync(cancellationToken);

        return new EntityKeyDto(instituicao.Key);
    }
}
