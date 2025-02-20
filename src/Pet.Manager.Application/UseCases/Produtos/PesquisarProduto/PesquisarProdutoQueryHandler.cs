using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Produtos;
using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Produtos;
using Anima.Inscricao.Domain.Turnos;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Produtos.PesquisarProduto;

public class PesquisarProdutoQueryHandler : IQueryHandler<PesquisarProdutoQuery, ResultadoPaginadoDto<ProdutoDto>>
{
    private readonly IProdutoRepository _produtoRepository;
    private readonly IInstituicaoRepository _instituicaoRepository;
    private readonly ICampusRepository _campusRepository;
    private readonly ICursoRepository _cursoRepository;
    private readonly ITurnoRepository _turnoRepository;

    public PesquisarProdutoQueryHandler(
        IProdutoRepository produtoRepository, 
        IInstituicaoRepository instituicaoRepository, 
        ICampusRepository campusRepository, 
        ICursoRepository cursoRepository, 
        ITurnoRepository turnoRepository)
    {
        _produtoRepository = produtoRepository;
        _instituicaoRepository = instituicaoRepository;
        _campusRepository = campusRepository;
        _cursoRepository = cursoRepository;
        _turnoRepository = turnoRepository;
    }

    public async Task<ResultadoPaginadoDto<ProdutoDto>> Handle(PesquisarProdutoQuery request, CancellationToken cancellationToken)
    {
        var query = from produto in _produtoRepository.GetQueryable()
                    join instituicao in _instituicaoRepository.GetQueryable()
                        on produto.InstituicaoId equals instituicao.Id
                    join campus in _campusRepository.GetQueryable()
                        on produto.CampusId equals campus.Id
                    join curso in _cursoRepository.GetQueryable()
                        on produto.CursoId equals curso.Id
                    join turno in _turnoRepository.GetQueryable()
                        on produto.TurnoId equals turno.Id
                    select new ProdutoDto
                    {
                        Key = produto.Key,
                        InstituicaoKey = instituicao.Key,
                        CampusKey = campus.Key,
                        CursoKey = curso.Key,
                        TurnoKey = turno.Key,
                        Sku = produto.Sku

                    };

        if (request.Filtros?.InstituicaoKey != null)
        {
            query = query.Where(o => o.InstituicaoKey == request.Filtros!.InstituicaoKey.Value);
        }

        if (request.Filtros?.CampusKey != null)
        {
            query = query.Where(o => o.CampusKey == request.Filtros!.CampusKey.Value);
        }

        if (request.Filtros?.CursoKey != null)
        {
            query = query.Where(o => o.CursoKey == request.Filtros!.CursoKey.Value);
        }

        if (request.Filtros?.TurnoKey != null)
        {
            query = query.Where(o => o.TurnoKey == request.Filtros!.TurnoKey.Value);
        }

        if (request.Filtros?.Sku != null)
        {
            query = query.Where(o => o.Sku == request.Filtros!.Sku);
        }

        int totalRegistros = await query.CountAsync();

        var queryResult = query
            .OrderBy(o => o.Key)
            .Skip(request.Paginacao.QuantidadeRegistros * (request.Paginacao.NumeroPagina - 1))
            .Take(request.Paginacao.QuantidadeRegistros);

        return new ResultadoPaginadoDto<ProdutoDto>(
            await queryResult.ToListAsync(cancellationToken),
            request.Paginacao.NumeroPagina,
            request.Paginacao.QuantidadeRegistros,
            totalRegistros
        );
    }
}
