using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application.Interfaces.Services;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Enums;
using Anima.Inscricao.Domain.Inscricoes;

namespace Anima.Inscricao.Application.UseCases.Inscricoes.RemoverDocumentacaoInscricaoCandidato;

public class RemoverDocumentacaoInscricaoCandidatoCommandHandler : ICommandHandler<RemoverDocumentacaoInscricaoCandidatoCommand>
{
    private readonly IInscricaoDocumentacaoRepository _inscricaoDocumentacaoRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAmazonS3Service _amazonS3Service;

    public RemoverDocumentacaoInscricaoCandidatoCommandHandler(
        IInscricaoDocumentacaoRepository inscricaoDocumentacaoRepository,
        IUnitOfWork unitOfWork,
        IAmazonS3Service amazonS3Service)
    {
        _inscricaoDocumentacaoRepository = inscricaoDocumentacaoRepository;
        _unitOfWork = unitOfWork;
        _amazonS3Service = amazonS3Service;
    }

    public async Task Handle(RemoverDocumentacaoInscricaoCandidatoCommand request, CancellationToken cancellationToken)
    {
        var documentacao = await _inscricaoDocumentacaoRepository.GetAsync(request.InscricaoDocumentacaoKey);

        if (documentacao.Status.Ativo && documentacao.Arquivo.TipoLocalArquivo == TipoLocalArquivo.S3)
        {
            await _amazonS3Service.RemoverArquivoAsync(documentacao.Arquivo!.Chave, cancellationToken);

            documentacao.Inativar(request.InscricaoKey);

            _inscricaoDocumentacaoRepository.Update(documentacao);
        }
        else
        {
            var listaDocumentacoesSmartShare = await _inscricaoDocumentacaoRepository.GetListAsync(d => 
                d.InscricaoCandidatoId == documentacao.InscricaoCandidatoId &&
                d.Tipo == documentacao.Tipo &&
                d.Auditoria.CriadoEm > documentacao.Auditoria.CriadoEm &&
                d.Arquivo.TipoLocalArquivo == TipoLocalArquivo.SmartShare &&
                d.Arquivo.Informacoes.Nome == documentacao.Arquivo.Informacoes.Nome &&
                d.Arquivo.Informacoes.Extensao == documentacao.Arquivo.Informacoes.Extensao &&
                d.Arquivo.Informacoes.Tamanho == documentacao.Arquivo.Informacoes.Tamanho);

            listaDocumentacoesSmartShare = listaDocumentacoesSmartShare.OrderBy(o => o.Auditoria.CriadoEm);

            if (listaDocumentacoesSmartShare.Any() && listaDocumentacoesSmartShare.First().Status.Ativo)
            {
                var documentacaoSmartShare = listaDocumentacoesSmartShare.First();
                documentacaoSmartShare.Inativar(request.InscricaoKey);
                _inscricaoDocumentacaoRepository.Update(documentacaoSmartShare);
            }
        }

        await _unitOfWork.CommitAsync(cancellationToken);
    }
}