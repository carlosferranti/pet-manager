using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Enderecos;
using Anima.Inscricao.Domain.Enderecos;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Enderecos.ObterEstado;

public class ObterEstadoQueryHandler : IQueryHandler<ObterEstadoQuery, EstadoDto>
{
    private readonly IPaisRepository _paisRepository;
    private readonly IEstadoRepository _estadoRepository;

    public ObterEstadoQueryHandler(IPaisRepository paisRepository, IEstadoRepository estadoRepository)
    {
        _paisRepository = paisRepository;
        _estadoRepository = estadoRepository;
    }

    public async Task<EstadoDto> Handle(ObterEstadoQuery request, CancellationToken cancellationToken)
    {
        var result = from estado in _estadoRepository.GetQueryable()
                     join pais in _paisRepository.GetQueryable()
                        on estado.PaisId equals pais.Id
                     where estado.Key == request.Key
                     select new EstadoDto()
                     {
                         Key = estado.Key,
                         Nome = estado.Nome,
                         Sigla = estado.Sigla,
                         PaisKey = pais.Key,
                     };

        return await result.SingleAsync();
    }
}
