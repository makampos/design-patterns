namespace factory.AbstractFactory;
using static System.Console;

internal class TeaFactory : IHotDrinkFactory
{
    public IHotDrink Prepare(int amount)
    {
        WriteLine($"Put in tea bag, boil water, pour {amount} ml, add lemon, enjoy!");
        return new Tea();
    }
}
