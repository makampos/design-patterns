namespace builder.Fluent;

public abstract class PersonBuilder
{
    protected readonly Person person = new Person();
    public Person Build() => person;
}