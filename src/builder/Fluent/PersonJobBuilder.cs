namespace builder.Fluent;

public class PersonJobBuilder<TSelf> : PersonInfoBuilder<PersonJobBuilder<TSelf>> where TSelf : PersonJobBuilder<TSelf>
{
    public TSelf? WorksAsA(string position)
    {
        person.Position = position;
        return this as TSelf;
    }
}
