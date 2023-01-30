namespace factory.AsynchronousFactoryMethod;

public class Foo
{
    private Foo()
    {
         
    }
    private async Task<Foo> InitiAsync()
    {
         await Task.Delay(1000);
         return this;
    }
    
    public static Task<Foo> CreateAsync()
    {
        var result = new Foo();
        return result.InitiAsync();
    }
}