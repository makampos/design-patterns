using open.closed.principle.Filters;
using open.closed.principle.Models;
using open.closed.principle.Specifications;

namespace open.closed.principle;

public class Program
{
    static void Main(string[] args)
    {
        var apple = new Product("Apple", Color.Green, Size.Small);
        var tree = new Product("Tree", Color.Green, Size.Large);
        var house = new Product("House", Color.Blue, Size.Large);
        
        Product[] products = {apple, tree, house};

        var productFilter = new ProductFilter();
        Console.WriteLine("Green products (old):");

        foreach (var product in productFilter.FilterByColor(products, Color.Green))
        {
            Console.WriteLine($"- {product.Name} is green");
        }
        
        // Using BetterFilter
        var betterFilter = new BetterFilter();
        
        Console.WriteLine("Green products (new):");
        foreach (var product in betterFilter.Filter(products, new ColorSpecification(Color.Green)))
        {
            Console.WriteLine($"- {product.Name} is green");
        }
        
        // Using BetterFilter and AndSpecification to combine more than one filter.
        Console.WriteLine("Large blue items");
        foreach (var product in betterFilter.Filter(
                     products,
                     new AndSpecification<Product>(
                         new ColorSpecification(Color.Blue),
                         new SizeSpecification(Size.Large)
                     )))
        {
            Console.Write($"- {product.Name} is big and blue");
        }
    }
}