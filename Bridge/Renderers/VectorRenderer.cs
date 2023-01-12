namespace Bridge.Renderers;

internal class VectorRenderer : IRenderer
{
    public void RenderCircle(float radius)
    {
        Console.WriteLine($"Рисуем круг радиуса = {radius}");
    }
}