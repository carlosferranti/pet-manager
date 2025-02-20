using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Cursos;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.NiveisCurso;
using Anima.Inscricao.Domain.TiposFormacao;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Cursos.ObterCurso;

public class ObterCursoQueryHandler : IQueryHandler<ObterCursoQuery, CursoDto>
{
    private readonly ICursoRepository _cursoRepository;
    private readonly IModalidadeRepository _modalidadeRepository;
    private readonly ITipoFormacaoRepository _tipoFormacaoRepository;
    private readonly INivelCursoRepository _nivelCursoRepository;
    private readonly IInstituicaoRepository _instituicaoRepository;

    public ObterCursoQueryHandler(
        ICursoRepository cursoRepository,
        IModalidadeRepository modalidadeRepository,
        ITipoFormacaoRepository tipoFormacaoRepository,
        INivelCursoRepository nivelCursoRepository,
        IInstituicaoRepository instituicaoRepository)
    {
        _cursoRepository = cursoRepository;
        _modalidadeRepository = modalidadeRepository;
        _tipoFormacaoRepository = tipoFormacaoRepository;
        _nivelCursoRepository = nivelCursoRepository;
        _instituicaoRepository = instituicaoRepository;
    }

    public async Task<CursoDto> Handle(ObterCursoQuery request, CancellationToken cancellationToken)
    {
        var query = from curso in _cursoRepository.GetQueryable()
                    join modalidade in _modalidadeRepository.GetQueryable()
                        on curso.ModalidadeId equals modalidade.Id
                    join tipoFormacao in _tipoFormacaoRepository.GetQueryable()
                        on curso.TipoFormacaoId equals tipoFormacao.Id
                    join nivelCurso in _nivelCursoRepository.GetQueryable()
                        on curso.NivelCursoId equals nivelCurso.Id
                    join instituicao in _instituicaoRepository.GetQueryable()
                        on curso.InstituicaoId equals instituicao.Id
                    where curso.Key == request.Key
                    select new CursoDto
                    {
                        Key = curso.Key,
                        Nome = curso.Nome,
                        NomeComercial = curso.NomeComercial,
                        ModalidadeKey = modalidade.Key,
                        TipoFormacaoKey = tipoFormacao.Key,
                        NivelFormacaoKey = nivelCurso.Key,
                        InstituicaoKey = instituicao.Key,
                    };

        return await query.SingleAsync();
    }
}
