using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application.DTOs.Inscricoes;
using Anima.Inscricao.Domain.Inscricoes.Enums;

using Microsoft.AspNetCore.Http;

namespace Anima.Inscricao.Application.UseCases.Inscricoes.CriarDocumentacaoInscricaoCandidato;

public class CriarDocumentacaoInscricaoCandidatoCommand : ICommand<List<InscricaoDocumentacaoDto>?>
{
    [JsonIgnore]
    public Guid InscricaoKey { get; set; }

    public List<InfoDocumentoCommand> Documentos { get; set; } = new();

    public record InfoDocumentoCommand
    {
        public IFormFile? Arquivo { get; init; }

        public string? Observacoes { get; set; }

        public TipoDocumentacaoInscricao Tipo { get; set; }
    }
}