using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application.Constants;
using Anima.Inscricao.Application.DTOs.Candidatos;
using Anima.Inscricao.Application.DTOs.Inscricoes;
using Anima.Inscricao.Application.DTOs.Instituicao;
using Anima.Inscricao.Application.Enums;
using Anima.Inscricao.Application.Interfaces.Repositories;
using Anima.Inscricao.Domain.FormasEntrada.Enums;

namespace Anima.Inscricao.Application.UseCases.Inscricoes.CalcularMotorCoi;

public class CalcularMotorCoiCommandHandler : ICommandHandler<CalcularMotorCoiCommand, Guid?>
{
    private readonly ICandidatoRepository _candidatoRepository;

    public CalcularMotorCoiCommandHandler(ICandidatoRepository candidatoRepository)
    {
        _candidatoRepository = candidatoRepository;
    }

    public async Task<Guid?> Handle(CalcularMotorCoiCommand request, CancellationToken cancellationToken)
    {
        IEnumerable<CandidatoVinculoDto>? vinculoCandidato = request.RaVinculo is null ? null : await _candidatoRepository.PesquisarVinculoCandidatoAsync(request.CpfCandidato, null, request.RaVinculo);

        // TODO - Buscar inscrições no banco da nova ficha e validar que só pode ter 1 inscirção COI -> Talvez deixar para fazer isso na abertura de card
        // var inscricoesCandidato = _inscricaoRepository.BuscarPorCpf(cpfFormatado);

        FormaDeEntradaCoi formaIngresso = await DeterminarFormaIngresso(request, vinculoCandidato?.FirstOrDefault());

        switch(formaIngresso)
        {
            case FormaDeEntradaCoi.TransferenciaExterna:
                return FormaEntradaConstants.TransferenciaExterna;
            case FormaDeEntradaCoi.TransferenciaInterna:
                return FormaEntradaConstants.TransferenciaInterna;
            case FormaDeEntradaCoi.Reopcao:
                return FormaEntradaConstants.Reopcao;
            case FormaDeEntradaCoi.Reingresso:
                return FormaEntradaConstants.Reingresso;
            case FormaDeEntradaCoi.ReingressoReopcao:
                return FormaEntradaConstants.ReingressoComReopcao;
            case FormaDeEntradaCoi.Destrancamento:
                return FormaEntradaConstants.Destrancamento;
            case FormaDeEntradaCoi.DestrancamentoReopcao:
                return FormaEntradaConstants.DestrancamentoComReopcao;
            case FormaDeEntradaCoi.SegundaGraduacao:
                return FormaEntradaConstants.SegundaGraduacao;
            case FormaDeEntradaCoi.PrimeiroSemestre:
            case FormaDeEntradaCoi.NaoSeEncaixa:
            default:
                return null;
        }
    }

    private async Task<FormaDeEntradaCoi> DeterminarFormaIngresso(
    CalcularMotorCoiCommand request,
    CandidatoVinculoDto? vinculoSelecionado)
    {
        FormaDeEntradaCoi formaIngresso;
        ValidacaoCoiDto camposValidados;
        TipoVinculoAnima vinculoAnima;


        if (request.FormaIngressoEscolhida == FormaEntradaConstants.SegundaGraduacao)
        {
            formaIngresso = FormaDeEntradaCoi.SegundaGraduacao;
        }
        else if (vinculoSelecionado == null)
        {
            formaIngresso = FormaDeEntradaCoi.TransferenciaExterna;
        }
        else
        {
            camposValidados = await ValidarCandidatoAsync(request, vinculoSelecionado);
            vinculoAnima = ValidarVinculo(vinculoSelecionado.CodigoStatusAluno.Equals(StatusMatricula.AtivoFinanceiro) 
                                          && vinculoSelecionado.CodigoStatusFinanceiro.HasValue 
                                          ? (int)vinculoSelecionado.CodigoStatusFinanceiro 
                                          : (int)vinculoSelecionado.CodigoStatusAluno);

            if (!camposValidados.InstituicaoIgual){
                formaIngresso = FormaDeEntradaCoi.TransferenciaExterna;
                return formaIngresso;
            }

            switch (vinculoAnima)
            {
                case TipoVinculoAnima.Concluido:
                    formaIngresso = FormaDeEntradaCoi.SegundaGraduacao;
                    break;

                case TipoVinculoAnima.Ativo:
                    if (camposValidados.InstituicaoIgual &&
                        camposValidados.CursoIgual &&
                        camposValidados.TurnoIgual &&
                        !camposValidados.CampusIgual)
                    {
                        formaIngresso = FormaDeEntradaCoi.TransferenciaInterna;
                    }
                    else if (camposValidados.InstituicaoIgual &&
                             (!camposValidados.CursoIgual ||
                              !camposValidados.TurnoIgual ||
                              !camposValidados.CampusIgual))
                    {
                        formaIngresso = FormaDeEntradaCoi.Reopcao;
                    }
                    else
                    {
                        formaIngresso = FormaDeEntradaCoi.TransferenciaExterna;
                    }
                    break;

                case TipoVinculoAnima.Trancado:
                    if (camposValidados.InstituicaoIgual &&
                        camposValidados.CursoIgual &&
                        camposValidados.TurnoIgual &&
                        camposValidados.CampusIgual &&
                        camposValidados.ModalidadeIgual)
                    {
                        formaIngresso = FormaDeEntradaCoi.Destrancamento;
                    }
                    else
                    {
                        formaIngresso = FormaDeEntradaCoi.DestrancamentoReopcao;
                    }
                    break;

                case TipoVinculoAnima.Abandono:
                    if (camposValidados.InstituicaoIgual &&
                        camposValidados.CursoIgual &&
                        camposValidados.TurnoIgual &&
                        camposValidados.CampusIgual &&
                        camposValidados.ModalidadeIgual)
                    {
                        formaIngresso = FormaDeEntradaCoi.Reingresso;
                    }
                    else
                    {
                        formaIngresso = FormaDeEntradaCoi.ReingressoReopcao;
                    }
                    break;

                case TipoVinculoAnima.NaoVinculado:
                    formaIngresso = FormaDeEntradaCoi.TransferenciaExterna;
                    break;

                default:
                    formaIngresso = FormaDeEntradaCoi.TransferenciaExterna;
                    break;
                    //TODO - LOGAR ERRO EM VEZ DE DAR THROW
                    //throw new InvalidOperationException("Tipo de vínculo inválido");
            }
        }

        return formaIngresso;
    }

    private async Task<ValidacaoCoiDto> ValidarCandidatoAsync(CalcularMotorCoiCommand dadosCandidato, CandidatoVinculoDto vinculoCandidato)
    {
        ValidacaoCoiDto response = new ValidacaoCoiDto();

        IList<CampusVestibDto> detalhesCampusSiaf = await _candidatoRepository.BuscarDetalhesCampus(vinculoCandidato.CodigoCampusSiaf);
        CampusVestibDto? campusDetalhe = detalhesCampusSiaf.FirstOrDefault(cp => cp.CodigoCampus.Equals(dadosCandidato.CursoDestino.CodigoCampus));

        string? codigoInstituicaoOrigemEscolaridade = dadosCandidato?.CursoOrigem?.CodigoInstituicao?.ToString();
        string? nomeCursoOrigem = dadosCandidato?.CursoOrigem?.NomeCurso?.ToLower();

        string? codigoInstituicaoDestino = dadosCandidato?.CursoDestino?.CodigoInstituicao;
        string? nomeCursoDestino = dadosCandidato?.CursoDestino?.NomeCurso?.ToLower();
        string? nomeTurnoDestino = dadosCandidato?.CursoDestino?.NomeTurno?.ToLower();
        string? codigoCampusDestino = dadosCandidato?.CursoDestino?.CodigoCampus?.ToLower();

        if (!string.IsNullOrWhiteSpace(codigoInstituicaoOrigemEscolaridade))
        {
            IList<InstituicaoAssociadaVestibDto> instituicoesAnima = await _candidatoRepository.BuscarInstituicoesAssociadasAsync(codigoInstituicaoOrigemEscolaridade);
            List<string> instituicoes = instituicoesAnima.Select(instituicao => instituicao.CodigoInstituicao).ToList();
            if (codigoInstituicaoDestino != null && instituicoes.Contains(codigoInstituicaoDestino))
            {
                response.InstituicaoIgual = true;
            }
        }

        if (!String.IsNullOrEmpty(nomeCursoOrigem) && nomeCursoOrigem.Equals(nomeCursoDestino))
        {
            response.CursoIgual = true;
        }

        if (!(campusDetalhe is null) && codigoCampusDestino == campusDetalhe.CodigoCampus.ToLower())
        {
            response.CampusIgual = true;
        }

        if (nomeTurnoDestino == vinculoCandidato?.NomeTurno?.ToLower())
        {
            response.TurnoIgual = true;
        }

        if (ConverterModalidadeEmIndicador(dadosCandidato?.Modalidade) == vinculoCandidato?.IndicadorDigitalLive)
        {
            response.ModalidadeIgual = true;
        }

        return response;
    }

    private static TipoVinculoAnima ValidarVinculo(int codigoStatusAluno)
    {
        TipoVinculoAnima response = codigoStatusAluno switch
        {
            1 => TipoVinculoAnima.Ativo,
            2 => TipoVinculoAnima.Concluido,
            3 => TipoVinculoAnima.Abandono,
            4 => TipoVinculoAnima.Abandono,
            5 => TipoVinculoAnima.Trancado,
            6 => TipoVinculoAnima.NaoVinculado,
            8 => TipoVinculoAnima.Concluido,
            _ => TipoVinculoAnima.NaoVinculado
        };

        return response;
    }

    static string ConverterModalidadeEmIndicador(string? nomeModalidade)
    {
        if (string.IsNullOrWhiteSpace(nomeModalidade))
            return string.Empty;

        return string.Concat(nomeModalidade.Split(' ')
                        .Where(word => !string.IsNullOrWhiteSpace(word))
                        .Select(word => word[0].ToString().ToUpper()));
    }

}