using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.Constants;
using Anima.Inscricao.Application.DTOs.OfertaConcursos;
using System;

namespace Anima.Inscricao.Application.UseCases.OfertaConcursos.PesquisarCursoOfertadoDetalhe;

public class PesquisarCursoOfertadoDetalheQuery : IQuery<List<CursoOfertadoDetalheDto>>
{
    public PesquisarCursoOfertadoDetalheFiltros? Filtros { get; set; } 

    public record PesquisarCursoOfertadoDetalheFiltros
    {
        public Guid? MarcaKey { get; set; }

        public Guid? IntakeKey { get; set; }

        public Guid? NivelCursoKey { get; set; }

        public Guid? LinkKey { get; set; } = LinkConstants.LinkPadrao;

        public Guid? OfertaKey { get; set; }

        public string? CursoNome { get; set; }
    }
}