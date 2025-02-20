using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.CursosExternos;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Domain.CursosExternos;
using Anima.Inscricao.Domain.IntegracaoSistemas;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.CursosExternos.ObterCursoExterno;

public class ObterCursoExternoQueryHandler : IQueryHandler<ObterCursoExternoQuery, CursoExternoDto>
{
    private readonly ICursoExternoRepository _cursoExternoRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;

    public ObterCursoExternoQueryHandler(
        ICursoExternoRepository cursoExternoRepository,
        IIntegracaoSistemaRepository integracaoSistemaRepository)
    {
        _cursoExternoRepository = cursoExternoRepository;
        _integracaoSistemaRepository = integracaoSistemaRepository;
    }

    public async Task<CursoExternoDto> Handle(ObterCursoExternoQuery request, CancellationToken cancellationToken)
    {
        var query = from cursoExterno in _cursoExternoRepository.GetQueryable()
                    where cursoExterno.Key == request.Key
                    select new CursoExternoDto
                    {
                        Key = cursoExterno.Key,
                        Nome = cursoExterno.Nome,
                        Integracoes = (from integracao in cursoExterno.IntegracoesCursoExterno.DefaultIfEmpty()
                                             join integracaoSistema in _integracaoSistemaRepository.GetQueryable()
                                                on integracao.IntegracaoSistemaId equals integracaoSistema.Id into sistemaIntegracaoGroup
                                             from sistemaIntegracao in sistemaIntegracaoGroup.DefaultIfEmpty()
                                             select new SistemaIntegracaoDto
                                             {
                                                NomeSistema = sistemaIntegracao.Nome,
                                                CodigoOrigem = integracao.CodigoOrigem
                                             }).ToList()
                    };

        return await query.SingleAsync();
    }
}
