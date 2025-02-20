using Anima.Inscricao.Application.DTOs.Enem;

namespace Anima.Inscricao.Application.Interfaces.Services;

public interface IEnemService
{
    Task SolicitarClassificacaoEnemAsync(SolicitarClassificacaoRequestDto request);

    Task<ClassificacaoEnemDto?> ObterClassificacaoEnemAsync(ObterClassificacaoResquestDto request);
}
