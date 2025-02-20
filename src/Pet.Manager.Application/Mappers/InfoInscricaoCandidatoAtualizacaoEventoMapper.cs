using Anima.Inscricao.Application.DTOs.Inscricoes;
using Anima.Inscricao.Application.UseCases.Inscricoes.AtualizarInscricaoCandidato;

using AutoMapper;

using static Anima.Inscricao.Application.DTOs.Inscricoes.InfoInscricaoCandidatoAtualizacaoEventoDto;
using static Anima.Inscricao.Application.UseCases.Inscricoes.AtualizarInscricaoCandidato.AtualizarInscricaoCandidatoCommand;

namespace Anima.Inscricao.Application.Mappers;

public class InfoInscricaoCandidatoAtualizacaoEventoMapper : Profile
{
    public InfoInscricaoCandidatoAtualizacaoEventoMapper()
    {
        CreateMap<AtualizarInscricaoCandidatoCommand, InfoInscricaoCandidatoAtualizacaoEventoDto>().ReverseMap();

        CreateMap<AtualizarInfosPessoaisCommand, AtualizarInfosPessoaisDto>().ReverseMap();
        CreateMap<AtualizarInfosOfertaCommand, AtualizarInfosOfertaDto>().ReverseMap();
        CreateMap<AtualizarInfosFichaCommand, AtualizarInfosFichaDto>().ReverseMap();
        CreateMap<AtualizarInfosOrigemCommand, AtualizarInfosOrigemDto>().ReverseMap();
        CreateMap<AtualizarInfosEscolaridadeCommand, AtualizarInfosEscolaridadeDto>().ReverseMap();
        CreateMap<AtualizarInfosContatoCommand, AtualizarInfosContatoDto>().ReverseMap();
        CreateMap<AtualizarInfosCupomCommand, AtualizarInfosCupomDto>().ReverseMap();
        CreateMap<AtualizarInfosEnderecoCommand, AtualizarInfosEnderecoDto>().ReverseMap();
        CreateMap<AtualizarInfosDocumentoCommand, AtualizarInfosDocumentoDto>().ReverseMap();
        CreateMap<AtualizarInfosSeguroFiancaCommand, AtualizarInfosSeguroFiancaDto>().ReverseMap();
        CreateMap<AtualizarInfosAcessibilidadeCommand, AtualizarInfosAcessibilidadeDto>().ReverseMap();
        CreateMap<AtualizarInfosDeficienciaCommand, AtualizarInfosDeficienciaDto>().ReverseMap();
    }
}
