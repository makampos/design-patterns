namespace prototype;

public class Person : ICloneable
{
    public string[] Names;
    public Address Address;


    public Person(string[] names, Address address)
    {
        Names = names ?? throw new ArgumentNullException(nameof(names));
        Address = address ?? throw new ArgumentNullException(nameof(address));
    }
    
    public override string ToString()
    {
        return $"{nameof(Names)}: {string.Join(" ", Names)}, {nameof(Address)}: {Address}";
    }

    public object Clone()
    {
        return new Person(Names, (Address) Address.Clone());
    }
}