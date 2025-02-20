using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Cofiguracao;
using Anima.Inscricao.Domain.Configuracoes;

namespace Anima.Inscricao.Application.UseCases.Configuracoes.ObterConfiguracao;

public class ObterConfiguracaoQueryHandler : IQueryHandler<ObterConfiguracaoQuery, ConfiguracaoDto>
{
    private readonly IConfiguracaoRepository _configuracaoRepository;

    public ObterConfiguracaoQueryHandler(IConfiguracaoRepository configuracaoRepository)
    {
        _configuracaoRepository = configuracaoRepository;
    }

    public async Task<ConfiguracaoDto> Handle(ObterConfiguracaoQuery request, CancellationToken cancellationToken)
    {
        var configuracao = await _configuracaoRepository.GetAsync(request.Key);

        return new ConfiguracaoDto()
        {
            Key = configuracao.Key,
            ChaveGenerica = configuracao.ChaveGenerica,
            Valor = configuracao.Valor,
            DataCriacao = configuracao.Auditoria.CriadoEm,
            DataAlteracao = configuracao.Auditoria.AlteradoEm,
        };
    }
}
