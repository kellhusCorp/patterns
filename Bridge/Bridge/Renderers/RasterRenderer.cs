namespace Bridge.Renderers;

internal class RasterRenderer : IRenderer
{
    public void RenderCircle(float radius)
    {
        Console.WriteLine($"Drawing pixels for circle of radius {radius}");
    }
}