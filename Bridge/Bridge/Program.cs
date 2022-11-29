// shape: square, circle, triangle
// renderer: raster, vector 

using Autofac;
using Bridge.Renderers;
using Bridge.Shapes;

namespace Bridge;

static class Program
{
    static void Main()
    {
        NativeMethod();

        MethodWithDi();

        Console.ReadKey();
    }

    static void NativeMethod()
    {
        var raster = new RasterRenderer();
        var vector = new VectorRenderer();
        var circle = new Circle(raster, 5);
        
        circle.Draw();
        circle.Resize(1.5f);
        circle.Draw();
    }

    static void MethodWithDi()
    {
        var cb = new ContainerBuilder();

        cb.RegisterType<VectorRenderer>()
            .As<IRenderer>();

        cb.Register((c, p) => new Circle(
            c.Resolve<IRenderer>(),
            p.Positional<float>(0)
        ));

        using (var c = cb.Build())
        {
            var circle = c.Resolve<Circle>(
                new PositionalParameter(0, 5.0f)
            );
            
            circle.Draw();
            circle.Resize(5);
            circle.Draw();
        }
    }
}