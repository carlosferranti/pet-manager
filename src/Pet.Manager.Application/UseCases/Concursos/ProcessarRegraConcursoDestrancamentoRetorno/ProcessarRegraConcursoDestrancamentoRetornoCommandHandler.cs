using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application.Constants;
using Anima.Inscricao.Application.DTOs.Concursos;
using Anima.Inscricao.Application.Enums;

namespace Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoDestrancamentoReopcao;

public class ProcessarRegraConcursoDestrancamentoRetornoCommandHandler : ICommandHandler<ProcessarRegraConcursoDestrancamentoRetornoCommand, List<ConcursosPorOfertaDto>>
{
    public Task<List<ConcursosPorOfertaDto>> Handle(ProcessarRegraConcursoDestrancamentoRetornoCommand request, CancellationToken cancellationToken)
    {
        //RN1: Card Destrancamento quando houver perfil:
        //Quando o candidato for ex aluno da Anima(validar a IES de inscrição)
        //com os status - trancado, cancelado, abandonado ou ativo financeiro e concurso cadastrado

        var statusPerfilDestrancamentoRetorno = new List<StatusMatricula>
        {
            StatusMatricula.Trancado,
            StatusMatricula.CanceladoDesligado,
            StatusMatricula.Abandono,
            StatusMatricula.AtivoFinanceiro
        };

        if (request.VinculosAnima != null &&
            request.VinculosAnima.Exists(v => statusPerfilDestrancamentoRetorno.Contains(v.CodigoStatusAluno) &&
            v.CodigoInstituicao.ToString() == request.Instituicao.Integracoes?.Find(i => i.NomeSistema.ToUpper() == IntegracaoSistemaConstants.Siaf.ToUpper())?.CodigoOrigem))
        {
            return Task.FromResult(request.Concursos);
        }

        request.Concursos.RemoveAll(c => c.FormaEntradaKey == FormaEntradaConstants.DestrancamentoRetorno);

        return Task.FromResult(request.Concursos);
    }
}
