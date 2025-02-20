using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Ofertas.AtualizarOferta;

public class AtualizarOfertaCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }

    public Guid ProdutoKey { get; set; }

    public Guid IntakeKey { get; set; }
}
