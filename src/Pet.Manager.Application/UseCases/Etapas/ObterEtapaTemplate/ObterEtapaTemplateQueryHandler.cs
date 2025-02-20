using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Etapas;
using Anima.Inscricao.Domain.Etapas;

namespace Anima.Inscricao.Application.UseCases.Etapas.ObterEtapaTemplate;

public class ObterEtapaTemplateQueryHandler : IQueryHandler<ObterEtapaTemplateQuery, EtapaTemplateDto>
{
    private readonly IEtapaTemplateRepository _etapaTemplateRepository;

    public ObterEtapaTemplateQueryHandler(IEtapaTemplateRepository etapaTemplateRepository)
    {
        _etapaTemplateRepository = etapaTemplateRepository;
    }

    public async Task<EtapaTemplateDto> Handle(ObterEtapaTemplateQuery request, CancellationToken cancellationToken)
    {
        var etapa = await _etapaTemplateRepository.GetAsync(request.Key);

        return new EtapaTemplateDto()
        {
            Key = etapa.Key,
            Nome = etapa.Nome,
            Descricao = etapa.Descricao,
            NomeArquivo = etapa.NomeArquivo,
        };
    }
}