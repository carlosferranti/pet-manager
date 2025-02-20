using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Intakes;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.IntegracaoSistemas;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Intakes.PesquisarIntake;

public class PesquisarIntakeQueryHandler : IQueryHandler<PesquisarIntakeQuery, ResultadoPaginadoDto<IntakeDto>>
{
    private readonly IIntakeRepository _intakeRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;

    public PesquisarIntakeQueryHandler(IIntakeRepository intakeRepository, IIntegracaoSistemaRepository integracaoSistemaRepository)
    {
        _intakeRepository = intakeRepository;
        _integracaoSistemaRepository = integracaoSistemaRepository;
    }

    public async Task<ResultadoPaginadoDto<IntakeDto>> Handle(PesquisarIntakeQuery request, CancellationToken cancellationToken)
    {
        var query = from intake in _intakeRepository.GetQueryable()
                    join integracao in _integracaoSistemaRepository.GetQueryable()
                        on intake.IntegracaoIntake!.IntegracaoSistemaId equals integracao.Id into integracaoJoin
                    from integracaoSistema in integracaoJoin.DefaultIfEmpty()
                    select new IntakeDto()
                    {
                        Key = intake.Key,
                        Nome = intake.Nome,
                        VigenciaInicio = intake.Vigencia.Inicio,
                        VigenciaTermino = intake.Vigencia.Termino,
                        Integracao = integracaoSistema != null ? new SistemaIntegracaoDto()
                        {
                            CodigoOrigem = intake.IntegracaoIntake!.CodigoOrigem,
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

        return new ResultadoPaginadoDto<IntakeDto>(
            await queryResult.ToListAsync(cancellationToken),
            request.Paginacao.NumeroPagina,
            request.Paginacao.QuantidadeRegistros,
            totalRegistros
        );
    }
}