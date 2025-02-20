using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Empresas;

namespace Anima.Inscricao.Application.UseCases.Empresas.PesquisarEmpresa;

public class PesquisarEmpresaQuery : IQuery<ResultadoPaginadoDto<EmpresaDto>>
{
    public PesquisarEmpresaFiltros? Filtros { get; set; }

    public PaginacaoDto Paginacao { get; set; } = new PaginacaoDto();

    public record PesquisarEmpresaFiltros(string? Cnpj);
}
