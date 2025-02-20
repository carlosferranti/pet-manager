using Anima.Inscricao.Domain.Cursos.Entities;
using Anima.Inscricao.Domain.Instituicoes.Entities;
using Anima.Inscricao.Domain.Modalidades.Entities;
using Anima.Inscricao.Domain.NiveisCurso.Entities;
using Anima.Inscricao.Domain.TiposFormacao.Entities;

namespace Anima.Inscricao.Test._Shared.Constants;

public static class CursoConstants
{
    public static readonly Curso CursoAdministracao =
        Curso.Criar("Administração", null, new ModalidadeId(1), new TipoFormacaoId(1), new NivelCursoId(1), new InstituicaoId(1))
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o curso Administração");

    public static readonly Curso CursoDireito =
        Curso.Criar("Direito", "Direito com Enfase em Trabalho", new ModalidadeId(1), new TipoFormacaoId(1), new NivelCursoId(1), new InstituicaoId(1))
          .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o curso Direito");
    
    public static readonly Curso CursoArquiteturaSoftware =
          Curso.Criar("Arquitetura de software", "Arquitetura de software com .Net", new ModalidadeId(2), new TipoFormacaoId(2), new NivelCursoId(1), new InstituicaoId(3))
            .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o curso Arquitetura de software");
}
