namespace Bridge.Renderers;

internal class RasterRenderer : IRenderer
{
    public void RenderCircle(float radius)
    {
        Console.WriteLine($"Рисуем пиксели для круга радиусом = {radius}");
    }
}