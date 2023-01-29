namespace factory;

public class Point
{
    private double x, y;
    /// <summary>
    /// Initializes a new instance of the <see cref="Point"/> class.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="system"></param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public Point(double a, double b, CordinateSystem system = CordinateSystem.Cartesian)
    {
        switch (system)
        {
            case  CordinateSystem.Cartesian:
                x = a;
                y = b;
                break;
            case CordinateSystem.Polar:
                x = a * Math.Cos(b);
                y = a * Math.Sin(b);
                break;
            default:             
                throw new ArgumentOutOfRangeException(nameof(system), system, null);
        }
    }
}