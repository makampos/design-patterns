using open.closed.principle.Interfaces;

namespace open.closed.principle.Specifications;

public class AndSpecification<T> : ISpecification<T>
{
    private readonly ISpecification<T> _first, _second;
    public AndSpecification(ISpecification<T> first, ISpecification<T> second)
    {
        _first = first ?? throw new ArgumentNullException(nameof(first));
        _second = second ?? throw new ArgumentNullException(nameof(second));
    }
    public bool IsSatisfied(T t) => _first.IsSatisfied(t) && _second.IsSatisfied(t);
}