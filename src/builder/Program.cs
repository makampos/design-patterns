public partial class Program
{
    public static void Main(string[] args)
    {
        var builder = new HtmlBuilder("ul");
        builder.AddChild("li","hello");
        builder.AddChild("li","world");
        Console.WriteLine(builder.ToString());
    }
}


