using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Modalidades;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Modalidades;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Modalidades.PesquisarModalidade;

public class PesquisarModalidadeQueryHandler : IQueryHandler<PesquisarModalidadeQuery, ResultadoPaginadoDto<ModalidadeDto>>
{
    private readonly IModalidadeRepository _modalidadeRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;

    public PesquisarModalidadeQueryHandler(
        IModalidadeRepository modalidadeRepository,
        IIntegracaoSistemaRepository integracaoSistemaRepository)
    {
        _modalidadeRepository = modalidadeRepository;
        _integracaoSistemaRepository = integracaoSistemaRepository;
    }

    public async Task<ResultadoPaginadoDto<ModalidadeDto>> Handle(PesquisarModalidadeQuery request, CancellationToken cancellationToken)
    {
        var query = from modalidade in _modalidadeRepository.GetQueryable()
                    join integracao in _integracaoSistemaRepository.GetQueryable()
                        on modalidade.IntegracaoModalidade!.IntegracaoSistemaId equals integracao.Id into integracaoJoin
                    from integracaoSistema in integracaoJoin.DefaultIfEmpty()
                    select new ModalidadeDto()
                    {
                        Key = modalidade.Key,
                        Nome = modalidade.Nome,
                        Descricao = modalidade.Descricao,
                        Integracao = integracaoSistema != null ? new SistemaIntegracaoDto()
                        {
                            CodigoOrigem = modalidade.IntegracaoModalidade!.CodigoOrigem,
                            NomeSistema = integracaoSistema.Nome
                        } : null
                    };

        if (!string.IsNullOrEmpty(request.Filtros?.Nome))
        {
            query = query.Where(o => o.Nome.ToUpper().Contains(request.Filtros.Nome.ToUpper()));
        }

        int totalRegistros = await query.CountAsync();

        var queryResult = query
            .OrderBy(o => o.Nome)
            .Skip(request.Paginacao.QuantidadeRegistros * (request.Paginacao.NumeroPagina - 1))
            .Take(request.Paginacao.QuantidadeRegistros);

        return new ResultadoPaginadoDto<ModalidadeDto>(
            await queryResult.ToListAsync(cancellationToken),
            request.Paginacao.NumeroPagina,
            request.Paginacao.QuantidadeRegistros,
            totalRegistros
        );
    }
}
