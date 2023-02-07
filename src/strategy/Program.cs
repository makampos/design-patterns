using strategy.DynamicStrategy;

namespace strategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // TO-DO implement using DI  to use different instance***
            var textProcessor = new TextProcessor<HtmlListStrategy>();
            textProcessor.AppendList(new[] {"foo", "bar", "baz"});
            System.Console.WriteLine(textProcessor);
        }
    }
}