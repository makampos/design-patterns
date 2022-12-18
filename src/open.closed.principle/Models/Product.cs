namespace open.closed.principle.Models;
public class Product
{
    public Product(string name, Color color, Size size)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Color = color;
        Size = size;
    }
    public String Name { get; }
    public Color Color { get; }
    public Size Size { get; }
}