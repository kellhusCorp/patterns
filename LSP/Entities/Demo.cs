namespace LSP.Entities;

public class Demo
{
    public static void UseIt(Rectangle r)
    {
        int width = r.Width;
        r.Height = 10;
        Console.WriteLine($"Ожидаем площадь = {10 * width}, " +
                          $"получаем {r.Area}");
    }
}