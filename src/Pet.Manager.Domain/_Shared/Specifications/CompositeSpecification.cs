//namespace Anima.ComunicacaoAtiva.Domain._Shared.Specifications;

///// <summary>
///// Representa a classe base para especificações compostas.
///// </summary>
///// <typeparam name="T">O tipo do objeto ao qual a especificação é aplicada.</typeparam>
//public abstract class CompositeSpecification<T> : Specification<T>, ICompositeSpecification<T>
//{
//    /// <summary>
//    /// Inicia uma nova instância da classe <see cref="CompositeSpecification{T}"/>.
//    /// </summary>
//    /// <param name="left">A primeira especificação.</param>
//    /// <param name="right">A segunda especificação.</param>
//    protected CompositeSpecification(ISpecification<T> left, ISpecification<T> right)
//    {
//        Left = left;
//        Right = right;
//    }

//    /// <summary>
//    /// Obtém a primeira especificação.
//    /// </summary>
//    public ISpecification<T> Left { get; }

//    /// <summary>
//    /// Obtém a segunda especificação.
//    /// </summary>
//    public ISpecification<T> Right { get; }
//}
