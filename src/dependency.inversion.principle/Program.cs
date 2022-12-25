namespace dependency.inversion.principle;

public class Program
{
    public static void Main(string[] args)
    {
        var parent = new Person { Name = "Adonis" };
        var child1 = new Person { Name = "Rock" };
        var child2 = new Person { Name = "Michael" };

        // var relationships = new Relationships();
        // relationships.AddParentAndChild(parent, child1);
        // relationships.AddParentAndChild(parent, child2);

        //new Research(relationships);

        /*BetterSolution*/
        var relationships = new BetterSolution.Relationships();
        relationships.AddParentAndChild(parent, child1);
        relationships.AddParentAndChild(parent, child2); 
        new BetterSolution.Research(relationships);
    }
}