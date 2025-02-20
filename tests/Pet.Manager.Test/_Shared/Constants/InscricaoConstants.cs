using Anima.Inscricao.Domain.Acessibilidades.Entities;
using Anima.Inscricao.Domain.CursosExternos.Entities;
using Anima.Inscricao.Domain.Deficiencias.Entities;
using Anima.Inscricao.Domain.Enderecos.Entities;
using Anima.Inscricao.Domain.Escolas.Entities;
using Anima.Inscricao.Domain.Fichas.Entities;
using Anima.Inscricao.Domain.FormasEntrada.Entities;
using Anima.Inscricao.Domain.Inscricoes.Entities;
using Anima.Inscricao.Domain.Inscricoes.Enums;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Domain.Marcas.Entities;
using Anima.Inscricao.Domain.OfertaConcursos.Entities;
using Anima.Inscricao.Domain.Ofertas.Entities;

namespace Anima.Inscricao.Test._Shared.Constants;

public static class InscricaoConstants
{
    public static readonly InscricaoCandidato InscricaoCorreta = CriarInscricaoCorreta();

    public static readonly InscricaoCandidato SegundaInscricaoCorreta = CriarSegundaInscricaoCorreta();

    public static readonly InscricaoCandidato InscricaoIncompleta = CriarInscricaoIncompleta();

    public static readonly InscricaoCandidato InscricaoVazia = InscricaoCandidato
        .Criar(new FichaId(0), new MarcaId(0))
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a InscricaoVazia");

    public static readonly InscricaoCandidato InscricaoComIntegracao = CriarInscricaoComIntegracao();

    public static readonly InscricaoCandidato InscricaoCorretaComEtapa = CriarInscricaoCorretaComEtapa();

    private static InscricaoCandidato CriarInscricaoCorreta()
    {
        var inscricao = InscricaoCandidato.Criar(new FichaId(1), new MarcaId(1))
            .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a InscricaoCorreta");

        inscricao.DefinirInformacaoCandidato("Nome", new DateTime(2000, 10, 08), 1, false, null);
        inscricao.DefinirOrigem(TipoOrigemInscricao.Ficha, "www.anima.com.br/teste");
        inscricao.DefinirContatos(TipoContatoInscricao.Email, "teste@email.com");
        inscricao.DefinirContatos(TipoContatoInscricao.TelefoneCelular, "11912345678");
        inscricao.DefinirEndereco(TipoEnderecoInscricao.Residencial, "12345678", "Rua Teste", "123", null, "Bairro Teste", "São Paulo", "SP");
        inscricao.DefinirDocumentos(TipoDocumentoInscricao.Cpf, "662.045.180-20");
        inscricao.DefinirEscolaridade(TipoEscolaridadeInscricao.EnsinoSuperior, 2020, new EstadoId(1), new CidadeId(1), new EscolaId(1), null, new CursoExternoId(1), false);
        inscricao.DefinirAcessibilidade(new AcessibilidadeId(1));
        inscricao.DefinirDeficiencia(new DeficienciaId(1));
        inscricao.DefinirOferta(new OfertaId(1), new OfertaConcursoId(1));
        inscricao.DefinirFormaEntrada(TipoSelecaoFormaEntrada.Manual, new FormaEntradaId(1));
        inscricao.DefinirStatus(TipoStatusInscricao.TotalmenteConcluida);

        return inscricao;
    }

    private static InscricaoCandidato CriarSegundaInscricaoCorreta()
    {
        var inscricao = InscricaoCandidato.Criar(new FichaId(1), new MarcaId(1))
            .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a InscricaoCorreta");

        inscricao.DefinirInformacaoCandidato("Nome Segunda", new DateTime(2000, 10, 08), 1, false, null);
        inscricao.DefinirOrigem(TipoOrigemInscricao.Ficha, "www.anima.com.br/teste");
        inscricao.DefinirContatos(TipoContatoInscricao.Email, "teste@email.com");
        inscricao.DefinirContatos(TipoContatoInscricao.TelefoneCelular, "11912345678");
        inscricao.DefinirEndereco(TipoEnderecoInscricao.Residencial, "12345678", "Rua Teste", "123", null, "Bairro Teste", "São Paulo", "SP");
        inscricao.DefinirDocumentos(TipoDocumentoInscricao.Cpf, "662.045.180-21");
        inscricao.DefinirStatus(TipoStatusInscricao.ParcialmenteConcluida);
        inscricao.DefinirOferta(1, 3);
        inscricao.DefinirFormaEntrada(TipoSelecaoFormaEntrada.Manual, new FormaEntradaId(1));

        return inscricao;
    }

    private static InscricaoCandidato CriarInscricaoIncompleta()
    {
        var inscricao = InscricaoCandidato.Criar(new FichaId(1), new MarcaId(1))
            .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a InscricaoIncompleta");

        inscricao.DefinirInformacaoCandidato(string.Empty, null, 1, false, null);
        inscricao.DefinirOrigem(TipoOrigemInscricao.Ficha, "www.anima.com.br/teste");

        return inscricao;
    }

    private static InscricaoCandidato CriarInscricaoComIntegracao()
    {
        var inscricao = InscricaoCandidato.Criar(new FichaId(1), new MarcaId(1))
            .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a InscricaoComIntegracao");

        inscricao.DefinirInformacaoCandidato("Nome", new DateTime(2000, 10, 08), 1, false, null);
        inscricao.DefinirOrigem(TipoOrigemInscricao.Ficha, "www.anima.com.br/teste");
        inscricao.DefinirContatos(TipoContatoInscricao.Email, "teste@email.com");
        inscricao.DefinirContatos(TipoContatoInscricao.TelefoneCelular, "11912345678");
        inscricao.DefinirEndereco(TipoEnderecoInscricao.Residencial, "12345678", "Rua Teste", "123", null, "Bairro Teste", "São Paulo", "SP");
        inscricao.DefinirDocumentos(TipoDocumentoInscricao.Cpf, "662.045.180-20");
        inscricao.DefinirStatus(TipoStatusInscricao.TotalmenteConcluida);
        inscricao.AdicionarIntegracao(new IntegracaoSistemaId(1), "12345");

        return inscricao;
    }

    private static InscricaoCandidato CriarInscricaoCorretaComEtapa()
    {
        var inscricao = InscricaoCandidato.Criar(new FichaId(1), new MarcaId(1))
            .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a InscricaoCorreta");

        inscricao.DefinirInformacaoCandidato("Nome", new DateTime(2000, 10, 08), 1, false, null);
        inscricao.DefinirOrigem(TipoOrigemInscricao.Ficha, "www.anima.com.br/teste");
        inscricao.DefinirContatos(TipoContatoInscricao.Email, "teste@email.com");
        inscricao.DefinirContatos(TipoContatoInscricao.TelefoneCelular, "11912345678");
        inscricao.DefinirEndereco(TipoEnderecoInscricao.Residencial, "12345678", "Rua Teste", "123", null, "Bairro Teste", "São Paulo", "SP");
        inscricao.DefinirDocumentos(TipoDocumentoInscricao.Cpf, "662.045.180-20");
        inscricao.DefinirEscolaridade(TipoEscolaridadeInscricao.EnsinoMedio, 2020, new EstadoId(1), new CidadeId(1), new EscolaId(1), null, null, false);
        inscricao.DefinirAcessibilidade(new AcessibilidadeId(1));
        inscricao.DefinirDeficiencia(new DeficienciaId(1));
        inscricao.DefinirEtapas(new EtapaFichaId(1));

        return inscricao;
    }

}
