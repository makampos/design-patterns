namespace factory.AbstractFactory;
using static System.Console;

internal class Coffee : IHotDrink
{
    public void Consume()
    {
        WriteLine($"This Coffee is delicious");
    }
}