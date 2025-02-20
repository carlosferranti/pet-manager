using System.Diagnostics;

using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Campi.Entities;
using Anima.Inscricao.Domain.Cursos.Entities;
using Anima.Inscricao.Domain.Instituicoes.Entities;
using Anima.Inscricao.Domain.Produtos.Entities;
using Anima.Inscricao.Domain.Turnos.Entities;

namespace Anima.Inscricao.Domain.Produtos.Validators;

public class AtualizarProdutoDomainValidator : DomainValidator
{
    private readonly IProdutoRepository _produtoRepository;
    public AtualizarProdutoDomainValidator(IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    public bool Validate(ProdutoId produtoId, InstituicaoId instituicaoId, CampusId campusId, CursoId cursoId, TurnoId turnoId, string sku)
    {
        var produtoExiste = _produtoRepository
            .GetQueryable()
            .Where(c =>
            c.InstituicaoId == instituicaoId &&
            c.CampusId == campusId && c.CursoId == cursoId 
            && c.TurnoId == turnoId && c.Sku == sku &&
            c.Id != produtoId)
            .Any();

        if (produtoExiste)
        {
            Validations.Add(new InfoValidation("Nome","ProdutoUnico", "Um produto com as mesmas informações já foi cadastrado."));
        }

        return !Validations.Any();
    }
}
