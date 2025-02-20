//using System.Linq.Expressions;

//namespace Anima.ComunicacaoAtiva.Domain._Shared.Specifications;

///// <summary>
///// Representa a classe base para especificações.
///// </summary>
///// <typeparam name="T">O tipo do objeto ao qual a especificação é aplicada.</typeparam>
//public abstract class Specification<T> : ISpecification<T>
//{
//    /// <summary>
//    /// Retorna um valor <see cref="bool"/> que indica se a especificação
//    /// é satisfeita pelo objeto fornecido.
//    /// </summary>
//    /// <param name="obj">O objeto ao qual a especificação é aplicada.</param>
//    /// <returns>Verdadeiro se a especificação for satisfeita, caso contrário falso.</returns>
//    public virtual bool IsSatisfiedBy(T obj)
//    {
//        return ToExpression().Compile()(obj);
//    }

//    /// <summary>
//    /// Obtém a expressão LINQ que representa a especificação atual.
//    /// </summary>
//    /// <returns>A expressão LINQ.</returns>
//    public abstract Expression<Func<T, bool>> ToExpression();

//    /// <summary>
//    /// Converte implicitamente uma especificação para uma expressão.
//    /// </summary>
//    /// <param name="specification"></param>
//    public static implicit operator Expression<Func<T, bool>>(Specification<T> specification)
//    {
//        return specification.ToExpression();
//    }
//}
