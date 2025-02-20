using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application.Constants;
using Anima.Inscricao.Application.DTOs.Concursos;
using Anima.Inscricao.Application.Enums;

namespace Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraTransferencia;

public class ProcessarRegraConcursoTransferenciaCommandHandler : ICommandHandler<ProcessarRegraConcursoTransferenciaCommand, List<ConcursosPorOfertaDto>>
{
    public Task<List<ConcursosPorOfertaDto>> Handle(ProcessarRegraConcursoTransferenciaCommand request, CancellationToken cancellationToken)
    {
        //RN1: Card Transferência quando houver perfil:
        //Quando o candidato não houver vínculo com as IES da Anima,
        //para alunos ativos que não iniciaram no semestre vigente ao da inscrição e concurso cadastrado

        if (request.VinculosAnima == null ||
           !request.VinculosAnima.Exists(v => v.CodigoInstituicao.ToString() == request.Instituicao.Integracoes?.Find(i => i.NomeSistema.ToUpper() == IntegracaoSistemaConstants.Siaf.ToUpper())?.CodigoOrigem))
        {
            return Task.FromResult(request.Concursos);
        }

        if (request.VinculosAnima.Exists(v =>
            v.CodigoStatusAluno == StatusMatricula.Ativo &&
            v.DataEntrada.HasValue &&
            !request.VigenciaIntake.EstaEmAndamento(v.DataEntrada.Value)))
        {
            return Task.FromResult(request.Concursos);
        }

        request.Concursos.RemoveAll(c => c.FormaEntradaKey == FormaEntradaConstants.Transferencia);
        return Task.FromResult(request.Concursos);
    }
}
