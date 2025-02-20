//using System.Linq.Expressions;

//namespace Anima.ComunicacaoAtiva.Domain._Shared.Specifications;

///// <summary>
///// Representa a especificação que é representada pela expressão LINQ correspondente.
///// </summary>
///// <typeparam name="T">O tipo do objeto ao qual a especificação é aplicada.</typeparam>
//public class ExpressionSpecification<T> : Specification<T>
//{
//    private readonly Expression<Func<T, bool>> _expression;

//    /// <summary>
//    /// Inicializa uma nova instância da classe <c>ExpressionSpecification&lt;T&gt;</c>.
//    /// </summary>
//    /// <param name="expression">A expressão LINQ que representa a especificação atual.</param>
//    public ExpressionSpecification(Expression<Func<T, bool>> expression)
//    {
//        _expression = expression;
//    }

//    /// <summary>
//    /// Obtém a expressão LINQ que representa a especificação atual.
//    /// </summary>
//    /// <returns>A expressão LINQ.</returns>
//    public override Expression<Func<T, bool>> ToExpression()
//    {
//        return _expression;
//    }
//}
