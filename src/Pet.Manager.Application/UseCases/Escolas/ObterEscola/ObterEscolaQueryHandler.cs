using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Escola;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Escolas;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Escolas.ObterEscola;

public class ObterEscolaQueryHandler : IQueryHandler<ObterEscolaQuery, EscolaDto>
{
    private readonly IEscolaRepository _escolaRepository;
    private readonly ICidadeRepository _cidadeRepository;

    public ObterEscolaQueryHandler(
        IEscolaRepository escolaRepository, 
        ICidadeRepository cidadeRepository)
    {
        _escolaRepository = escolaRepository;
        _cidadeRepository = cidadeRepository;
    }

    public async Task<EscolaDto> Handle(ObterEscolaQuery request, CancellationToken cancellationToken)
    {
        var result = from escola in _escolaRepository.GetQueryable()
                     join cidade in _cidadeRepository.GetQueryable().DefaultIfEmpty()
                        on escola.CidadeId equals cidade.Id into cidadeJoin
                     from cidadeEscola in cidadeJoin.DefaultIfEmpty()
                     where escola.Key == request.Key
                     select new EscolaDto()
                     {
                         Key = escola.Key,
                         Nome = escola.Nome,
                         CodigoInep = escola.CodigoInep,
                         CidadeKey = cidadeEscola.Key,
                     };

        return await result.SingleAsync();

    }
}
