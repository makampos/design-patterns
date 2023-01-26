namespace builder.Fluent;

public class PersonInfoBuilder<TSelf> : PersonBuilder where TSelf : PersonInfoBuilder<TSelf>
{
    public TSelf? Called(string name)
    {
        person.Name = name;
        return this as TSelf;
    }
}