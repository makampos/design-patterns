namespace builder.Fluent;

public class Person
{
    public string Name = null!;
    public string Position = null!;
    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
    }
    public static Builder New  => new Builder();
}