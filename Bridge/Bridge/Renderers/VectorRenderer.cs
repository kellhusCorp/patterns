namespace Bridge.Renderers;

internal class VectorRenderer : IRenderer
{
    public void RenderCircle(float radius)
    {
        Console.WriteLine($"Drawing circle of radius {radius}");
    }
}