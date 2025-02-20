using Anima.Inscricao.Application.DTOs.Candidatos;
using Anima.Inscricao.Application.DTOs.Inscricoes;
using Anima.Inscricao.Application.DTOs.Instituicao;

namespace Anima.Inscricao.Application.Interfaces.Repositories;

public interface ICandidatoRepository
{
    Task<IEnumerable<CandidatoVinculoDto>> PesquisarVinculoCandidatoAsync(string cpf, string? codigoMarca, string? ra = null);

    Task<IEnumerable<DiarioClasseCandidatoDto>> PesquisarDiarioClasseCandidatoAsync(string cpf);

    Task<IList<CampusVestibDto>> BuscarDetalhesCampus(long? codCampusSiaf);

    Task<IList<InstituicaoAssociadaVestibDto>> BuscarInstituicoesAssociadasAsync(string? codigoVestibInstituicaoAnima);

    Task<bool> VerificarReprovacaoCandidato(string codigoConcurso, string codigoCandidato);

    Task<bool> VerificarInscricaoCancelada(string codigoConcurso, string codigoInscricao);

}