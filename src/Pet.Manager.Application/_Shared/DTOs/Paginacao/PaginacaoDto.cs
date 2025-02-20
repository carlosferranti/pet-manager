﻿namespace Anima.Inscricao.Application._Shared.DTOs.Paginacao;

/// <summary>
/// DTO responsável por armazenar os dados de pagincacao.
/// </summary>
public record PaginacaoDto
(
    /// <summary>
    /// Obtém ou define o numero da pagina.
    /// </summary>
    int NumeroPagina = 1,

    /// <summary>
    /// Obtém ou define a quantidade de registros.
    /// </summary>
    int QuantidadeRegistros = 10
);
