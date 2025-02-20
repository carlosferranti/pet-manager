using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Inscricoes.RemoverDocumentacaoInscricaoCandidato;

public class RemoverDocumentacaoInscricaoCandidatoCommand : ICommand
{
    [JsonIgnore]
    public Guid InscricaoDocumentacaoKey { get; set; }

    [JsonIgnore]
    public Guid InscricaoKey { get; set; }
}
