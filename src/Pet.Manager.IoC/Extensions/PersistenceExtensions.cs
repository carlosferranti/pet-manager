using Anima.Inscricao.Application.Interfaces.Repositories;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain.Acessibilidades;
using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Campos;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Configuracoes;
using Anima.Inscricao.Domain.Cupons;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.CursosExternos;
using Anima.Inscricao.Domain.Deficiencias;
using Anima.Inscricao.Domain.Empresas;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Escolas;
using Anima.Inscricao.Domain.Etapas;
using Anima.Inscricao.Domain.Fichas;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Inscricoes;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Links;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Domain.Matriculas;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.ModalidadesAvaliacao;
using Anima.Inscricao.Domain.NiveisCurso;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Produtos;
using Anima.Inscricao.Domain.TiposFormacao;
using Anima.Inscricao.Domain.Turnos;
using Anima.Inscricao.Infra.Data._Shared.Postgres.UoW;
using Anima.Inscricao.Infra.Data.Oracle.Connections;
using Anima.Inscricao.Infra.Data.Oracle.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;
using Anima.Inscricao.Infra.Data.Postgress.Repositories;
using Anima.Inscricoes.Domain.Inscricoes;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.IoC.Extensions;

internal static class PersistenceExtensions
{
    internal static IServiceCollection AdicionarContextoServicoInscricaoDb(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ServicoDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("ServicoInscricao"));
            options.ConfigureWarnings(x => x.Ignore(RelationalEventId.AmbientTransactionWarning));
        });

        return services;
    }

    internal static IServiceCollection AdicionarContextoSiafDb(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<SiafConnection>();

        return services;
    }

    internal static IServiceCollection AdicionarUnitOfWork(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }

    internal static IServiceCollection AdicionarRepositorios(this IServiceCollection services)
    {
        #region Sistemas Integracao
        services.AddScoped<IIntegracaoSistemaRepository, IntegracaoSistemaRepository>();
        #endregion

        #region Modalidades
        services.AddScoped<IModalidadeRepository, ModalidadeRepository>();
        #endregion

        #region Campi
        services.AddScoped<ICampusRepository, CampusRepository>();
        #endregion

        #region Turnos
        services.AddScoped<ITurnoRepository, TurnoRepository>();
        #endregion

        #region Tipos de Formacao
        services.AddScoped<ITipoFormacaoRepository, TipoFormacaoRepository>();
        #endregion

        #region Cursos
        services.AddScoped<ICursoRepository, CursoRepository>();
        #endregion

        #region Instituicoes
        services.AddScoped<IInstituicaoRepository, InstituicaoRepository>();
        #endregion

        #region LinkInstituicoes
        services.AddScoped<IInstituicaoLinkRepository, InstituicaoLinkRepository>();
        #endregion

        #region Intakes
        services.AddScoped<IIntakeRepository, IntakeRepository>();
        #endregion

        #region Formas de Entrada
        services.AddScoped<IFormaEntradaRepository, FormaEntradaRepository>();
        #endregion

        #region Concursos
        services.AddScoped<IConcursoRepository, ConcursoRepository>();
        #endregion

        #region Produtos
        services.AddScoped<IProdutoRepository, ProdutoRepository>();
        #endregion

        #region Ofertas
        services.AddScoped<IOfertaRepository, OfertaRepository>();
        #endregion

        #region Etapas
        services.AddScoped<IEtapaTemplateRepository, EtapaTemplateRepository>();
        #endregion

        #region OfertaConcursos
        services.AddScoped<IOfertaConcursoRepository, OfertaConcursoRepository>();
        services.AddScoped<IOfertaConcursoOpcaoAcessoRepository, OfertaConcursoOpcaoAcessoRepository>();
        #endregion

        #region Fichas
        services.AddScoped<IFichaRepository, FichaRepository>();
        #endregion

        #region Inscricoes
        services.AddScoped<IInscricaoRepository, InscricaoRepository>();
        services.AddScoped<IInscricaoDocumentacaoRepository, InscricaoDocumentacaoRepository>();
        #endregion

        #region Configuracao
        services.AddScoped<IConfiguracaoRepository, ConfiguracaoRepository>();
        #endregion

        #region NivelCurso
        services.AddScoped<INivelCursoRepository, NivelCursoRepository>();
        #endregion

        #region Enderecos
        services.AddScoped<IPaisRepository, PaisRepository>();
        services.AddScoped<IEstadoRepository, EstadoRepository>();
        services.AddScoped<ICidadeRepository, CidadeRepository>();
        #endregion

        #region Marcas
        services.AddScoped<IMarcaRepository, MarcaRepository>();
        #endregion

        #region Escolas
        services.AddScoped<IEscolaRepository, EscolaRepository>();
        #endregion

        #region Cupons
        services.AddScoped<ICupomRepository, CupomRepository>();
        #endregion

        #region Acessibilidade
        services.AddScoped<IAcessibilidadeRepository, AcessibilidadeRepository>();
        #endregion

        #region Deficiencia
        services.AddScoped<IDeficienciaRepository, DeficienciaRepository>();
        #endregion

        #region Campos
        services.AddScoped<ICampoRepository, CampoRepository>();
        #endregion

        #region Empresas 
        services.AddScoped<IEmpresaRepository, EmpresaRepository>();
        #endregion

        #region CursoExterno
        services.AddScoped<ICursoExternoRepository, CursoExternoRepository>();
        #endregion

        #region Matriculas
        services.AddScoped<IMatriculaRepository, MatriculaRepository>();
        #endregion

        #region Modalidade Avaliacao
        services.AddScoped<IModalidadeAvaliacaoRepository, ModalidadeAvaliacaoRepository>();
        #endregion

        #region Links
        services.AddScoped<ILinkRepository, LinkRepository>();
        #endregion

        return services;
    }

    internal static IServiceCollection AdicionarRepositoriosExternos(this IServiceCollection services)
    {
        #region Candidato
        services.AddScoped<ICandidatoRepository, CandidatoRepository>();
        #endregion

        return services;
    }

}