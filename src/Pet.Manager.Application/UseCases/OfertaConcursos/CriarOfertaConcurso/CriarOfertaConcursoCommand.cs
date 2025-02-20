using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Domain.OfertaConcursos.Enums;

namespace Anima.Inscricao.Application.UseCases.OfertaConcursos.CriarOfertaConcurso;

public class CriarOfertaConcursoCommand : ICommand<EntityKeyDto>
{
    public Guid ConcursoKey { get; set; }

    public Guid OfertaKey { get; set; }

    public SistemaIntegracaoDto? Integracao { get; set; }

    public List<TipoOpcaoAcesso>? OpcaoAcesso { get; set; }
}
