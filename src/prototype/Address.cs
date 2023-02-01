namespace prototype;

public class Address : ICloneable
{
    public string StreetName;
    public int HouseNumber;

    public Address(string streetName, int houseNumber)
    {
        StreetName = streetName ?? throw new ArgumentNullException(nameof(streetName));
        HouseNumber = houseNumber;
    }
    
    public override string ToString()
    {
        return $"{nameof(StreetName)}: {StreetName}, {nameof(HouseNumber)}: {HouseNumber}";
    }

    public object Clone()
    {
        return new Address(StreetName, HouseNumber);
    }
}