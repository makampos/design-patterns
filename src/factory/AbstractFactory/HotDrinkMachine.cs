namespace factory.AbstractFactory;
using static System.Console;

public class HotDrinkMachine
{
    private readonly List<Tuple<string, IHotDrinkFactory>> factories =
        new List<Tuple<string, IHotDrinkFactory>>();

    public HotDrinkMachine()
    {
        foreach (var t in typeof(HotDrinkMachine).Assembly.GetTypes())
        {
            if (typeof(IHotDrinkFactory).IsAssignableFrom(t) && !t.IsInterface)
            {
                factories.Add(
                (Tuple.Create(t.Name.Replace("Factory", string.Empty),
                    (IHotDrinkFactory)Activator.CreateInstance(t)!))
                );
            }
        }
    }

    public IHotDrink MakeDrink()
    {
        WriteLine("Available drinks:");
        for (var index = 0; index < factories.Count; index++)
        {
            var tuple = factories[index];
            WriteLine($"{index}: {tuple.Item1}");
        }

        while (true)
        {
            string s;
            if ((s = ReadLine()) != null
                && int.TryParse(s, out int i)
                && i >=0
                && i < factories.Count)
            {
                WriteLine("Specify amount: ");
                s = ReadLine();
                if (s != null
                    && int.TryParse(s, out int amount)
                    && amount > 0)
                {
                    return factories[i].Item2.Prepare(amount);
                }
            }
            WriteLine("Incorrect input, try again.");
        }
    }
}