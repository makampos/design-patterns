using prototype.BetterSolution;

public class Program
{
    public static void Main(string[] args)
    {
        var jhon = new Employee();
           jhon.Names = new[] {"Jhon", "Smith"};
           jhon.Address = new Address
           {
               HouseNumber = 123,
               StreetName = "Ernani do Amaral"
           };
           jhon.Salary = 124000;

           var copy = jhon.DeepCopy();
              copy.Names[1] = "Thompson";
              copy.Address.HouseNumber++;
              copy.Salary = 200000;
            
              Console.WriteLine(jhon);
              Console.WriteLine(copy);
    }
}