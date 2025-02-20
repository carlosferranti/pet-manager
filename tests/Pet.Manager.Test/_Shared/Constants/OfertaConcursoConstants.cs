using Anima.Inscricao.Domain.Concursos.Entities;
using Anima.Inscricao.Domain.OfertaConcursos.Entities;
using Anima.Inscricao.Domain.OfertaConcursos.Enums;
using Anima.Inscricao.Domain.Ofertas.Entities;

namespace Anima.Inscricao.Test._Shared.Constants;

public static class OfertaConcursoConstants
{
    public static readonly OfertaConcurso OfertaConcursoTeste1 =
       OfertaConcurso.Criar(new ConcursoId(1), new OfertaId(1))
       .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a ofertaConcurso Teste1");

    public static readonly OfertaConcurso Oferta2ConcursoVestibular =
      OfertaConcurso.Criar(new ConcursoId(1), new OfertaId(2))
      .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a Oferta2ConcursoVestibular");
    
    public static readonly OfertaConcurso Oferta2ConcursoEnem =
        OfertaConcurso.Criar(new ConcursoId(2), new OfertaId(2))
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a Oferta2ConcursoEnem");

    public static readonly OfertaConcurso Oferta2ConcursoTransferencia =
        OfertaConcurso.Criar(new ConcursoId(3), new OfertaId(2))
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a Oferta2ConcursoTransferencia");

    public static readonly OfertaConcurso Oferta2ConcursoRetornarDestrancar =
        OfertaConcurso.Criar(new ConcursoId(4), new OfertaId(2))
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a Oferta2ConcursoRetornarDestrancar");
    
    public static readonly OfertaConcurso Oferta2ConcursoReopcao =
        OfertaConcurso.Criar(new ConcursoId(5), new OfertaId(2))
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a Oferta2ConcursoReopcao");

    public static readonly OfertaConcurso Oferta2ConcursoSegundaGraduacao =
        OfertaConcurso.Criar(new ConcursoId(6), new OfertaId(2))
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a Oferta2ConcursoSegundaGraduacao");

    public static readonly OfertaConcursoOpcaoAcesso OfertaConcursoOpcaoAcessoProuni =
      new OfertaConcursoOpcaoAcesso(new OfertaConcursoId(1), TipoOpcaoAcesso.Prouni);
}
