namespace single.responsibility.principle;

public class Program
{
    static void Main(string[] args)
    {
        var journal = new Journal();
        journal.AddEntry("I cried today");
        journal.AddEntry("I ate a bug");
        Console.WriteLine(journal);

        var persistence = new Persistence();
        var fileName = @"d:\Development\repos\design-patterns\src\single.responsibility.principle";
        persistence.SaveToFile(journal, fileName, true);
    }
}