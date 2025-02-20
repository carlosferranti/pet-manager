using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Instituicao;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Marcas;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Instituicoes.ObterInstituicao;

public class ObterInstituicaoQueryHandler : IQueryHandler<ObterInstituicaoQuery, InstituicaoDto>
{
    private readonly IInstituicaoRepository _instituicaoRepository;
    private readonly IMarcaRepository _marcaRepository;

    public ObterInstituicaoQueryHandler(
        IInstituicaoRepository instituicaoRepository, 
        IMarcaRepository marcaRepository)
    {
        _instituicaoRepository = instituicaoRepository;
        _marcaRepository = marcaRepository;
    }

    public async Task<InstituicaoDto> Handle(ObterInstituicaoQuery request, CancellationToken cancellationToken)
    {
        var query = from instituicao in _instituicaoRepository.GetQueryable()
                    join marca in _marcaRepository.GetQueryable()
                        on instituicao.MarcaId equals marca.Id
                    where instituicao.Key == request.Key
                    select new InstituicaoDto()
                    {
                        Key = instituicao.Key,
                        Nome = instituicao.Nome,
                        Sigla = instituicao.Sigla,
                        MarcaKey = marca.Key,
                    };

        return await query.SingleAsync();
    }
}
