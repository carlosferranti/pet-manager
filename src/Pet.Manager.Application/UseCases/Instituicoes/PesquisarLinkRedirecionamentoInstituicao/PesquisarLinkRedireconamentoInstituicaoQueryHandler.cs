using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Inscricoes;
using Anima.Inscricao.Application.DTOs.Instituicao;
using Anima.Inscricao.Application.Extensions;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.FormasEntrada.Enums;
using Anima.Inscricao.Domain.Inscricoes.Entities;
using Anima.Inscricao.Domain.Inscricoes.Enums;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Instituicoes.Entities;
using Anima.Inscricoes.Domain.Inscricoes;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Instituicoes.PesquisarLinkRedirecionamentoCandidato;

public class PesquisarLinkRedireconamentoInstituicaoQueryHandler : IQueryHandler<PesquisarLinkRedireconamentoInstituicaoQuery, InstituicaoLinkDto>
{
    private readonly IInscricaoRepository _inscricaoRepository;
    private readonly IInstituicaoLinkRepository _ilinkinscricaoRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;

    public PesquisarLinkRedireconamentoInstituicaoQueryHandler(
        IInstituicaoLinkRepository iInstituicaoLinkRepository,
        IInscricaoRepository inscricaoRepository,
        IFormaEntradaRepository formaEntradaRepository)
    {
        _inscricaoRepository = inscricaoRepository;
        _ilinkinscricaoRepository = iInstituicaoLinkRepository;
        _formaEntradaRepository = formaEntradaRepository;
    }

    public async Task<InstituicaoLinkDto> Handle(PesquisarLinkRedireconamentoInstituicaoQuery request, CancellationToken cancellationToken)
    {
        InscricaoCandidatoId inscricaoCandidatoId = await _inscricaoRepository.ObterInscriaoCandidatoIdAsync(request.key);
        var inscricaoKey = request.key;

        var formasEntradaInscricao = await ObterFormaEntradaInscricaoAsync(inscricaoCandidatoId);
        var formaEntradaManual = formasEntradaInscricao.FirstOrDefault(x => x.TipoSelecao == TipoSelecaoFormaEntrada.Manual);

        if (formaEntradaManual == null)
        {
            var inscricoes = await _inscricaoRepository.ObterInscricoesFinalizadasCandidatoPorInscricao(inscricaoCandidatoId, cancellationToken);
            inscricaoKey = inscricoes?.FirstOrDefault()?.Key ?? inscricaoKey;

            if (inscricaoKey != request.key)
            {
                var formasEntradaNovaInscricao = await ObterFormaEntradaInscricaoAsync(inscricaoCandidatoId);
                formaEntradaManual = formasEntradaNovaInscricao.FirstOrDefault(x => x.TipoSelecao == TipoSelecaoFormaEntrada.Manual);
            }
        }

        string tipoLink = GerartipoLink(formaEntradaManual?.FormaEntradaNome);

        InstituicaoLink objetoLink = await _ilinkinscricaoRepository.ObterInstituicaoLinkAsync(inscricaoKey, tipoLink, cancellationToken);
        InstituicaoLinkDto parseRetorno = new InstituicaoLinkDto();

        if (objetoLink != null)
        {
            parseRetorno.Id = objetoLink.Id;
            parseRetorno.MarcaId = objetoLink.MarcaId;
            parseRetorno.Key = objetoLink.Key;
            parseRetorno.TipoLink = objetoLink.TipoLink;
            parseRetorno.Url = tipoLink != "area_candidato_coi" ? GerarLinkRedirectCandidato(formaEntradaManual?.FormaEntradaNome, objetoLink, request.key) : objetoLink.Url;
        }
        return parseRetorno;
    }

    private string GerarLinkRedirectCandidato(string? formaEntradaCandidato, InstituicaoLink linkInstituicao, Guid request)
    {
        byte[] url = System.Text.Encoding.UTF8.GetBytes($"inscricaoKey={request}");

        if (formaEntradaCandidato == FormaDeEntradaNaoCoi.EntradaSimplificada.Description().ToString())
        {
           url= System.Text.Encoding.UTF8.GetBytes($"inscricaoKey={request}&formaprova={6}");
        }
        
        return  $@"{linkInstituicao.Url}/{Convert.ToBase64String(url)}";;
    }
    
    private string GerartipoLink(string? formaEntradaCandidato)
    {
        var formaEntradaCoi = EnumExtensions.GetEnumValueFromDescription<FormaDeEntradaCoi>(formaEntradaCandidato);
        
        string tipoLink = formaEntradaCoi ? "area_candidato_coi" : "area_candidato_entrada_simplificada";

        return tipoLink;
    }

    private async Task<IEnumerable<InscricaoFormaEntradaDto>> ObterFormaEntradaInscricaoAsync(InscricaoCandidatoId inscricaoCandidatoId)
    {
        var query = from inscricao in _inscricaoRepository.GetQueryable().AsNoTracking()
                    from formaEntradaInscricao in inscricao.FormasEntrada
                    join formaEntrada in _formaEntradaRepository.GetQueryable().AsNoTracking()
                    on formaEntradaInscricao.FormaEntradaId equals formaEntrada.Id
                    where inscricao.Id == inscricaoCandidatoId
                    select new InscricaoFormaEntradaDto()
                    {
                        CodigoTipoSelecao = formaEntradaInscricao.CodigoTipoSelecao.ToString(),
                        FormaEntradaKey = formaEntrada.Key,
                        FormaEntradaNome = formaEntrada.Nome,
                        TipoSelecao = formaEntradaInscricao.CodigoTipoSelecao,
                    };

        return await query.ToListAsync();
    }
}