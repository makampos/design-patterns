namespace factory.AbstractFactory;

public class HotDrinkMachine
{
    private readonly Dictionary<AvailableDrink, IHotDrinkFactory> factories = 
        new Dictionary<AvailableDrink, IHotDrinkFactory>();

    public HotDrinkMachine()
    {
        foreach (AvailableDrink drink in Enum.GetValues(typeof(AvailableDrink)))
        {
            var factory = (IHotDrinkFactory)Activator.CreateInstance(
                Type.GetType("factory.AbstractFactory." + Enum.GetName(typeof(AvailableDrink), drink) + "Factory"));
            factories.Add(drink, factory);
        }
    }
    
    public IHotDrink MakeDrink(AvailableDrink drink, int amount)
    {
        return factories[drink].Prepare(amount);
    }
}