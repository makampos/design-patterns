using open.closed.principle.Interfaces;
using open.closed.principle.Models;

namespace open.closed.principle.Filters;
public class BetterFilter : IFilter<Product>
{
    public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
    {
        foreach (var item in items)
        {
            if (spec.IsSatisfied(item))
                yield return item;
        }
    }
}