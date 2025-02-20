using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Inscricoes;
using Anima.Inscricao.Application.Extensions;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Inscricoes.Enums;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricoes.Domain.Inscricoes;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Inscricoes.PesquisarInscricoesCandidatos;

public class PesquisarInscricoesCandidatosQueryHandler : IQueryHandler<PesquisarInscricoesCandidatosQuery, ResultadoPaginadoDto<CandidatoDto>>
{
    private readonly IInscricaoRepository _inscricaoRepository;
    private readonly IOfertaConcursoRepository _ofertaConcursoRepository;
    private readonly IConcursoRepository _concursoRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;


    public PesquisarInscricoesCandidatosQueryHandler(IInscricaoRepository inscricaoRepository, IOfertaConcursoRepository ofertaConcursoRepository, IConcursoRepository concursoRepository, IIntegracaoSistemaRepository integracaoSistemaRepository)
    {
        _inscricaoRepository = inscricaoRepository;
        _ofertaConcursoRepository = ofertaConcursoRepository;
        _concursoRepository = concursoRepository;
        _integracaoSistemaRepository = integracaoSistemaRepository;
    }

    public async Task<ResultadoPaginadoDto<CandidatoDto>> Handle(PesquisarInscricoesCandidatosQuery request, CancellationToken cancellationToken)
    {
        var query = from inscricao in _inscricaoRepository.GetQueryable()
                    join ofertaConcurso in _ofertaConcursoRepository.GetQueryable()
                        on inscricao.Oferta.OfertaConcursoId equals ofertaConcurso.Id
                    join concurso in _concursoRepository.GetQueryable()
                        on ofertaConcurso.ConcursoId equals concurso.Id
                    join integracaoSistema in _integracaoSistemaRepository.GetQueryable()
                        on concurso.IntegracaoConcurso.IntegracaoSistemaId equals integracaoSistema.Id
                    where integracaoSistema.Nome == "Vestib"
                    && (!request.Filtros.CandidatoId.HasValue || inscricao.Id == request.Filtros.CandidatoId)
                    && (string.IsNullOrEmpty(request.Filtros.ConcursoId) || concurso.IntegracaoConcurso.CodigoOrigem == request.Filtros.ConcursoId)
                    && (string.IsNullOrEmpty(request.Filtros.Nome) || inscricao.Candidato.Nome == request.Filtros.Nome)
                    && (string.IsNullOrEmpty(request.Filtros.Cpf) || inscricao.Documentos.Any(x => x.Tipo == TipoDocumentoInscricao.Cpf && x.Valor == request.Filtros.Cpf))
                    && (request.Filtros.StatusInscricaoIds == null || inscricao.Status.Any(s => s.Atual && request.Filtros.StatusInscricaoIds.Contains((int)s.Tipo)))
                    select new CandidatoDto()
                    {
                        Id = inscricao.Id,
                        Key = inscricao.Key,
                        InfoPessoais = new InfoPessoaisDto()
                        {
                            Nome = inscricao.Candidato.Nome
                        },
                        InfoDocumentos = new InfoDocumentosDto()
                        {
                            Cpf = inscricao.Documentos.FirstOrDefault(x => x.Tipo == TipoDocumentoInscricao.Cpf).ValorFormatado
                        },
                        statusInscricao = new StatusInscricaoDto()
                        {
                            Id = (int)inscricao.Status.First(s => s.Atual).Tipo,
                            Nome = EnumExtensions.Description(inscricao.Status.First(s => s.Atual).Tipo)
                        }
                    };

        int totalRegistros = await query.CountAsync();

        var queryResult = query
            .Skip(request.Paginacao.QuantidadeRegistros * (request.Paginacao.NumeroPagina - 1))
            .Take(request.Paginacao.QuantidadeRegistros);

        return new ResultadoPaginadoDto<CandidatoDto>(
            totalRegistros > 0 ? await queryResult.ToListAsync(cancellationToken) : [],
            request.Paginacao.NumeroPagina,
            request.Paginacao.QuantidadeRegistros,
            totalRegistros
        );
    }
}