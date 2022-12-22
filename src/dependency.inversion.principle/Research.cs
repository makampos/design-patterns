namespace dependency.inversion.principle;

public class Research
{
    public Research(Relationships relationships)
    {
        var relations = relationships.Relations;
        foreach (var r in relations.Where(
                     x => x.Item1.Name == "Adonis"
                          && x.Item2 == Relationship.Parent))
        {
            Console.WriteLine($"Adonis has a child called {r.Item3.Name}");
        }
    }
}