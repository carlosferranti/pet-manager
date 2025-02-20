using Anima.Inscricao.Infra.Data.Postgress.Context;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test._Shared.Tests;

public class DatabaseFixture
{
    public ServiceProvider ServiceProvider { get; private set; }

    public DatabaseFixture()
    {
        var serviceCollection = new ServiceCollection();

        ServiceProvider = new ServiceExtensions()
            .BuildServiceProvider(serviceCollection);

        InserirRegistros();
    }

    private void InserirRegistros()
    {
        var context = ServiceProvider.GetRequiredService<ServicoDbContext>();

        #region SistemasIntegracao
        context.Add(IntegracaoSistemaConstants.IntegracaoSistemaPortfolio);
        context.Add(IntegracaoSistemaConstants.IntegracaoSistemaVestib);
        #endregion

        #region Modalidades 
        context.Add(ModalidadeConstants.ModalidadePresencial);
        context.Add(ModalidadeConstants.ModalidadeSemiPresencial);
        context.Add(ModalidadeConstants.ModalidadeLive);
        #endregion

        #region Campi
        context.Add(CampusConstants.CampusRecife);
        context.Add(CampusConstants.CampusOlinda);
        context.Add(CampusConstants.CampusMooca);
        #endregion

        #region Turnos
        context.Add(TurnoConstants.TurnoManha);
        context.Add(TurnoConstants.TurnoTarde);
        context.Add(TurnoConstants.TurnoIntegral);
        #endregion

        #region Tipos de formacao 
        context.Add(TipoFormacaoConstants.TipoFormacaoGraduacao);
        context.Add(TipoFormacaoConstants.TipoFormacaoPos);
        context.Add(TipoFormacaoConstants.TipoFormacaoGraduacaoMedicina);
        #endregion

        #region Instituicao
        context.Add(InstituicaoConstants.Una);
        context.Add(InstituicaoConstants.UnaLive);
        context.Add(InstituicaoConstants.Unibh);
        #endregion

        #region Cursos 
        context.Add(CursoConstants.CursoAdministracao);
        context.Add(CursoConstants.CursoDireito);
        context.Add(CursoConstants.CursoArquiteturaSoftware);
        #endregion

        #region Intakes
        context.Add(IntakeConstants.IntakePrimeiroSemestre);
        context.Add(IntakeConstants.IntakeSegundoSemestre);
        #endregion

        #region Formas de Entrada 
        context.Add(FormaEntradaConstants.FormaEntradaVestibular);
        context.Add(FormaEntradaConstants.FormaEntradaEnem);
        context.Add(FormaEntradaConstants.FormaEntradaTransferencia);
        context.Add(FormaEntradaConstants.FormaEntradaDestrancamentoRetorno);
        context.Add(FormaEntradaConstants.FormaEntradaReopcao);
        context.Add(FormaEntradaConstants.FormaEntradaSegundaGraduacao);
        context.Add(FormaEntradaConstants.FormaEntradaVestibularEscola);
        context.Add(FormaEntradaConstants.FormaEntradaVestibularCorporativo);
        #endregion

        #region Concursos 
        context.Add(ConcursoConstants.ConcursoVestibular);
        context.Add(ConcursoConstants.ConcursoEnem);
        context.Add(ConcursoConstants.ConcursoTransferencia);
        context.Add(ConcursoConstants.ConcursoRetornarDestrancar);
        context.Add(ConcursoConstants.ConcursoReopcao);
        context.Add(ConcursoConstants.ConcursoSegundaGraduacao);
        #endregion

        #region Produtos 
        context.Add(ProdutoConstants.ProdutoTeste1);
        context.Add(ProdutoConstants.ProdutoTeste2);
        #endregion

        #region Etapas
        context.Add(EtapaConstants.EtapaDadosPessoais);
        context.Add(EtapaConstants.EtapaDadosContato);
        context.Add(EtapaConstants.EtapaEndereco);
        #endregion

        #region Fichas
        context.Add(FichaConstants.FichaPadrao);
        context.Add(FichaConstants.FichaB);
        context.Add(FichaConstants.FichaVazia);
        #endregion

        #region Ofertas 
        context.Add(OfertaConstants.OfertaTeste1);
        context.Add(OfertaConstants.OfertaTeste2);
        #endregion

        #region Configuracoes
        context.Add(ConfiguracaoConstants.ConfiguracaoPadrao);
        context.Add(ConfiguracaoConstants.ConfiguracaoPadrao2);
        context.Add(ConfiguracaoConstants.ConfiguracaoPadrao3);
        #endregion

        #region Ofertas 
        context.Add(OfertaConstants.OfertaTeste1);
        context.Add(OfertaConstants.OfertaTeste2);
        #endregion

        #region OfertaConcursos 
        context.Add(OfertaConcursoConstants.OfertaConcursoTeste1);
        context.Add(OfertaConcursoConstants.OfertaConcursoOpcaoAcessoProuni);
        context.Add(OfertaConcursoConstants.Oferta2ConcursoVestibular);
        context.Add(OfertaConcursoConstants.Oferta2ConcursoEnem);
        context.Add(OfertaConcursoConstants.Oferta2ConcursoTransferencia);
        context.Add(OfertaConcursoConstants.Oferta2ConcursoRetornarDestrancar);
        context.Add(OfertaConcursoConstants.Oferta2ConcursoReopcao);
        context.Add(OfertaConcursoConstants.Oferta2ConcursoSegundaGraduacao);
        #endregion

        #region NivelCurso
        context.Add(NivelCursoConstants.Bacharelado);
        context.Add(NivelCursoConstants.Licenciatura);
        context.Add(NivelCursoConstants.Tecnico);
        #endregion

        #region Enderecos 
        context.Add(EnderecoConstants.PaisBrasil);
        context.Add(EnderecoConstants.PaisArgentina);
        context.Add(EnderecoConstants.EstadoSP);
        context.Add(EnderecoConstants.EstadoRJ);
        context.Add(EnderecoConstants.CidadeSaoPaulo);
        context.Add(EnderecoConstants.CidadeCampinas);
        context.Add(EnderecoConstants.EstadoRS);
        #endregion

        #region Marcas
        context.Add(MarcaConstants.Una);
        context.Add(MarcaConstants.UnaLive);
        context.Add(MarcaConstants.Unibh);
        #endregion

        #region Escolas
        context.Add(EscolaConstants.IFSP);
        context.Add(EscolaConstants.ColegioVitoria);
        context.Add(EscolaConstants.ColegioRecife);
        #endregion

        #region Cupons
        context.Add(CupomConstants.PreencheCupomPablo100());
        context.Add(CupomConstants.CupomPablo50);
        context.Add(CupomConstants.CupomPablo25);
        context.Add(CupomConstants.CupomPablo10Expirado);
        #endregion

        #region Acessibilidade
        context.Add(AcessibilidadeConstants.ProvaBraile);
        context.Add(AcessibilidadeConstants.InterpreterDeLibras);
        #endregion

        #region Campos
        context.Add(CampoConstants.CPF);
        context.Add(CampoConstants.Nome);
        context.Add(CampoConstants.Email);
        context.Add(CampoConstants.Acessibilidade);
        context.Add(CampoConstants.ComprovanteAcessibilidade);
        context.Add(CampoConstants.TelefoneCelular);
        context.Add(CampoConstants.TelefoneFixo);
        context.Add(CampoConstants.TelefoneComercial);
        context.Add(CampoConstants.TelefoneContato);
        context.Add(CampoConstants.Deficiencia);
        context.Add(CampoConstants.ComprovanteDeficiencia);
        context.Add(CampoConstants.CertificadoEnsinoMedio);
        context.Add(CampoConstants.ComprovanteResidencia);
        context.Add(CampoConstants.ComprovanteRenda);
        context.Add(CampoConstants.RG);
        context.Add(CampoConstants.CNH);
        context.Add(CampoConstants.EnderecoResidencialRua);
        context.Add(CampoConstants.EnderecoResidencialNumero);
        context.Add(CampoConstants.EnderecoResidencialCep);
        context.Add(CampoConstants.EnderecoResidencialComplemento);
        context.Add(CampoConstants.EnderecoResidencialBairro);
        context.Add(CampoConstants.EnderecoResidencialCidade);
        context.Add(CampoConstants.EnderecoResidencialEstado);
        context.Add(CampoConstants.EnderecoCobrancaRua);
        context.Add(CampoConstants.EnderecoCobrancaNumero);
        context.Add(CampoConstants.EnderecoCobrancaCep);
        context.Add(CampoConstants.EnderecoCobrancaComplemento);
        context.Add(CampoConstants.EnderecoCobrancaBairro);
        context.Add(CampoConstants.EnderecoCobrancaCidade);
        context.Add(CampoConstants.EnderecoCobrancaEstado);
        context.Add(CampoConstants.EnderecoComercialRua);
        context.Add(CampoConstants.EnderecoComercialNumero);
        context.Add(CampoConstants.EnderecoComercialCep);
        context.Add(CampoConstants.EnderecoComercialComplemento);
        context.Add(CampoConstants.EnderecoComercialBairro);
        context.Add(CampoConstants.EnderecoComercialCidade);
        context.Add(CampoConstants.EnderecoComercialEstado);
        context.Add(CampoConstants.AnoConclusaoEM);
        context.Add(CampoConstants.EstadoEscolaEM);
        context.Add(CampoConstants.CidadeEscolaEM);
        context.Add(CampoConstants.EscolaEM);
        context.Add(CampoConstants.DataNascimento);
        context.Add(CampoConstants.Sexo);
        context.Add(CampoConstants.NecessidadeEspecial);
        context.Add(CampoConstants.NomeSocial);
        context.Add(CampoConstants.Cupom);
        context.Add(CampoConstants.Oferta);
        context.Add(CampoConstants.OfertaConcurso);
        context.Add(CampoConstants.Origem);
        context.Add(CampoConstants.Marca);
        context.Add(CampoConstants.Ficha);
        context.Add(CampoConstants.NomeFiador);
        context.Add(CampoConstants.RelacionamentoFiador);
        context.Add(CampoConstants.PercentualFiador);
        context.Add(CampoConstants.RendaMediaMensalFiador);
        context.Add(CampoConstants.DocumentoFiador);
        context.Add(CampoConstants.ContatoFiador);
        context.Add(CampoConstants.FormaEntrada);
        #endregion

        #region Deficiencias
        context.Add(DeficienciaConstants.DeficienciaFisica);
        context.Add(DeficienciaConstants.Cegueira);
        context.Add(DeficienciaConstants.Surdez);
        #endregion

        #region Inscricoes
        context.Add(InscricaoConstants.InscricaoCorreta);
        context.Add(InscricaoConstants.SegundaInscricaoCorreta);
        context.Add(InscricaoConstants.InscricaoComIntegracao);
        context.Add(InscricaoConstants.InscricaoIncompleta);
        context.Add(InscricaoDocumentacaoConstants.DocumentacaoLaudoNecessidadesEspeciais);
        context.Add(InscricaoDocumentacaoConstants.DocumentacaoHistoricoEscolarS3);
        context.Add(InscricaoDocumentacaoConstants.DocumentacaoHistoricoEscolarSmartShare);
        #endregion

        #region Acessibilidade
        context.Add(AcessibilidadeConstants.ProvaBraile);
        context.Add(AcessibilidadeConstants.InterpreterDeLibras);
        context.Add(AcessibilidadeConstants.Ledor);
        context.Add(AcessibilidadeConstants.Transcritor);
        #endregion

        #region Empresas
        context.Add(EmpresaConstants.Anima);
        context.Add(EmpresaConstants.Compass);
        context.Add(EmpresaConstants.Oracle);
        #endregion

        #region CursosExternos
        context.Add(CursoExternoConstants.Radialismo);
        context.Add(CursoExternoConstants.AbiArtesVisuais);
        context.Add(CursoExternoConstants.LetrasChines);
        #endregion

        #region Matriculas
        context.Add(MatriculaConstants.MatriculaTrancada);
        #endregion

        #region Modalidade Avaliacao
        context.Add(ModalidadeAvaliacaoConstants.Online);
        context.Add(ModalidadeAvaliacaoConstants.Presencial);
        #endregion

        #region Links
        context.Add(LinkConstants.LinkPadrao);
        context.Add(LinkConstants.LinkEscola);
        context.Add(LinkConstants.LinkEmpresa);
        #endregion

        context.SaveChanges();
    }
}