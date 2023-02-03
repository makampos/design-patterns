namespace singleton.AmbientContext;

public sealed class BuildingContext : IDisposable
{
    public int WallHeight;
    private static Stack<BuildingContext> stack = new Stack<BuildingContext>();

    public BuildingContext()
    {
        stack.Push(new BuildingContext(0));
    }

    public BuildingContext(int wallHeight)
    {
        WallHeight = wallHeight;
        stack.Push(this);
    }

    public static BuildingContext Current => stack.Peek();
    
    public void Dispose()
    {
        if (stack.Count > 1)
            stack.Pop();
    }
}