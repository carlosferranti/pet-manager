using Anima.Inscricao.Domain._Shared.ValueObjects;
using Anima.Inscricao.Domain.Concursos.Entities;
using Anima.Inscricao.Domain.FormasEntrada.Entities;
using Anima.Inscricao.Domain.Modalidades.Entities;
using Anima.Inscricao.Domain.ModalidadesAvaliacao.Entities;
using Anima.Inscricao.Domain.TiposFormacao.Entities;

namespace Anima.Inscricao.Test._Shared.Constants;

public static class ConcursoConstants
{
    public static readonly Concurso ConcursoVestibular = CriarConcursoVestibular();

    public static readonly Concurso ConcursoEnem = CriarConcursoEnem();

    public static readonly Concurso ConcursoTransferencia = CriarConcursoTransferencia();

    public static readonly Concurso ConcursoRetornarDestrancar = CriarConcursoRetornoDestrancamento();

    public static readonly Concurso ConcursoReopcao = CriarConcursoReopcao();

    public static readonly Concurso ConcursoSegundaGraduacao = CriarConcursoSegundaGraduacao();

    public static readonly Concurso ConcursoVestibularSimplificado = CriarConcursoVestibularSimplificado();

    public static Concurso CriarConcursoVestibular()
    {
        var concurso = Concurso.Criar("Concurso Vestibular", "2024/1", new Vigencia(DateTime.Now, DateTime.Now.AddDays(10)), DateTime.Now, DateTime.Now, null, new ModalidadeAvaliacaoId(1))
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o Concurso Vestibular");

        concurso.AdicionarFormaEntrada(new FormaEntradaId(1));
        concurso.AdicionarModalidade(new ModalidadeId(1));
        concurso.AdicionarTipoFormacao(new TipoFormacaoId(1));
        concurso.AdicionarIntegracao(2, "1234");
        
        return concurso;
    }

    public static Concurso CriarConcursoEnem()
    {
        var concurso = Concurso.Criar("Concurso Enem", "2000/1", new Vigencia(DateTime.Now, DateTime.Now.AddDays(10)), null, null, null, null)
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o Concurso ENEM");

        concurso.AdicionarFormaEntrada(new FormaEntradaId(2));
        concurso.AdicionarModalidade(new ModalidadeId(1));
        concurso.AdicionarTipoFormacao(new TipoFormacaoId(1));
        concurso.AdicionarIntegracao(1, "123");

        return concurso;
    }

    public static Concurso CriarConcursoTransferencia()
    {
        var concurso = Concurso.Criar("Concurso Transferência", "2025/1", new Vigencia(DateTime.Now, DateTime.Now.AddDays(10)), null, null, null, null)
                        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o Concurso Transferência");

        concurso.AdicionarFormaEntrada(new FormaEntradaId(3));
        concurso.AdicionarModalidade(new ModalidadeId(1));
        concurso.AdicionarTipoFormacao(new TipoFormacaoId(1));
        concurso.AdicionarIntegracao(1, "123");

        return concurso;
    }

    public static Concurso CriarConcursoRetornoDestrancamento()
    {
        var concurso = Concurso.Criar("Concurso Retornar/Destrancar", "2025/1", new Vigencia(DateTime.Now, DateTime.Now.AddDays(10)), null, null, null, null)
                        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o Concurso Retornar/Destrancar");

        concurso.AdicionarFormaEntrada(new FormaEntradaId(4));
        concurso.AdicionarModalidade(new ModalidadeId(1));
        concurso.AdicionarTipoFormacao(new TipoFormacaoId(1));
        concurso.AdicionarIntegracao(1, "123");

        return concurso;
    }

    public static Concurso CriarConcursoReopcao()
    {
        var concurso = Concurso.Criar("Concurso Reopção", "2025/1", new Vigencia(DateTime.Now, DateTime.Now.AddDays(10)), null, null, null, null)
                        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o Concurso Reopção");

        concurso.AdicionarFormaEntrada(new FormaEntradaId(5));
        concurso.AdicionarModalidade(new ModalidadeId(1));
        concurso.AdicionarTipoFormacao(new TipoFormacaoId(1));
        concurso.AdicionarIntegracao(1, "123");

        return concurso;
    }

    public static Concurso CriarConcursoSegundaGraduacao()
    {
        var concurso = Concurso.Criar("Concurso Segunda graduação", "2025/1", new Vigencia(DateTime.Now, DateTime.Now.AddDays(10)), null, null, null, null)
                        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o Concurso Segunda graduação");

        concurso.AdicionarFormaEntrada(new FormaEntradaId(6));
        concurso.AdicionarModalidade(new ModalidadeId(1));
        concurso.AdicionarTipoFormacao(new TipoFormacaoId(1));
        concurso.AdicionarIntegracao(1, "123");

        return concurso;
    }

    public static Concurso CriarConcursoVestibularSimplificado()
    {
        var concurso = Concurso.Criar("Concurso Vestibular Simplificado", "2025/1", new Vigencia(DateTime.Now, DateTime.Now.AddDays(10)), null, null, null, null)
                        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o Concurso Vestibular Simplificado");

        concurso.AdicionarFormaEntrada(new FormaEntradaId(7));
        concurso.AdicionarModalidade(new ModalidadeId(1));
        concurso.AdicionarTipoFormacao(new TipoFormacaoId(1));
        concurso.AdicionarIntegracao(1, "123");

        return concurso;
    }
}
