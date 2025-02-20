using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Modalidades;
using Anima.Inscricao.Domain.Modalidades;

namespace Anima.Inscricao.Application.UseCases.Modalidades.ObterModalidade;

public class ObterModalidadeQueryHandler : IQueryHandler<ObterModalidadeQuery, ModalidadeDto>
{
    private readonly IModalidadeRepository _modalidadeRepository;

    public ObterModalidadeQueryHandler(IModalidadeRepository modalidadeRepository)
    {
        _modalidadeRepository = modalidadeRepository;
    }

    public async Task<ModalidadeDto> Handle(ObterModalidadeQuery request, CancellationToken cancellationToken)
    {
        var modalidade = await _modalidadeRepository.GetAsync(request.Key);

        return new ModalidadeDto()
        {
            Key = modalidade.Key,
            Nome = modalidade.Nome,
            Descricao = modalidade.Descricao,
        };
    }
}