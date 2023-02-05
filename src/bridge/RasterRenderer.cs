namespace bridge;

internal partial class Program
{
    public class RasterRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"Drawing pixels for a circle of radius {radius}");
        }
    }
}