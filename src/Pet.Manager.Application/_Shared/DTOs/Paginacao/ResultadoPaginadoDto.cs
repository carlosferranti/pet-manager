namespace Anima.Inscricao.Application._Shared.DTOs.Paginacao;

/// <summary>
/// Classe base de retornos paginados.
/// </summary>
/// <typeparam name="T">Tipo do retorno.</typeparam>
public class ResultadoPaginadoDto<T>
{
    public ResultadoPaginadoDto()
    {
    }

    public ResultadoPaginadoDto(IEnumerable<T> data)
    {
        Data = data;
    }

    public ResultadoPaginadoDto(IEnumerable<T> data, int numeroPagina, int quantidadeRegistros, int totalRegistros)
    {
        Data = data;
        NumeroPagina = numeroPagina;
        LimitePagina = quantidadeRegistros;
        TotalRegistros = totalRegistros;
    }

    /// <summary>
    /// Obtém ou define o numero da pagina.
    /// </summary>
    public int NumeroPagina { get; set; } = 0;

    /// <summary>
    /// Obtém ou define a quantidade de registros.
    /// </summary>
    public int LimitePagina { get; set; } = 0;

    /// <summary>
    /// Obtém ou define o total de registros resultantes da consulta.
    /// </summary>
    public int TotalRegistros { get; set; }

    public IEnumerable<T>? Data { get; set; }


}