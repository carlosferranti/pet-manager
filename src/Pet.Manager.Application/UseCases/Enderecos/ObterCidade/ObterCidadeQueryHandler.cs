using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Enderecos;
using Anima.Inscricao.Domain.Enderecos;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Enderecos.ObterCidade;

public class ObterCidadeQueryHandler : IQueryHandler<ObterCidadeQuery, CidadeDto>
{
    private readonly ICidadeRepository _cidadeRepository;
    private readonly IEstadoRepository _estadoRepository;

    public ObterCidadeQueryHandler(ICidadeRepository cidadeRepository, IEstadoRepository estadoRepository)
    {
        _cidadeRepository = cidadeRepository;
        _estadoRepository = estadoRepository;
    }

    public async Task<CidadeDto> Handle(ObterCidadeQuery request, CancellationToken cancellationToken)
    {
        var result = from cidade in _cidadeRepository.GetQueryable()
                     join estado in _estadoRepository.GetQueryable()
                        on cidade.EstadoId equals estado.Id
                     where cidade.Key == request.Key
                     select new CidadeDto()
                     {
                         Key = cidade.Key,
                         Nome = cidade.Nome,
                         CodigoMunicipio = cidade.CodigoMunicipio,
                         Ddd = cidade.Ddd,
                         EstadoKey = estado.Key,
                     };

        return await result.SingleAsync();
    }
}
