using open.closed.principle.Interfaces;
using open.closed.principle.Models;

namespace open.closed.principle.Specifications;

public class SizeSpecification : ISpecification<Product>
{
    private readonly Size _size;
    public SizeSpecification(Size size) => _size = size;
    public bool IsSatisfied(Product t) => t.Size == _size;
}