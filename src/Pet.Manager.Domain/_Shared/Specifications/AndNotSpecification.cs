//using System.Linq.Expressions;

//namespace Anima.ComunicacaoAtiva.Domain._Shared.Specifications;

///// <summary>
///// Representa a especificação combinada que indica que a primeira especificação
///// pode ser satisfeita pelo objeto fornecido, enquanto a segunda não pode.
///// </summary>
///// <typeparam name="T">O tipo do objeto ao qual a especificação é aplicada.</typeparam>
//public class AndNotSpecification<T> : CompositeSpecification<T>
//{
//    /// <summary>
//    /// Inicia uma nova instância da classe <see cref="AndNotSpecification{T}"/>.
//    /// </summary>
//    /// <param name="left">A primeira especificação.</param>
//    /// <param name="right">A segunda especificação.</param>
//    public AndNotSpecification(ISpecification<T> left, ISpecification<T> right)
//        : base(left, right)
//    {
//    }

//    /// <summary>
//    /// Obtém a expressão LINQ que representa a especificação atual.
//    /// </summary>
//    /// <returns>A expressão LINQ.</returns>
//    public override Expression<Func<T, bool>> ToExpression()
//    {
//        var rightExpression = Right.ToExpression();

//        var bodyNot = Expression.Not(rightExpression.Body);
//        var bodyNotExpression = Expression.Lambda<Func<T, bool>>(bodyNot, rightExpression.Parameters);

//        return Left.ToExpression().And(bodyNotExpression);
//    }
//}
