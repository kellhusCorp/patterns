using VirtualProxy.Interfaces;

namespace VirtualProxy;

public class Bitmap : IBitmap
{
    private readonly string filename;

    public Bitmap(string filename)
    {
        this.filename = filename;
        Console.WriteLine($"Загрузка картинки из файла {filename}");
    }

    public void Draw()
    {
        Console.WriteLine($"Рисуем картинку {filename}");    
    }
}