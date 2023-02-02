namespace singleton.Monostate;

public class CEO
{
    private static string name;
    private static int age;

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Age
    {
        get => age;
        set => age = value;
    }

    public override string ToString()
    {
        return  $"CEO {nameof(Name)}: {Name}, {nameof(Age)}: {Age}";
    }
}