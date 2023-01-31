namespace factory.AbstractFactory;
using static System.Console;

internal class Tea : IHotDrink
{
    public void Consume()
    {
        WriteLine("This tea is nice but I'd prefer it with milk.");
    }
}