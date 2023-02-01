using prototype;

public class Program
{
    public static void Main(string[] args)
    {
        var jhon = new Person(new [] {$"Jhon", $"Smith"},
            new Address("London Road", 123));
        var jane = (Person)jhon.Clone();
        jane.Address = new Address("Paris Road", 321);
        
        Console.WriteLine(jhon);
        Console.WriteLine(jane);
    }
}