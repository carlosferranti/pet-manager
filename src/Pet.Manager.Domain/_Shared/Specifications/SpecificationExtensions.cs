//namespace Anima.ComunicacaoAtiva.Domain._Shared.Specifications;

//public static class SpecificationExtensions
//{
//    /// <summary>
//    /// Combina a instância atual de especificação com outra instância de especificação
//    /// e retorna a especificação combinada que representa que tanto a especificação atual
//    /// quanto a especificação fornecida devem ser satisfeitas pelo objeto fornecido.
//    /// </summary>
//    /// <param name="specification">A especificação.</param>
//    /// <param name="other">A instância de especificação com a qual a especificação atual é combinada.</param>
//    /// <returns>A instância de especificação combinada.</returns>
//    public static ISpecification<T> And<T>(this ISpecification<T> specification, ISpecification<T> other)
//    {
//        if (specification is null)
//        {
//            throw new ArgumentNullException(nameof(specification));
//        }

//        if (other is null)
//        {
//            throw new ArgumentNullException(nameof(other));
//        }

//        return new AndSpecification<T>(specification, other);
//    }

//    /// <summary>
//    /// Combina a instância atual de especificação com outra instância de especificação
//    /// e retorna a especificação combinada que representa que ou a especificação atual ou
//    /// a especificação fornecida devem ser satisfeitas pelo objeto fornecido.
//    /// </summary>
//    /// <param name="specification">A especificação.</param>
//    /// <param name="other">A instância de especificação com a qual a especificação atual é combinada.</param>
//    /// <returns>A instância de especificação combinada.</returns>
//    public static ISpecification<T> Or<T>(this ISpecification<T> specification, ISpecification<T> other)
//    {
//        if (specification is null)
//        {
//            throw new ArgumentNullException(nameof(specification));
//        }

//        if (other is null)
//        {
//            throw new ArgumentNullException(nameof(other));
//        }

//        return new OrSpecification<T>(specification, other);
//    }

//    /// <summary>
//    /// Combina a instância atual de especificação com outra instância de especificação
//    /// e retorna a especificação combinada que representa que a especificação atual
//    /// deve ser satisfeita pelo objeto fornecido, mas a especificação especificada não.
//    /// </summary>
//    /// <param name="specification">A especificação.</param>
//    /// <param name="other">A instância de especificação com a qual a especificação atual é combinada.</param>
//    /// <returns>A instância de especificação combinada.</returns>
//    public static ISpecification<T> AndNot<T>(this ISpecification<T> specification, ISpecification<T> other)
//    {
//        if (specification is null)
//        {
//            throw new ArgumentNullException(nameof(specification));
//        }

//        if (other is null)
//        {
//            throw new ArgumentNullException(nameof(other));
//        }

//        return new AndNotSpecification<T>(specification, other);
//    }

//    /// <summary>
//    /// Inverte a instância atual de especificação e retorna uma especificação que representa
//    /// a semântica oposta à especificação atual.
//    /// </summary>
//    /// <returns>A instância de especificação invertida.</returns>
//    public static ISpecification<T> Not<T>(this ISpecification<T> specification)
//    {
//        if (specification is null)
//        {
//            throw new ArgumentNullException(nameof(specification));
//        }

//        return new NotSpecification<T>(specification);
//    }
//}
