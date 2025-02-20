using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application.DTOs.Acessibilidades;
using Anima.Inscricao.Application.DTOs.Campi;
using Anima.Inscricao.Application.DTOs.Campos;
using Anima.Inscricao.Application.DTOs.Candidatos;
using Anima.Inscricao.Application.DTOs.Cofiguracao;
using Anima.Inscricao.Application.DTOs.Concursos;
using Anima.Inscricao.Application.DTOs.Cupons;
using Anima.Inscricao.Application.DTOs.Cursos;
using Anima.Inscricao.Application.DTOs.CursosExternos;
using Anima.Inscricao.Application.DTOs.Deficiencias;
using Anima.Inscricao.Application.DTOs.Empresas;
using Anima.Inscricao.Application.DTOs.Enderecos;
using Anima.Inscricao.Application.DTOs.Escola;
using Anima.Inscricao.Application.DTOs.Etapas;
using Anima.Inscricao.Application.DTOs.Fichas;
using Anima.Inscricao.Application.DTOs.FormasEntrada;
using Anima.Inscricao.Application.DTOs.Inscricoes;
using Anima.Inscricao.Application.DTOs.Instituicao;
using Anima.Inscricao.Application.DTOs.Intakes;
using Anima.Inscricao.Application.DTOs.Links;
using Anima.Inscricao.Application.DTOs.Marcas;
using Anima.Inscricao.Application.DTOs.Modalidades;
using Anima.Inscricao.Application.DTOs.NiveisCurso;
using Anima.Inscricao.Application.DTOs.OfertaConcursos;
using Anima.Inscricao.Application.DTOs.Ofertas;
using Anima.Inscricao.Application.DTOs.Produtos;
using Anima.Inscricao.Application.DTOs.TiposFormacao;
using Anima.Inscricao.Application.DTOs.Turnos;
using Anima.Inscricao.Application.UseCases.Acessibilidades.AtualizarAcessibilidade;
using Anima.Inscricao.Application.UseCases.Acessibilidades.CriarAcessibilidade;
using Anima.Inscricao.Application.UseCases.Acessibilidades.ObterAcessibilidade;
using Anima.Inscricao.Application.UseCases.Acessibilidades.PesquisarAcessibilidade;
using Anima.Inscricao.Application.UseCases.Acessibilidades.RemoverAcessibilidade;
using Anima.Inscricao.Application.UseCases.Campi.AtualizarCampus;
using Anima.Inscricao.Application.UseCases.Campi.CriarCampus;
using Anima.Inscricao.Application.UseCases.Campi.ObterCampus;
using Anima.Inscricao.Application.UseCases.Campi.PesquisarCampus;
using Anima.Inscricao.Application.UseCases.Campi.RemoverCampus;
using Anima.Inscricao.Application.UseCases.Campos.AtualizarCampo;
using Anima.Inscricao.Application.UseCases.Campos.CriarCampo;
using Anima.Inscricao.Application.UseCases.Campos.ObterCampo;
using Anima.Inscricao.Application.UseCases.Campos.PesquisarCampo;
using Anima.Inscricao.Application.UseCases.Campos.RemoverCampo;
using Anima.Inscricao.Application.UseCases.Concursos.AtualizarConcurso;
using Anima.Inscricao.Application.UseCases.Concursos.CriarConcurso;
using Anima.Inscricao.Application.UseCases.Concursos.ObterConcurso;
using Anima.Inscricao.Application.UseCases.Concursos.PesquisarConcurso;
using Anima.Inscricao.Application.UseCases.Concursos.PesquisarConcursoPorOferta;
using Anima.Inscricao.Application.UseCases.Concursos.RemoverConcurso;
using Anima.Inscricao.Application.UseCases.Configuracoes.AtualizarConfiguracao;
using Anima.Inscricao.Application.UseCases.Configuracoes.CriarConfiguracao;
using Anima.Inscricao.Application.UseCases.Configuracoes.ObterConfiguracao;
using Anima.Inscricao.Application.UseCases.Configuracoes.PesquisarConfiguracao;
using Anima.Inscricao.Application.UseCases.Configuracoes.RemoverConfiguracao;
using Anima.Inscricao.Application.UseCases.Cupons.AtualizarCupom;
using Anima.Inscricao.Application.UseCases.Cupons.CriarCupom;
using Anima.Inscricao.Application.UseCases.Cupons.ObterCupom;
using Anima.Inscricao.Application.UseCases.Cupons.PesquisarCupom;
using Anima.Inscricao.Application.UseCases.Cupons.RemoverCupom;
using Anima.Inscricao.Application.UseCases.Cupons.ValidarCupom;
using Anima.Inscricao.Application.UseCases.Cursos.AtualizarCurso;
using Anima.Inscricao.Application.UseCases.Cursos.CriarCurso;
using Anima.Inscricao.Application.UseCases.Cursos.ObterCurso;
using Anima.Inscricao.Application.UseCases.Cursos.PesquisarCurso;
using Anima.Inscricao.Application.UseCases.Cursos.RemoverCurso;
using Anima.Inscricao.Application.UseCases.CursosExternos.ObterCursoExterno;
using Anima.Inscricao.Application.UseCases.Deficiencias.AtualizarDeficiencia;
using Anima.Inscricao.Application.UseCases.Deficiencias.CriarDeficiencia;
using Anima.Inscricao.Application.UseCases.Deficiencias.ObterDeficiencia;
using Anima.Inscricao.Application.UseCases.Deficiencias.PesquisarDeficiencia;
using Anima.Inscricao.Application.UseCases.Deficiencias.RemoverDeficiencia;
using Anima.Inscricao.Application.UseCases.Empresas.AtualizarEmpresa;
using Anima.Inscricao.Application.UseCases.Empresas.CriarEmpresa;
using Anima.Inscricao.Application.UseCases.Empresas.ObterEmpresa;
using Anima.Inscricao.Application.UseCases.Empresas.PesquisarEmpresa;
using Anima.Inscricao.Application.UseCases.Empresas.RemoverEmpresa;
using Anima.Inscricao.Application.UseCases.Enderecos.AtualizarCidade;
using Anima.Inscricao.Application.UseCases.Enderecos.AtualizarEstado;
using Anima.Inscricao.Application.UseCases.Enderecos.AtualizarPais;
using Anima.Inscricao.Application.UseCases.Enderecos.CriarCidade;
using Anima.Inscricao.Application.UseCases.Enderecos.CriarEstado;
using Anima.Inscricao.Application.UseCases.Enderecos.CriarPais;
using Anima.Inscricao.Application.UseCases.Enderecos.ObterCidade;
using Anima.Inscricao.Application.UseCases.Enderecos.ObterEstado;
using Anima.Inscricao.Application.UseCases.Enderecos.ObterPais;
using Anima.Inscricao.Application.UseCases.Enderecos.PesquisarCidade;
using Anima.Inscricao.Application.UseCases.Enderecos.PesquisarEstado;
using Anima.Inscricao.Application.UseCases.Enderecos.PesquisarPais;
using Anima.Inscricao.Application.UseCases.Enderecos.RemoverCidade;
using Anima.Inscricao.Application.UseCases.Enderecos.RemoverEstado;
using Anima.Inscricao.Application.UseCases.Enderecos.RemoverPais;
using Anima.Inscricao.Application.UseCases.Escolas.AtualizarEscola;
using Anima.Inscricao.Application.UseCases.Escolas.CriarEscola;
using Anima.Inscricao.Application.UseCases.Escolas.ObterEscola;
using Anima.Inscricao.Application.UseCases.Escolas.PesquisarEscola;
using Anima.Inscricao.Application.UseCases.Escolas.RemoverEscola;
using Anima.Inscricao.Application.UseCases.Etapas.AtualizarEtapaTemplate;
using Anima.Inscricao.Application.UseCases.Etapas.CriarEtapa;
using Anima.Inscricao.Application.UseCases.Etapas.ObterEtapaTemplate;
using Anima.Inscricao.Application.UseCases.Etapas.PesquisarEtapa;
using Anima.Inscricao.Application.UseCases.Etapas.RemoverEtapaTemplate;
using Anima.Inscricao.Application.UseCases.Fichas.AtualizarFicha;
using Anima.Inscricao.Application.UseCases.Fichas.CriarFicha;
using Anima.Inscricao.Application.UseCases.Fichas.ObterFicha;
using Anima.Inscricao.Application.UseCases.Fichas.PesquisarFicha;
using Anima.Inscricao.Application.UseCases.Fichas.RemoverFicha;
using Anima.Inscricao.Application.UseCases.FormasEntrada.AtualizarFormaEntrada;
using Anima.Inscricao.Application.UseCases.FormasEntrada.CriarFormaEntrada;
using Anima.Inscricao.Application.UseCases.FormasEntrada.ObterFormaEntrada;
using Anima.Inscricao.Application.UseCases.FormasEntrada.PesquisarFormaEntrada;
using Anima.Inscricao.Application.UseCases.FormasEntrada.RemoverFormaEntrada;
using Anima.Inscricao.Application.UseCases.Inscricoes.AtualizarInscricaoCandidato;
using Anima.Inscricao.Application.UseCases.Inscricoes.ConcluirInscricaoCandidato;
using Anima.Inscricao.Application.UseCases.Inscricoes.CriarDocumentacaoInscricaoCandidato;
using Anima.Inscricao.Application.UseCases.Inscricoes.CriarInscricaoCandidato;
using Anima.Inscricao.Application.UseCases.Inscricoes.CriarIntegracaoInscricaoCandidato;
using Anima.Inscricao.Application.UseCases.Inscricoes.ObterInscricaoCandidato;
using Anima.Inscricao.Application.UseCases.Inscricoes.PesquisarInscricaoAnteriorCandidato;
using Anima.Inscricao.Application.UseCases.Inscricoes.PesquisarInscricaoCandidatoMarca;
using Anima.Inscricao.Application.UseCases.Inscricoes.PesquisarInscricoesCandidatos;
using Anima.Inscricao.Application.UseCases.Inscricoes.PesquisarVinculoCandidato;
using Anima.Inscricao.Application.UseCases.Inscricoes.RemoverDocumentacaoInscricaoCandidato;
using Anima.Inscricao.Application.UseCases.Instituicoes.AtualizarInstituicao;
using Anima.Inscricao.Application.UseCases.Instituicoes.CriarInstituicao;
using Anima.Inscricao.Application.UseCases.Instituicoes.ObterInstituicao;
using Anima.Inscricao.Application.UseCases.Instituicoes.PesquisarInstituicao;
using Anima.Inscricao.Application.UseCases.Instituicoes.PesquisarLinkRedirecionamentoCandidato;
using Anima.Inscricao.Application.UseCases.Instituicoes.RemoverInstituicao;
using Anima.Inscricao.Application.UseCases.Intakes.AtualizarIntake;
using Anima.Inscricao.Application.UseCases.Intakes.CriarIntake;
using Anima.Inscricao.Application.UseCases.Intakes.ObterIntake;
using Anima.Inscricao.Application.UseCases.Intakes.PesquisarIntake;
using Anima.Inscricao.Application.UseCases.Intakes.RemoverIntake;
using Anima.Inscricao.Application.UseCases.Links.AtualizarLink;
using Anima.Inscricao.Application.UseCases.Links.CriarLink;
using Anima.Inscricao.Application.UseCases.Links.ObterLink;
using Anima.Inscricao.Application.UseCases.Links.PesquisarLink;
using Anima.Inscricao.Application.UseCases.Links.RemoverLink;
using Anima.Inscricao.Application.UseCases.Marcas.AtualizarMarca;
using Anima.Inscricao.Application.UseCases.Marcas.CriarMarca;
using Anima.Inscricao.Application.UseCases.Marcas.ObterMarca;
using Anima.Inscricao.Application.UseCases.Marcas.PesquisarMarca;
using Anima.Inscricao.Application.UseCases.Marcas.RemoverMarca;
using Anima.Inscricao.Application.UseCases.Modalidades.AtualizarModalidade;
using Anima.Inscricao.Application.UseCases.Modalidades.CriarModalidade;
using Anima.Inscricao.Application.UseCases.Modalidades.ObterModalidade;
using Anima.Inscricao.Application.UseCases.Modalidades.PesquisarModalidade;
using Anima.Inscricao.Application.UseCases.Modalidades.RemoverModalidade;
using Anima.Inscricao.Application.UseCases.NiveisCurso.AtualizarNivelCurso;
using Anima.Inscricao.Application.UseCases.NiveisCurso.CriarNivelCurso;
using Anima.Inscricao.Application.UseCases.NiveisCurso.ObterNivelCurso;
using Anima.Inscricao.Application.UseCases.NiveisCurso.PesquisarNivelCurso;
using Anima.Inscricao.Application.UseCases.NiveisCurso.RemoverNivelCurso;
using Anima.Inscricao.Application.UseCases.OfertaConcursos.AtualizarOfertaConcurso;
using Anima.Inscricao.Application.UseCases.OfertaConcursos.CriarOfertaConcurso;
using Anima.Inscricao.Application.UseCases.OfertaConcursos.ObterOfertaConcurso;
using Anima.Inscricao.Application.UseCases.OfertaConcursos.PesquisarCursoOfertadoDetalhe;
using Anima.Inscricao.Application.UseCases.OfertaConcursos.PesquisarCursosOfertados;
using Anima.Inscricao.Application.UseCases.OfertaConcursos.PesquisarOfertaConcurso;
using Anima.Inscricao.Application.UseCases.OfertaConcursos.RemoverOfertaConcurso;
using Anima.Inscricao.Application.UseCases.Ofertas.AtualizarOferta;
using Anima.Inscricao.Application.UseCases.Ofertas.CriarOferta;
using Anima.Inscricao.Application.UseCases.Ofertas.ObterOferta;
using Anima.Inscricao.Application.UseCases.Ofertas.PesquisarOferta;
using Anima.Inscricao.Application.UseCases.Ofertas.RemoverOferta;
using Anima.Inscricao.Application.UseCases.Produtos.AtualizarProduto;
using Anima.Inscricao.Application.UseCases.Produtos.CriarProduto;
using Anima.Inscricao.Application.UseCases.Produtos.ObterProduto;
using Anima.Inscricao.Application.UseCases.Produtos.PesquisarProduto;
using Anima.Inscricao.Application.UseCases.Produtos.RemoverProduto;
using Anima.Inscricao.Application.UseCases.TiposFormacao.AtualizarTipoFormacao;
using Anima.Inscricao.Application.UseCases.TiposFormacao.CriarTipoFormacao;
using Anima.Inscricao.Application.UseCases.TiposFormacao.ObterTipoFormacao;
using Anima.Inscricao.Application.UseCases.TiposFormacao.PesquisarTipoFormacao;
using Anima.Inscricao.Application.UseCases.TiposFormacao.RemoverTipoFormacao;
using Anima.Inscricao.Application.UseCases.Turnos.AtualizarTurno;
using Anima.Inscricao.Application.UseCases.Turnos.CriarTurno;
using Anima.Inscricao.Application.UseCases.Turnos.ObterTurno;
using Anima.Inscricao.Application.UseCases.Turnos.PesquisarTurno;
using Anima.Inscricao.Application.UseCases.Turnos.RemoverTurno;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Acessibilidades.Validators;
using Anima.Inscricao.Domain.Campi.Validators;
using Anima.Inscricao.Domain.Campos.Validators;
using Anima.Inscricao.Domain.Concursos.Validators;
using Anima.Inscricao.Domain.Configuracoes.Validators;
using Anima.Inscricao.Domain.Cupons.Validators;
using Anima.Inscricao.Domain.Cursos.Validators;
using Anima.Inscricao.Domain.CursosExternos.Validators;
using Anima.Inscricao.Domain.Deficiencias.Validators;
using Anima.Inscricao.Domain.Empresas.Validators;
using Anima.Inscricao.Domain.Enderecos.Validators;
using Anima.Inscricao.Domain.Escolas.Validators;
using Anima.Inscricao.Domain.Etapas.Validators;
using Anima.Inscricao.Domain.Fichas.Validators;
using Anima.Inscricao.Domain.FormasEntrada.Validators;
using Anima.Inscricao.Domain.Inscricoes.Validators;
using Anima.Inscricao.Domain.Instituicoes.Validators;
using Anima.Inscricao.Domain.Intakes.Validators;
using Anima.Inscricao.Domain.IntegracaoSistemas.Validators;
using Anima.Inscricao.Domain.Links.Validators;
using Anima.Inscricao.Domain.Marcas.Validators;
using Anima.Inscricao.Domain.Matriculas.Validators;
using Anima.Inscricao.Domain.Modalidades.Validators;
using Anima.Inscricao.Domain.ModalidadesAvaliacao.Validators;
using Anima.Inscricao.Domain.NiveisCurso.Validators;
using Anima.Inscricao.Domain.OfertaConcursos.Validators;
using Anima.Inscricao.Domain.Ofertas.Validators;
using Anima.Inscricao.Domain.Produtos.Validators;
using Anima.Inscricao.Domain.TiposFormacao.Validators;
using Anima.Inscricao.Domain.Turnos.Validators;

using MediatR;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.IoC.Extensions;

internal static class ValidationExtensions
{
    internal static IServiceCollection AdicionarDomainValidators(this IServiceCollection services)
    {
        #region Sistemas de integracao
        services.AddScoped<NovaIntegracaoSistemaDomainValidator>();
        #endregion

        #region Modalidades
        services.AddScoped<NovaModalidadeDomainValidator>();
        services.AddScoped<AtualizacaoModalidadeDomainValidator>();
        services.AddScoped<RemoverModalidadeDomainValidator>();
        #endregion

        #region Campi
        services.AddScoped<NovoCampusDomainValidator>();
        services.AddScoped<AtualizacaoCampusDomainValidator>();
        services.AddScoped<RemoverCampusDomainValidator>();
        #endregion

        #region Turnos
        services.AddScoped<NovoTurnoDomainValidator>();
        services.AddScoped<AtualizacaoTurnoDomainValidator>();
        services.AddScoped<RemoverTurnoDomainValidator>();
        #endregion

        #region Tipos de Formacao
        services.AddScoped<NovoTipoFormacaoDomainValidator>();
        services.AddScoped<AtualizacaoTipoFormacaoDomainValidator>();
        services.AddScoped<RemoverTipoFormacaoDomainValidator>();
        #endregion

        #region Cursos
        services.AddScoped<NovoCursoDomainValidator>();
        services.AddScoped<AtualizacaoCursoDomainValidator>();
        services.AddScoped<RemoverCursoDomainValidator>();
        #endregion

        #region Instituicao
        services.AddScoped<NovaInstituicaoDomainValidator>();
        services.AddScoped<AtualizacaoInstituicaoDomainValidator>();
        services.AddScoped<RemoverInstituicaoDomainValidator>();
        #endregion

        #region Intake
        services.AddScoped<NovoIntakeDomainValidator>();
        services.AddScoped<AtualizacaoIntakeDomainValidator>();
        services.AddScoped<RemoverIntakeDomainValidator>();
        #endregion

        #region Formas de Entrada
        services.AddScoped<NovaFormaEntradaDomainValidator>();
        services.AddScoped<AtualizacaoFormaEntradaDomainValidator>();
        services.AddScoped<RemoverFormaEntradaDomainValidator>();
        #endregion

        #region Concursos
        services.AddScoped<NovoConcursoDomainValidator>();
        services.AddScoped<AtualizacaoConcursoDomainValidator>();
        services.AddScoped<RemoverConcursoDomainValidator>();
        #endregion

        #region Produtos
        services.AddScoped<NovoProdutoDomainValidator>();
        services.AddScoped<AtualizarProdutoDomainValidator>();
        services.AddScoped<RemoverProdutoDomainValidator>();
        #endregion

        #region Ofertas
        services.AddScoped<NovaOfertaDomainValidator>();
        services.AddScoped<AtualizacaoOfertaDomainValidator>();
        services.AddScoped<RemoverOfertaDomainValidator>();
        #endregion

        #region Etapas
        services.AddScoped<NovaEtapaTemplateDomainValidator>();
        services.AddScoped<AtualizacaoEtapaTemplateDomainValidator>();
        services.AddScoped<RemoverEtapaTemplateDomainValidator>();
        #endregion

        #region Fichas
        services.AddScoped<NovaFichaDomainValidator>();
        services.AddScoped<AtualizacaoFichaDomainValidator>();
        services.AddScoped<RemoverFichaDomainValidator>();
        #endregion

        #region Configuracao
        services.AddScoped<NovaConfiguracaoDomainValidator>();
        services.AddScoped<AtualizacaoConfiguracaoDomainValidator>();
        services.AddScoped<RemoverConfiguracaoDomainValidator>();
        #endregion

        #region NivelCurso
        services.AddScoped<NovoNivelCursoDomainValidator>();
        services.AddScoped<AtualizarNivelCursoDomainValidator>();
        services.AddScoped<RemoverNivelCursoDomainValidator>();
        #endregion

        #region OfertaConcursos
        services.AddScoped<NovaOfertaConcursoDomainValidator>();
        services.AddScoped<AtualizacaoOfertaConcursoDomainValidator>();
        services.AddScoped<RemoverOfertaConcursoDomainValidator>();
        #endregion

        #region Enderecos
        services.AddScoped<NovoPaisDomainValidator>();
        services.AddScoped<AtualizacaoPaisDomainValidator>();
        services.AddScoped<RemoverPaisDomainValidator>();

        services.AddScoped<NovoEstadoDomainValidator>();
        services.AddScoped<AtualizacaoEstadoDomainValidator>();
        services.AddScoped<RemoverEstadoDomainValidator>();

        services.AddScoped<NovaCidadeDomainValidator>();
        services.AddScoped<AtualizacaoCidadeDomainValidator>();
        services.AddScoped<RemoverCidadeDomainValidator>();
        #endregion

        #region Marcas
        services.AddScoped<NovaMarcaDomainValidator>();
        services.AddScoped<AtualizacaoMarcaDomainValidator>();
        services.AddScoped<RemoverMarcaDomainValidator>();
        services.AddScoped<NovaIntegracaoMarcaDomainValidator>();
        #endregion

        #region Escolas
        services.AddScoped<NovaEscolaDomainValidator>();
        services.AddScoped<AtualizacaoEscolaDomainValidator>();
        services.AddScoped<RemoverEscolaDomainValidator>();
        #endregion

        #region Cupons
        services.AddScoped<RemoverCupomDomainValidator>();
        services.AddScoped<AtualizacaoCupomDomainValidator>();
        services.AddScoped<NovoCupomDomainValidator>();
        #endregion

        #region Acessibilidade
        services.AddScoped<NovaAcessibilidadeDomainValidator>();
        services.AddScoped<AtualizacaoAcessibilidadeDomainValidator>();
        services.AddScoped<RemoverAcessibilidadeDomainValidator>();
        #endregion

        #region Deficiencias
        services.AddScoped<NovaDeficienciaDomainValidator>();
        services.AddScoped<AtualizacaoDeficienciaDomainValidator>();
        services.AddScoped<RemoverDeficienciaDomainValidator>();
        #endregion

        #region Campos
        services.AddScoped<NovoCampoDomainValidator>();
        services.AddScoped<AtualizacaoCampoDomainValidator>();
        services.AddScoped<RemoverCampoDomainValidator>();
        #endregion

        #region Inscricoes
        services.AddScoped<NovaIntegracaoInscricaoCandidatoDomainValidator>();
        services.AddScoped<NovaDocumentacaoInscricaoDomainValidator>();
        #endregion

        #region Empresas
        services.AddScoped<NovaEmpresaDomainValidator>();
        services.AddScoped<AtualizacaoEmpresaDomainValidator>();
        services.AddScoped<RemoverEmpresaDomainValidator>();
        #endregion

        #region CursoExterno
        services.AddScoped<NovaIntegracaoCursoExternoDomainValidator>();
        services.AddScoped<NovoCursoExternoDomainValidator>();
        services.AddScoped<RemoverCursoExternoDomainValidator>();
        #endregion

        #region Matriculas 
        services.AddScoped<NovaMatriculaDomainValidator>();
        #endregion

        #region Modalidade Avaliacao
        services.AddScoped<NovaModalidadeAvaliacaoDomainValidator>();
        services.AddScoped<AtualizacaoModalidadeAvaliacaoDomainValidator>();
        services.AddScoped<RemoverModalidadeAvaliacaoDomainValidator>();
        #endregion

        #region Links
        services.AddScoped<NovoLinkDomainValidator>();
        services.AddScoped<AtualizacaoLinkDomainValidator>();
        services.AddScoped<RemoverLinkDomainValidator>();
        #endregion

        return services;
    }

    internal static IServiceCollection AdicionarApplicationValidators(this IServiceCollection services)
    {
        services.AddScoped<INotificationContext, NotificationContext>();

        #region Modalidades
        services.AddScoped<IPipelineBehavior<CriarModalidadeCommand, EntityKeyDto?>, CriarModalidadeCommandValidator>();
        services.AddScoped<IPipelineBehavior<AtualizarModalidadeCommand, Unit>, AtualizarModalidadeCommandValidator>();
        services.AddScoped<IPipelineBehavior<ObterModalidadeQuery, ModalidadeDto>, ObterModalidadeQueryValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarModalidadeQuery, ResultadoPaginadoDto<ModalidadeDto>>, PesquisarModalidadeQueryValidator>();
        services.AddScoped<IPipelineBehavior<RemoverModalidadeCommand, Unit>, RemoverModalidadeCommandValidator>();
        #endregion

        #region Tipos de Formacao
        services.AddScoped<IPipelineBehavior<CriarTipoFormacaoCommand, EntityKeyDto?>, CriarTipoFormacaoCommandValidator>();
        services.AddScoped<IPipelineBehavior<AtualizarTipoFormacaoCommand, Unit>, AtualizarTipoFormacaoCommandValidator>();
        services.AddScoped<IPipelineBehavior<ObterTipoFormacaoQuery, TipoFormacaoDto>, ObterTipoFormacaoQueryValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarTipoFormacaoQuery, ResultadoPaginadoDto<TipoFormacaoDto>>, PesquisarTipoFormacaoQueryValidator>();
        services.AddScoped<IPipelineBehavior<RemoverTipoFormacaoCommand, Unit>, RemoverTipoFormacaoCommandValidator>();
        #endregion

        #region Cursos
        services.AddScoped<IPipelineBehavior<CriarCursoCommand, EntityKeyDto?>, CriarCursoCommandValidator>();
        services.AddScoped<IPipelineBehavior<AtualizarCursoCommand, Unit>, AtualizarCursoCommandValidator>();
        services.AddScoped<IPipelineBehavior<ObterCursoQuery, CursoDto>, ObterCursoQueryValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarCursoQuery, ResultadoPaginadoDto<CursoDto>>, PesquisarCursoQueryValidator>();
        services.AddScoped<IPipelineBehavior<RemoverCursoCommand, Unit>, RemoverCursoCommandValidator>();
        #endregion

        #region Intakes
        services.AddScoped<IPipelineBehavior<CriarIntakeCommand, EntityKeyDto?>, CriarIntakeCommandValidator>();
        services.AddScoped<IPipelineBehavior<AtualizarIntakeCommand, Unit>, AtualizarIntakeCommandValidator>();
        services.AddScoped<IPipelineBehavior<ObterIntakeQuery, IntakeDto>, ObterIntakeQueryValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarIntakeQuery, ResultadoPaginadoDto<IntakeDto>>, PesquisarIntakeQueryValidator>();
        services.AddScoped<IPipelineBehavior<RemoverIntakeCommand, Unit>, RemoverIntakeCommandValidator>();
        #endregion

        #region Instituicao
        services.AddScoped<IPipelineBehavior<CriarInstituicaoCommand, EntityKeyDto?>, CriarInstituicaoCommandValidator>();
        services.AddScoped<IPipelineBehavior<AtualizarInstituicaoCommand, Unit>, AtualizarInstituicaoCommandValidator>();
        services.AddScoped<IPipelineBehavior<ObterInstituicaoQuery, InstituicaoDto>, ObterInstituicaoQueryValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarInstituicaoQuery, ResultadoPaginadoDto<InstituicaoDto>>, PesquisarInstituicaoQueryValidator>();
        services.AddScoped<IPipelineBehavior<RemoverInstituicaoCommand, Unit>, RemoverInstituicaoCommandValidator>();
        #endregion

        #region Campi
        services.AddScoped<IPipelineBehavior<CriarCampusCommand, EntityKeyDto?>, CriarCampusCommandValidator>();
        services.AddScoped<IPipelineBehavior<AtualizarCampusCommand, Unit>, AtualizarCampusCommandValidator>();
        services.AddScoped<IPipelineBehavior<RemoverCampusCommand, Unit>, RemoverCampusCommandValidator>();
        services.AddScoped<IPipelineBehavior<ObterCampusQuery, CampusDto>, ObterCampusQueryValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarCampusQuery, ResultadoPaginadoDto<CampusDto>>, PesquisarCampusQueryValidator>();
        #endregion

        #region Turnos
        services.AddScoped<IPipelineBehavior<CriarTurnoCommand, EntityKeyDto?>, CriarTurnoCommandValidator>();
        services.AddScoped<IPipelineBehavior<AtualizarTurnoCommand, Unit>, AtualizarTurnoCommandValidator>();
        services.AddScoped<IPipelineBehavior<RemoverTurnoCommand, Unit>, RemoverTurnoCommandValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarTurnoQuery, ResultadoPaginadoDto<TurnoDto>>, PesquisarTurnoQueryValidator>();
        services.AddScoped<IPipelineBehavior<ObterTurnoQuery, TurnoDto>, ObterTurnoQueryValidator>();
        #endregion

        #region Formas de Entrada
        services.AddScoped<IPipelineBehavior<CriarFormaEntradaCommand, EntityKeyDto?>, CriarFormaEntradaCommandValidator>();
        services.AddScoped<IPipelineBehavior<AtualizarFormaEntradaCommand, Unit>, AtualizarFormaEntradaCommandValidator>();
        services.AddScoped<IPipelineBehavior<ObterFormaEntradaQuery, FormaEntradaDto>, ObterFormaEntradaQueryValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarFormaEntradaQuery, ResultadoPaginadoDto<FormaEntradaDto>>, PesquisarFormaEntradaQueryValidator>();
        services.AddScoped<IPipelineBehavior<RemoverFormaEntradaCommand, Unit>, RemoverFormaEntradaCommandValidator>();
        #endregion

        #region Concursos
        services.AddScoped<IPipelineBehavior<CriarConcursoCommand, EntityKeyDto?>, CriarConcursoCommandValidator>();
        services.AddScoped<IPipelineBehavior<AtualizarConcursoCommand, Unit>, AtualizarConcursoCommandValidator>();
        services.AddScoped<IPipelineBehavior<ObterConcursoQuery, ConcursoDto>, ObterConcursoQueryValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarConcursoQuery, ResultadoPaginadoDto<ConcursoDto>>, PesquisarConcursoQueryValidator>();
        services.AddScoped<IPipelineBehavior<RemoverConcursoCommand, Unit>, RemoverConcursoCommandValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarConcursoPorOfertaQuery, List<ConcursosPorOfertaDto>>, PesquisarConcursoPorOfertaQueryValidator>();
        #endregion

        #region Produtos
        services.AddScoped<IPipelineBehavior<CriarProdutoCommand, EntityKeyDto?>, CriarProdutoCommandValidator>();
        services.AddScoped<IPipelineBehavior<AtualizarProdutoCommand, Unit>, AtualizarProdutoCommandValidator>();
        services.AddScoped<IPipelineBehavior<ObterProdutoQuery, ProdutoDto>, ObterProdutoQueryValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarProdutoQuery, ResultadoPaginadoDto<ProdutoDto>>, PesquisarProdutoQueryValidator>();
        services.AddScoped<IPipelineBehavior<RemoverProdutoCommand, Unit>, RemoverProdutoCommandValidator>();
        #endregion

        #region Ofertas
        services.AddScoped<IPipelineBehavior<CriarOfertaCommand, EntityKeyDto?>, CriarOfertaCommandValidator>();
        services.AddScoped<IPipelineBehavior<AtualizarOfertaCommand, Unit>, AtualizarOfertaCommandValidator>();
        services.AddScoped<IPipelineBehavior<ObterOfertaQuery, OfertaDto>, ObterOfertaQueryValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarOfertaQuery, ResultadoPaginadoDto<OfertaDto>>, PesquisarOfertaQueryValidator>();
        services.AddScoped<IPipelineBehavior<RemoverOfertaCommand, Unit>, RemoverOfertaCommandValidator>();
        #endregion

        #region Etapas
        services.AddScoped<IPipelineBehavior<CriarEtapaTemplateCommand, EntityKeyDto?>, CriarEtapaTemplateCommandValidator>();
        services.AddScoped<IPipelineBehavior<AtualizarEtapaTemplateCommand, Unit>, AtualizarEtapaTemplateCommandValidator>();
        services.AddScoped<IPipelineBehavior<ObterEtapaTemplateQuery, EtapaTemplateDto>, ObterEtapaTemplateQueryValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarEtapaTemplateQuery, ResultadoPaginadoDto<EtapaTemplateDto>>, PesquisarEtapaTemplateQueryValidator>();
        services.AddScoped<IPipelineBehavior<RemoverEtapaTemplateCommand, Unit>, RemoverEtapaTemplateCommandValidator>();
        #endregion

        #region Fichas
        services.AddScoped<IPipelineBehavior<CriarFichaCommand, EntityKeyDto?>, CriarFichaCommandValidator>();
        services.AddScoped<IPipelineBehavior<AtualizarFichaCommand, Unit>, AtualizarFichaCommandValidator>();
        services.AddScoped<IPipelineBehavior<ObterFichaQuery, FichaDto>, ObterFichaQueryValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarFichaQuery, ResultadoPaginadoDto<FichaDto>>, PesquisarFichaQueryValidator>();
        services.AddScoped<IPipelineBehavior<RemoverFichaCommand, Unit>, RemoverFichaCommandValidator>();
        #endregion

        #region Configuracao
        services.AddScoped<IPipelineBehavior<CriarConfiguracaoCommand, EntityKeyDto?>, CriarConfiguracaoCommandValidator>();
        services.AddScoped<IPipelineBehavior<AtualizarConfiguracaoCommand, Unit>, AtualizarConfiguracaoCommandValidator>();
        services.AddScoped<IPipelineBehavior<RemoverConfiguracaoCommand, Unit>, RemoverConfiguracaoCommandValidator>();
        services.AddScoped<IPipelineBehavior<ObterConfiguracaoQuery, ConfiguracaoDto>, ObterConfiguracaoQueryValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarConfiguracaoQuery, ResultadoPaginadoDto<ConfiguracaoDto>>, PesquisarConfiguracaoQueryValidator>();
        #endregion

        #region Inscricoes
        services.AddScoped<IPipelineBehavior<CriarInscricaoCandidatoCommand, EntityKeyDto?>, CriarInscricaoCandidatoCommandValidator>();
        services.AddScoped<IPipelineBehavior<AtualizarInscricaoCandidatoCommand, Unit>, AtualizarInscricaoCandidatoCommandValidator>();
        services.AddScoped<IPipelineBehavior<ConcluirInscricaoCandidatoCommand, Unit>, ConcluirInscricaoCandidatoCommandValidator>();
        services.AddScoped<IPipelineBehavior<CriarIntegracaoInscricaoCandidatoCommand, EntityKeyDto?>, CriarIntegracaoInscricaoCandidatoCommandValidator>();
        services.AddScoped<IPipelineBehavior<CriarDocumentacaoInscricaoCandidatoCommand, List<InscricaoDocumentacaoDto>?>, CriarDocumentacaoInscricaoCandidatoCommandValidator>();
        services.AddScoped<IPipelineBehavior<RemoverDocumentacaoInscricaoCandidatoCommand, Unit>, RemoverDocumentacaoInscricaoCandidatoCommandValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarInscricoesCandidatosQuery, ResultadoPaginadoDto<CandidatoDto>>, PesquisarInscricoesCandidatosQueryValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarVinculoCandidatoQuery, IEnumerable<CandidatoVinculoDto>>, PesquisarVinculoCandidatoQueryValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarInscricaoCandidatoMarcaQuery, List<InscricaoDto>>, PesquisarInscricaoCandidatoMarcaQueryValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarLinkRedireconamentoInstituicaoQuery,  InstituicaoLinkDto>, PesquisarLinkRedireconamentoInstituicaoQueryValidator>();
        services.AddScoped<IPipelineBehavior<ObterInscricaoCanditadoQuery, InscricaoCandidatoDetalhesDto>, ObterInscricaoCandidatoQueryValidator>();
        #endregion

        #region OfertaConcursos
        services.AddScoped<IPipelineBehavior<CriarOfertaConcursoCommand, EntityKeyDto>, CriarOfertaConcursoCommandValidator>();
        services.AddScoped<IPipelineBehavior<AtualizarOfertaConcursoCommand, Unit>, AtualizarOfertaConcursoCommandValidator>();
        services.AddScoped<IPipelineBehavior<ObterOfertaConcursoQuery, OfertaConcursoDto>, ObterOfertaConcursoQueryValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarOfertaConcursoQuery, ResultadoPaginadoDto<OfertaConcursoDto>>, PesquisarOfertaConcursoQueryValidator>();
        services.AddScoped<IPipelineBehavior<RemoverOfertaConcursoCommand, Unit>, RemoverOfertaConcursoCommandValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarCursosOfertadosQuery, List<CursoOfertadoDto>>, PesquisarCursosOfertadosQueryValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarCursoOfertadoDetalheQuery, List<CursoOfertadoDetalheDto>>, PesquisarCursoOfertadoDetalheQueryValidator>();
        #endregion

        #region Enderecos
        services.AddScoped<IPipelineBehavior<CriarPaisCommand, EntityKeyDto?>, CriarPaisCommandValidator>();
        services.AddScoped<IPipelineBehavior<AtualizarPaisCommand, Unit>, AtualizarPaisCommandValidator>();
        services.AddScoped<IPipelineBehavior<ObterPaisQuery, PaisDto>, ObterPaisQueryValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarPaisQuery, ResultadoPaginadoDto<PaisDto>>, PesquisarPaisQueryValidator>();
        services.AddScoped<IPipelineBehavior<RemoverPaisCommand, Unit>, RemoverPaisCommandValidator>();
        
        services.AddScoped<IPipelineBehavior<CriarEstadoCommand, EntityKeyDto?>, CriarEstadoCommandValidator>();
        services.AddScoped<IPipelineBehavior<AtualizarEstadoCommand, Unit>, AtualizarEstadoCommandValidator>();
        services.AddScoped<IPipelineBehavior<ObterEstadoQuery, EstadoDto>, ObterEstadoQueryValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarEstadoQuery, ResultadoPaginadoDto<EstadoDto>>, PesquisarEstadoQueryValidator>();
        services.AddScoped<IPipelineBehavior<RemoverEstadoCommand, Unit>, RemoverEstadoCommandValidator>();

        services.AddScoped<IPipelineBehavior<CriarCidadeCommand, EntityKeyDto?>, CriarCidadeCommandValidator>();
        services.AddScoped<IPipelineBehavior<AtualizarCidadeCommand, Unit>, AtualizarCidadeCommandValidator>();
        services.AddScoped<IPipelineBehavior<ObterCidadeQuery, CidadeDto>, ObterCidadeQueryValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarCidadeQuery, ResultadoPaginadoDto<CidadeDto>>, PesquisarCidadeQueryValidator>();
        services.AddScoped<IPipelineBehavior<RemoverCidadeCommand, Unit>, RemoverCidadeCommandValidator>();
        #endregion

        #region Marcas
        services.AddScoped<IPipelineBehavior<CriarMarcaCommand, EntityKeyDto?>, CriarMarcaCommandValidator>();
        services.AddScoped<IPipelineBehavior<AtualizarMarcaCommand, Unit>, AtualizarMarcaCommandValidator>();
        services.AddScoped<IPipelineBehavior<ObterMarcaQuery, MarcaDto>, ObterMarcaQueryValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarMarcaQuery, ResultadoPaginadoDto<MarcaDto>>, PesquisarMarcaQueryValidator>();
        services.AddScoped<IPipelineBehavior<RemoverMarcaCommand, Unit>, RemoverMarcaCommandValidator>();
        #endregion

        #region Escolas
        services.AddScoped<IPipelineBehavior<CriarEscolaCommand, EntityKeyDto?>, CriarEscolaCommandValidator>();
        services.AddScoped<IPipelineBehavior<AtualizarEscolaCommand, Unit>, AtualizarEscolaCommandValidator>();
        services.AddScoped<IPipelineBehavior<RemoverEscolaCommand, Unit>, RemoverEscolaCommandValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarEscolaQuery, ResultadoPaginadoDto<EscolaDto>>, PesquisarEscolaQueryValidator>();
        services.AddScoped<IPipelineBehavior<ObterEscolaQuery, EscolaDto>, ObterEscolaQueryValidator>();
        #endregion

        #region NivelCurso
        services.AddScoped<IPipelineBehavior<CriarNivelCursoCommand, EntityKeyDto?>, CriarNivelCursoCommandValidator>();
        services.AddScoped< IPipelineBehavior<AtualizarNivelCursoCommand, Unit>, AtualizarNivelCursoCommandValidator>();
        services.AddScoped<IPipelineBehavior<RemoverNivelCursoCommand, Unit>, RemoverNivelCursoCommandValidator>();
        services.AddScoped<IPipelineBehavior<ObterNivelCursoQuery, NivelCursoDto>, ObterNivelCursoQueryValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarNivelCursoQuery, ResultadoPaginadoDto<NivelCursoDto>>, PesquisarNivelCursoQueryValidator>();
        #endregion

        #region Cupons
        services.AddScoped<IPipelineBehavior<RemoverCupomCommand, Unit>, RemoverCupomCommandValidator>();
        services.AddScoped<IPipelineBehavior<AtualizarCupomCommand, Unit>, AtualizarCupomCommandValidator>();
        services.AddScoped<IPipelineBehavior<CriarCupomCommand, EntityKeyDto?>, CriarCupomCommandValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarCupomQuery, ResultadoPaginadoDto<CupomDto>>, PesquisarCupomQueryValidator>();
        services.AddScoped<IPipelineBehavior<ObterCupomQuery, CupomDto>, ObterCupomQueryValidator>();
        services.AddScoped<IPipelineBehavior<ValidarCupomQuery, ValidarCupomResultadoDto>, ValidarCupomQueryValidator>();
        #endregion

        #region Acessibilidade
        services.AddScoped<IPipelineBehavior<CriarAcessibilidadeCommand, EntityKeyDto?>, CriarAcessibilidadeCommandValidator>();
        services.AddScoped<IPipelineBehavior<AtualizarAcessibilidadeCommand, Unit>, AtualizarAcessibilidadeCommandValidator>();
        services.AddScoped<IPipelineBehavior<RemoverAcessibilidadeCommand, Unit>, RemoverAcessibilidadeCommandValidator>();
        services.AddScoped<IPipelineBehavior<ObterAcessibilidadeQuery, AcessibilidadeDto>, ObterAcessibilidadeQueryValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarAcessibilidadeQuery, ResultadoPaginadoDto<AcessibilidadeDto>>, PesquisarAcessibilidadeQueryValidator>();
        #endregion

        #region Deficiencias
        services.AddScoped<IPipelineBehavior<CriarDeficienciaCommand, EntityKeyDto?>, CriarDeficienciaCommandValidator>();
        services.AddScoped<IPipelineBehavior<AtualizarDeficienciaCommand, Unit>, AtualizarDeficienciaCommandValidator>();
        services.AddScoped<IPipelineBehavior<RemoverDeficienciaCommand, Unit>, RemoverDeficienciaCommandValidator>();
        services.AddScoped<IPipelineBehavior<ObterDeficienciaQuery, DeficienciaDto>, ObterDeficienciaQueryValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarDeficienciaQuery, ResultadoPaginadoDto<DeficienciaDto>>, PesquisarDeficienciaQueryValidator>();
        #endregion

        #region Campos
        services.AddScoped<IPipelineBehavior<CriarCampoCommand, EntityKeyDto?>, CriarCampoCommandValidator>();
        services.AddScoped<IPipelineBehavior<AtualizarCampoCommand, Unit>, AtualizarCampoCommandValidator>();
        services.AddScoped<IPipelineBehavior<RemoverCampoCommand, Unit>, RemoverCampoCommandValidator>();
        services.AddScoped<IPipelineBehavior<ObterCampoQuery, CampoDto>, ObterCampoQueryValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarCampoQuery, ResultadoPaginadoDto<CampoDto>>, PesquisarCampoQueryValidator>();
        #endregion

        #region Empresas
        services.AddScoped<IPipelineBehavior<CriarEmpresaCommand, EntityKeyDto?>, CriarEmpresaCommandValidator>();
        services.AddScoped<IPipelineBehavior<AtualizarEmpresaCommand, Unit>, AtualizarEmpresaCommandValidator>();
        services.AddScoped<IPipelineBehavior<RemoverEmpresaCommand, Unit>, RemoverEmpresaCommandValidator>();
        services.AddScoped<IPipelineBehavior<ObterEmpresaQuery, EmpresaDto>, ObterEmpresaQueryValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarEmpresaQuery, ResultadoPaginadoDto<EmpresaDto>>, PesquisarEmpresaQueryValidator>();
        #endregion

        #region CursoExterno
        services.AddScoped<IPipelineBehavior<ObterCursoExternoQuery, CursoExternoDto>, ObterCursoExternoQueryValidator>();
        #endregion

        #region Links
        services.AddScoped<IPipelineBehavior<CriarLinkCommand, EntityKeyDto?>, CriarLinkCommandValidator>();
        services.AddScoped<IPipelineBehavior<AtualizarLinkCommand, Unit>, AtualizarLinkCommandValidator>();
        services.AddScoped<IPipelineBehavior<RemoverLinkCommand, Unit>, RemoverLinkCommandValidator>();
        services.AddScoped<IPipelineBehavior<ObterLinkQuery, LinkDto>, ObterLinkQueryValidator>();
        services.AddScoped<IPipelineBehavior<PesquisarLinkQuery, ResultadoPaginadoDto<LinkDto>>, PesquisarLinkQueryValidator>();
        #endregion

        return services;
    }
}