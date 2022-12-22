namespace dependency.inversion.principle.BetterSolution;

public class Research
{
    public Research(IRelationshipBrowser browser)
    {
        foreach (var person in browser.FindAllChildrenOf("Adonis"))
            Console.WriteLine($"Adonis has a child called {person.Name}");
    }
    
    // public Research(Relationships relationships)
    // {
    //     var relations = relationships.Relations;
    //     foreach (var r in relations.Where(
    //                  x => x.Item1.Name == "Adonis"
    //                       && x.Item2 == Relationship.Parent))
    //     {
    //         Console.WriteLine($"Adonis has a child called {r.Item3.Name}");
    //     }
    // }
}