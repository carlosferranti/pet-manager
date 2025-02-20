//using System.Linq.Expressions;

//namespace Anima.ComunicacaoAtiva.Domain._Shared.Specifications;

///// <summary>
///// Representa a extensão para o tipo Expression[Func[T, bool]].
///// Isso faz parte da solução que resolve o problema do parâmetro de expressão ao usar o Entity Framework.
///// Para mais informações sobre essa solução, consulte http://blogs.msdn.com/b/meek/archive/2008/05/02/linq-to-entities-combining-predicates.aspx.
///// </summary>
//public static class ExpressionFuncExtender
//{
//    /// <summary>
//    /// Combina duas expressões dadas usando a semântica E (AND).
//    /// </summary>
//    /// <typeparam name="T">O tipo do objeto.</typeparam>
//    /// <param name="first">A primeira parte da expressão.</param>
//    /// <param name="second">A segunda parte da expressão.</param>
//    /// <returns>A expressão combinada.</returns>
//    public static Expression<Func<T, bool>> And<T>(
//        this Expression<Func<T, bool>> first, Expression<Func<T, bool>> second)
//    {
//        return first.Compose(second, Expression.AndAlso);
//    }

//    /// <summary>
//    /// Combina duas expressões dadas usando a semântica OU (OR).
//    /// </summary>
//    /// <typeparam name="T">O tipo do objeto.</typeparam>
//    /// <param name="first">A primeira parte da expressão.</param>
//    /// <param name="second">A segunda parte da expressão.</param>
//    /// <returns>A expressão combinada.</returns>
//    public static Expression<Func<T, bool>> Or<T>(
//        this Expression<Func<T, bool>> first, Expression<Func<T, bool>> second)
//    {
//        return first.Compose(second, Expression.OrElse);
//    }

//    private static Expression<T> Compose<T>(
//    this Expression<T> first, Expression<T> second, Func<Expression, Expression, Expression> merge)
//    {
//        // constrói um mapa de parâmetros (dos parâmetros do segundo para os parâmetros do primeiro)
//        var map = first.Parameters.Select((f, i) => new { f, s = second.Parameters[i] })
//            .ToDictionary(p => p.s, p => p.f);

//        // substitui os parâmetros na segunda expressão lambda pelos parâmetros do primeiro
//        var secondBody = ParameterRebinder.ReplaceParameters(map, second.Body);

//        // aplica a composição dos corpos das expressões lambda aos parâmetros da primeira expressão
//        return Expression.Lambda<T>(merge(first.Body, secondBody), first.Parameters);
//    }
//}
