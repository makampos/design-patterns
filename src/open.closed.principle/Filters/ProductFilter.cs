using open.closed.principle.Models;

namespace open.closed.principle.Filters;

public class ProductFilter
{
    public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
    {
        foreach (var product in products)
        {
            if (product.Size == size)
                yield return product;
        }
    }
        
    public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
    {
        foreach (var product in products)
        {
            if (product.Color == color)
                yield return product;
        }
    }
        
    public IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Color color, Size size)
    {
        foreach (var product in products)
        {
            if (product.Color == color && product.Size == size)
                yield return product;
        }
    }
        
    // public IEnumerable<Product> FilterByName(IEnumerable<Product> products, string name)  {...}
    // public IEnumerable<Product> FilterBySomething(IEnumerable<Product> products, string something)  {...}
        
    // Doing something like that, we are extending the behavior of the class but violating the principle
    // [Open to extension and closed to modification]
}