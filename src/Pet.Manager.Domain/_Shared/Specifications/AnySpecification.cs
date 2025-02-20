//using System.Linq.Expressions;

//namespace Anima.ComunicacaoAtiva.Domain._Shared.Specifications;

///// <summary>
///// Especificação genérica que sempre retorna verdadeiro.
///// </summary>
///// <typeparam name="T">O tipo de entidade.</typeparam>
//public sealed class AnySpecification<T> : Specification<T>
//{
//    /// <summary>
//    /// Converte a especificação em uma expressão lambda que sempre retorna verdadeiro.
//    /// </summary>
//    /// <returns>A expressão lambda.</returns>
//    public override Expression<Func<T, bool>> ToExpression()
//    {
//        return o => true;
//    }
//}
