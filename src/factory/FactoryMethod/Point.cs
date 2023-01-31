namespace factory.FactoryMethod;
public class Point
{
    private double x, y;
    private Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    public override string ToString()
    {
        return $"{nameof(x)}: {x}, {nameof(y)}: {y}$";
    }
    public static Point Origin => new Point(0, 0);
    public static Point Origin2= new Point(0, 0); // better
    
    // public static PointFactory Factory => new PointFactory();
    public class Factory
    {
        public static Point NewCartesianPoint(double x, double y)
        {
            return new Point(x, y);
        }

        public static Point NewPolarPoint(double rho, double theta)
        {
            return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
        }
    }
}