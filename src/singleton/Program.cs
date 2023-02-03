using singleton.AmbientContext;

namespace singleton;

public class Program
{
    public static void Main(string[] args)
    {
        var house = new Building();

        using (new BuildingContext(3333))
        {
            house._walls.Add(new Wall(new Point(0, 0), new Point(1233, 0)));
            house._walls.Add(new Wall(new Point(0, 0), new Point(100, 0)));
        }
        using (new BuildingContext(8000))
        {
            house._walls.Add(new Wall(new Point(0, 0), new Point(9999, 0)));
            house._walls.Add(new Wall(new Point(0, 0), new Point(0, 0)));
        }

        using (new BuildingContext(2890))
        {
            house._walls.Add(new Wall(new Point(600, 0), new Point(9999, 0)));
        }
    }
}