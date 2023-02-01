namespace prototype.OldSolution;

[Serializable]
public class Person 
{
    public string[] Names;
    public Address Address;
    public Person(Person other)
    {
        Names = other.Names;
        Address = new Address(other.Address);
    }
    public Person(string[] names, Address address)
    {
        Names = names ?? throw new ArgumentNullException(nameof(names));
        Address = address ?? throw new ArgumentNullException(nameof(address));
    }
    public override string ToString()
    {
        return $"{nameof(Names)}: {string.Join(" ", Names)}, {nameof(Address)}: {Address}";
    }
}