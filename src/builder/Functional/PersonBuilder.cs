namespace builder.Functional;

public sealed class PersonBuilder : FunctionBuilder<Person, PersonBuilder>
{
    public PersonBuilder Called(string name) => Do(p => p.Name = name);
}