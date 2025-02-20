using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.UseCases.Escolas.ObterAnoConclusao;

namespace Anima.Inscricao.Application.UseCases.Escolas.ObterAnosConclusao;

public class ObterAnosConclusaoQueryHandler : IQueryHandler<ObterAnosConclusaoQuery, List<int>>
{
    public async Task<List<int>> Handle(ObterAnosConclusaoQuery request, CancellationToken cancellationToken)
    {
        return await Task.Run(() => 
        {
            var anoAtual = DateTime.Now.Year;

            var anosConclusao = new List<int>();

            for (var i = 100; i > 0; i--)
            {
                anosConclusao.Add(anoAtual - i);
            }

            for (var i = 0; i <= 3; i++)
            {
                anosConclusao.Add(anoAtual + i);
            }

            return anosConclusao.OrderDescending().ToList();
        });
    }
}
