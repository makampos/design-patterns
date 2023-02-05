using System.Collections.ObjectModel;
using MoreLinq.Extensions;

namespace adapter;

public class Program
{
    public class Point
    {
        public int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    
    public class Line
    {
        public Point start, end;
        public Line(Point start, Point end)
        {
            this.start = start;
            this.end = end;
        }
    }
    
    public class VectorObject : List<Line>
    {
        
    }
    
    public class VectorRectangle : VectorObject
    {
        public VectorRectangle(int x, int y, int width, int height)
        {
            Add(new Line(new Point(x, y), new Point(x + width, y)));
            Add(new Line(new Point(x + width, y), new Point(x + width, y + height)));
            Add(new Line(new Point(x, y), new Point(x, y + height)));
            Add(new Line(new Point(x, y + height), new Point(x + width, y + height)));
        }
    }
    
    public static void DrawPoint(Point p)
    {
        Console.WriteLine(".");
    }
    
    private static readonly List<VectorObject> vectorObjects = new List<VectorObject>
    {
        new VectorRectangle(1, 1, 10, 10),
        new VectorRectangle(3, 3, 6, 6)
    };

    public class LineToPointAdapter : Collection<Point>
    {
        private static int count;
        static Dictionary<int, List<Point>> cache = 
            new Dictionary<int, List<Point>>();
        public LineToPointAdapter(Line line)
        {
            Console.WriteLine($"{++count}: Generating points for line [{line.start.x},{line.start.y}]-[{line.end.x},{line.end.y}]");
            int left = Math.Min(line.start.x, line.end.x);
            int right = Math.Max(line.start.x, line.end.x);
            int top = Math.Min(line.start.y, line.end.y);
            int bottom = Math.Max(line.start.y, line.end.y);
            int dx = right - left;
            int dy = line.end.y - line.start.y;
            if (dx == 0)
            {
                for (int y = top; y <= bottom; ++y)
                {
                    Add(new Point(left, y));
                }
            }
            else if (dy == 0)
            {
                for (int x = left; x <= right; ++x)
                {
                    Add(new Point(x, top));
                }
            }
        }
    }

    public static void Main(string[] args)
    {
        foreach (var vo in vectorObjects)
        {
            foreach (var line in vo)
            {
                var adapter = new LineToPointAdapter(line);
                adapter.ForEach(DrawPoint);
            }
        }
    }
}