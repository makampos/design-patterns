using Autofac;

namespace bridge;

internal partial class Program
{
    public static void Main(string [] args)
    {
        // var circle = new Circle(new RasterRenderer(), 5);
        // circle.Draw();
        // circle.Resize(2);
        // circle.Draw();

        var cb = new ContainerBuilder();
        cb.RegisterType<VectorRender>().As<IRenderer>().SingleInstance();
        cb.Register((c, p) =>
            new Circle(c.Resolve<IRenderer>(), p.Positional<float>(0)));
        using (var c = cb.Build())
        {
            var circle = c.Resolve<Circle>(
                new PositionalParameter(0, 5f));
            circle.Draw();
            circle.Resize(2);
            circle.Draw();
        }
    }
}