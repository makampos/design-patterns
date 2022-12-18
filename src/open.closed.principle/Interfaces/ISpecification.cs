namespace open.closed.principle.Interfaces;

public interface ISpecification<T>
{
    bool IsSatisfied(T t);
}