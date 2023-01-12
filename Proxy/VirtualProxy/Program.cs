using VirtualProxy.Interfaces;

namespace VirtualProxy;

public static class Program
{
    public static void DrawImage(IBitmap image)
    {
        Console.WriteLine("Подготовка к отрисовке картинки");
        image.Draw();
        Console.WriteLine("Изображение отрисовано");
    }
    
    public static void Main()
    {
        var image = new LazyBitmap("image.jpg");
        DrawImage(image);
    }
}