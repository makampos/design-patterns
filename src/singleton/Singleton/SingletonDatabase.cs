using MoreLinq.Extensions;
using static System.Console;

namespace singleton.Singleton
{
    

    public class SingletonDatabase : IDatabase
    {
        private Dictionary<string, int> capitals;
        private static int _instanceCount; // = 0;
        public static int Count => _instanceCount;
        private SingletonDatabase()
        {
            _instanceCount++;
            WriteLine("Initializing database (...)");
            capitals = File.ReadAllLines($"capitals.txt")
                .Batch(2)
                .ToDictionary(
                    list => list.ElementAt(0).Trim(),
                    list => int.Parse(list.ElementAt(1))
                );
        }
    
        public int GetPopulation(string name)
        {
            return capitals[name];
        }

        private static Lazy<SingletonDatabase> instance = 
            new Lazy<SingletonDatabase>(() => new SingletonDatabase());
        public static SingletonDatabase Instance => instance.Value;
    }
}