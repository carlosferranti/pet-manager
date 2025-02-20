using System.Linq;

using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.Constants;
using Anima.Inscricao.Application.DTOs.Candidatos;
using Anima.Inscricao.Application.Enums;
using Anima.Inscricao.Application.Interfaces.Repositories;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Marcas;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Anima.Inscricao.Application.UseCases.Inscricoes.PesquisarVinculoCandidato;

public class PesquisarVinculoCandidatoQueryHandler : IQueryHandler<PesquisarVinculoCandidatoQuery, IEnumerable<CandidatoVinculoDto>>
{
    private readonly ICandidatoRepository _candidatoRepository;
    private readonly IMarcaRepository _marcaRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;
    private readonly ILogger<PesquisarVinculoCandidatoQueryHandler> _logger;
    private readonly List<Guid> FormasEntradaConsiderandoMarca = new()
    {
        FormaEntradaConstants.DestrancamentoRetorno,
        FormaEntradaConstants.Reopcao,
    };

    public PesquisarVinculoCandidatoQueryHandler(
        ICandidatoRepository candidatoRepository,
        IMarcaRepository marcaRepository,
        IIntegracaoSistemaRepository integracaoSistemaRepository,
        ILogger<PesquisarVinculoCandidatoQueryHandler> logger)
    {
        _candidatoRepository = candidatoRepository;
        _marcaRepository = marcaRepository;
        _integracaoSistemaRepository = integracaoSistemaRepository;
        _logger = logger;
    }

    public async Task<IEnumerable<CandidatoVinculoDto>> Handle(PesquisarVinculoCandidatoQuery request, CancellationToken cancellationToken)
    {
        try
        {
            string? codigoIntegracaoMarca = null;

            if(request.FormaEntradaKey.HasValue &&
                FormasEntradaConsiderandoMarca.Contains(request.FormaEntradaKey.Value))
            {
                var queryMarca = from marca in _marcaRepository.GetQueryable()
                                 from integracaoMarca in marca.IntegracoesMarcas
                                 join sistema in _integracaoSistemaRepository.GetQueryable()
                                    on integracaoMarca.IntegracaoSistemaId equals sistema.Id into integracaoSistemaJoin
                                 from integracaoSistema in integracaoSistemaJoin.DefaultIfEmpty()
                                 where marca.Key == request.MarcaKey &&
                                 integracaoSistema.Nome.ToUpper() == IntegracaoSistemaConstants.Vestib.ToUpper()
                                 select integracaoMarca.CodigoOrigem;

                codigoIntegracaoMarca = await queryMarca.SingleOrDefaultAsync(cancellationToken);
            }

            var vinculos =  await _candidatoRepository.PesquisarVinculoCandidatoAsync(request.Cpf, codigoIntegracaoMarca);
            
            foreach (var vinculo in vinculos)
            {
                if(vinculo.CodigoStatusAluno == StatusMatricula.AtivoFinanceiro && 
                    vinculo.CodigoStatusFinanceiro.HasValue)
                {
                    vinculo.CodigoStatusAluno = (StatusMatricula)((int)vinculo.CodigoStatusFinanceiro);
                }
            }

            return vinculos;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao pesquisar os vinculos do candidato no SIAF. {@Request}", request);
            return Enumerable.Empty<CandidatoVinculoDto>();
        }
    }
}