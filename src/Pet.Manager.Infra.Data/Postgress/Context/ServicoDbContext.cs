using Anima.Inscricao.Infra.Data._Shared.Postgres.Context;

using MediatR;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Anima.Inscricao.Infra.Data.Postgress.Context;

public class ServicoDbContext : CoreDbContext
{
    public ServicoDbContext(ILogger<ServicoDbContext> logger, DbContextOptions options, IMediator mediator)
       : base(logger, options, mediator)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ServicoDbContext).Assembly);
    }
}
