using open.closed.principle.Interfaces;
using open.closed.principle.Models;

namespace open.closed.principle.Specifications;
public class ColorSpecification : ISpecification<Product>
{
    private readonly Color _color;
    public ColorSpecification(Color color) => _color = color;

    public bool IsSatisfied(Product t) => t.Color == _color;
}
