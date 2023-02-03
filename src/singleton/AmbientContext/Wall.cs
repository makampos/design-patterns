namespace singleton.AmbientContext;
public class Wall
{
    public Point Start, End;
    public int Height;

    public Wall(Point start, Point end)
    {
        Start = start;
        End = end;
        Height = BuildingContext.Current.WallHeight;
    }
    
    public override String ToString()
    {
        return $"Wall from {Start} to {End} with height {Height}";
    }
}