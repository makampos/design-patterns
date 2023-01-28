namespace builder.Facade;

public class Person
{
    // address
    public string StreetAdress, Postcode, City;
    
    // employment
    public string CompanyName, Position;
    public int AnnualIncome;
    
    public override string ToString()
    {
        return 
               $"{nameof(StreetAdress)}: {StreetAdress}, " +
               $"{nameof(Postcode)}: {Postcode}," +
               $" {nameof(City)}: {City}," +
               $" {nameof(CompanyName)}: {CompanyName}," +
               $" {nameof(Position)}:" + $" {Position}," +
               $" {nameof(AnnualIncome)}: {AnnualIncome}";
    }
    
}