using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Produtos;
using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Produtos;
using Anima.Inscricao.Domain.Turnos;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Produtos.ObterProduto
{
    public class ObterProdutoQueryHandler : IQueryHandler<ObterProdutoQuery, ProdutoDto>
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IInstituicaoRepository _instituicaoRepository;
        private readonly ICampusRepository _campusRepository;
        private readonly ICursoRepository _cursoRepository;
        private readonly ITurnoRepository _turnoRepository;

        public ObterProdutoQueryHandler(
            IProdutoRepository produtoRepository, 
            IInstituicaoRepository instituicaoRepository, 
            ICampusRepository campusRepository, 
            ICursoRepository cursoRepository, 
            ITurnoRepository turnoRepository)
        {
            _produtoRepository = produtoRepository;
            _instituicaoRepository = instituicaoRepository;
            _campusRepository = campusRepository;
            _cursoRepository = cursoRepository;
            _turnoRepository = turnoRepository;
        }

        public async Task<ProdutoDto> Handle(ObterProdutoQuery request, CancellationToken cancellationToken)
        {
            var query = from produto in _produtoRepository.GetQueryable()
                        join instituicao in _instituicaoRepository.GetQueryable()
                            on produto.InstituicaoId equals instituicao.Id
                        join campus in _campusRepository.GetQueryable()
                            on produto.CampusId equals campus.Id
                        join curso in _cursoRepository.GetQueryable()
                            on produto.CursoId equals curso.Id
                        join turno in _turnoRepository.GetQueryable()
                            on produto.TurnoId equals turno.Id
                        where produto.Key == request.Key
                        select new ProdutoDto
                        {
                            Key = produto.Key,
                            InstituicaoKey = instituicao.Key,
                            CampusKey = campus.Key,
                            CursoKey = curso.Key,
                            TurnoKey = turno.Key,
                            Sku = produto.Sku
                     
                        };

            return await query.SingleAsync();
        }
    }
}
