using Anima.Inscricao.Domain.Empresas;
using Anima.Inscricao.Domain.Empresas.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class EmpresaRepository : Repository<Empresa, EmpresaId>, IEmpresaRepository
{
    public EmpresaRepository(ServicoDbContext dbContext) : base(dbContext)
    {
    }
}