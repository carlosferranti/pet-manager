namespace Anima.Inscricao.Domain._Shared.Specifications;

/// <summary>
/// Representa que as classes implementadas são especificações. Para mais informações sobre o padrão de especificação, consulte http://martinfowler.com/apsupp/spec.pdf.
/// </summary>
/// <typeparam name="T">O tipo do objeto ao qual a especificação é aplicada.</typeparam>
public interface ISpecification<T>
{
    /// <summary>
    /// Retorna um valor <see cref="bool"/> que indica se a especificação é satisfeita pelo objeto fornecido.
    /// </summary>
    /// <param name="obj">O objeto ao qual a especificação é aplicada.</param>
    /// <returns>True se a especificação for satisfeita, caso contrário, false.</returns>
    bool IsSatisfiedBy(T obj);
}
