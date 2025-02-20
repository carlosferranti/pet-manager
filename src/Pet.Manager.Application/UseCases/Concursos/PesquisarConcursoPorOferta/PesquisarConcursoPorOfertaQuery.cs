using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.Constants;
using Anima.Inscricao.Application.DTOs.Concursos;

namespace Anima.Inscricao.Application.UseCases.Concursos.PesquisarConcursoPorOferta;

public class PesquisarConcursoPorOfertaQuery : IQuery<List<ConcursosPorOfertaDto>>
{
    public string Cpf {  get; set; } = string.Empty;

    public Guid OfertaKey { get; set; }

    public Guid LinkKey { get; set; } = LinkConstants.LinkPadrao;

    public Guid? FormaEntradaKey { get; set; }
}
