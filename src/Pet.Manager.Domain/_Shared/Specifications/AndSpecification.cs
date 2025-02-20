//using System.Linq.Expressions;

//namespace Anima.ComunicacaoAtiva.Domain._Shared.Specifications;

///// <summary>
///// Representa a especificação combinada que indica que ambas as especificações
///// fornecidas devem ser satisfeitas pelo objeto fornecido.
///// </summary>
///// <typeparam name="T">O tipo do objeto ao qual a especificação é aplicada.</typeparam>
//public class AndSpecification<T> : CompositeSpecification<T>
//{
//    /// <summary>
//    /// Inicia uma nova instância da classe <see cref="AndSpecification{T}"/>.
//    /// </summary>
//    /// <param name="left">A primeira especificação.</param>
//    /// <param name="right">A segunda especificação.</param>
//    public AndSpecification(ISpecification<T> left, ISpecification<T> right)
//        : base(left, right)
//    {
//    }

//    /// <summary>
//    /// Obtém a expressão LINQ que representa a especificação atual.
//    /// </summary>
//    /// <returns>A expressão LINQ.</returns>
//    public override Expression<Func<T, bool>> ToExpression()
//    {
//        return Left.ToExpression().And(Right.ToExpression());
//    }
//}
