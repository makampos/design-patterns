namespace builder.Facade;

public class PersonBuilder // facetaed builder
{
    // the object we're going to build
    protected Person person = new Person(); // reference!
    public PersonJobBuilder works => new PersonJobBuilder(person);
    public PersonAddressBuilder lives => new PersonAddressBuilder(person);
    public static implicit operator Person(PersonBuilder pb)
    {
        return pb.person;
    }
}

