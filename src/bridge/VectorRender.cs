namespace bridge;

internal partial class Program
{
    public class VectorRender : IRenderer
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"Drawing a circle of radius {radius}");
        }
    }
}