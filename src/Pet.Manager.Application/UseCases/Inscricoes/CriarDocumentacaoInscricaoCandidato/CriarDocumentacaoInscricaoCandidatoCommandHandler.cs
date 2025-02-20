using Amazon.S3;

using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application.DTOs.Inscricoes;
using Anima.Inscricao.Application.Interfaces.Services;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Enums;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Inscricoes;
using Anima.Inscricao.Domain.Inscricoes.Entities;
using Anima.Inscricoes.Domain.Inscricoes;

using Microsoft.Extensions.Logging;

namespace Anima.Inscricao.Application.UseCases.Inscricoes.CriarDocumentacaoInscricaoCandidato;

public class CriarDocumentacaoInscricaoCandidatoCommandHandler : ICommandHandler<CriarDocumentacaoInscricaoCandidatoCommand, List<InscricaoDocumentacaoDto>?>
{
    private readonly IInscricaoRepository _inscricaoRepository;
    private readonly IInscricaoDocumentacaoRepository _inscricaoDocumentacaoRepository;
    private readonly INotificationContext _notificationContext;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAmazonS3Service _amazonS3Service;
    private readonly ILogger<CriarDocumentacaoInscricaoCandidatoCommandHandler> _logger;

    public CriarDocumentacaoInscricaoCandidatoCommandHandler(
        IInscricaoRepository inscricaoRepository,
        IInscricaoDocumentacaoRepository inscricaoDocumentacaoRepository,
        INotificationContext notificationContext,
        IUnitOfWork unitOfWork,
        IAmazonS3Service amazonS3Service,
        ILogger<CriarDocumentacaoInscricaoCandidatoCommandHandler> logger)
    {
        _inscricaoRepository = inscricaoRepository;
        _inscricaoDocumentacaoRepository = inscricaoDocumentacaoRepository;
        _notificationContext = notificationContext;
        _unitOfWork = unitOfWork;
        _amazonS3Service = amazonS3Service;
        _logger = logger;
    }

    public async Task<List<InscricaoDocumentacaoDto>?> Handle(CriarDocumentacaoInscricaoCandidatoCommand request, CancellationToken cancellationToken)
    {
        var inscricaoCandidatoId = await _inscricaoRepository.ObterInscriaoCandidatoIdAsync(request.InscricaoKey);

        var retorno = new List<InscricaoDocumentacaoDto>();

        try
        {
            foreach (var documentacao in request.Documentos)
            {
                string chaveS3 = string.Empty;

                using (var ms = new MemoryStream())
                {
                    documentacao.Arquivo!.CopyTo(ms);
                    chaveS3 = await _amazonS3Service.UploadArquivoAsync(ms.ToArray(), documentacao.Arquivo!.FileName, request.InscricaoKey, cancellationToken);
                }

                var arquivo = new Arquivo(
                    new Arquivo.InfoArquivo(
                        documentacao.Arquivo!.FileName,
                        Path.GetExtension(documentacao.Arquivo.FileName),
                        documentacao.Arquivo.Length),
                    TipoLocalArquivo.S3,
                    chaveS3);

                var documentacaoInscricao = DocumentacaoInscricao
                .Criar(inscricaoCandidatoId, request.InscricaoKey, documentacao.Observacoes, documentacao.Tipo, arquivo)
                .NotificarFalhas(_notificationContext)
                .ObterRetorno();

                if (documentacaoInscricao == null)
                {
                    await _amazonS3Service.RemoverArquivoAsync(arquivo.Chave, cancellationToken);
                    return null;
                }

                retorno.Add(new InscricaoDocumentacaoDto()
                {
                    Key = documentacaoInscricao.Key,
                    ExtensaoArquivo = documentacaoInscricao.Arquivo.Informacoes.Extensao,
                    TipoLocalArquivo = (int)documentacaoInscricao.Arquivo.TipoLocalArquivo,
                    ChaveArquivo = documentacaoInscricao.Arquivo?.Chave,
                    NomeArquivo = documentacaoInscricao.Arquivo?.Informacoes.Nome,
                    Observacoes = documentacaoInscricao.Observacoes,
                    TamanhoArquivo = documentacaoInscricao.Arquivo?.Informacoes.Tamanho,
                    Tipo = documentacaoInscricao.Tipo.ToString(),
                });

                await _inscricaoDocumentacaoRepository.InsertAsync(documentacaoInscricao);
            }

            await _unitOfWork.CommitAsync(cancellationToken);
        }
        catch (AmazonS3Exception s3Exception)
        {
            _logger.LogError(s3Exception, "Erro ao realizar upload de arquivo no S3");

            if (retorno.Any())
            {
                foreach (var inscricaoDocumentacao in retorno)
                {
                    await _amazonS3Service.RemoverArquivoAsync(inscricaoDocumentacao.ChaveArquivo!, cancellationToken);
                }
            }

            throw;
        }

        return retorno;
    }
}