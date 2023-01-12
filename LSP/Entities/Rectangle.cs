namespace LSP.Entities;

public class Rectangle
{
    public virtual int Width { get; set; }

    public virtual int Height { get; set; }

    public Rectangle() { }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public bool IsSquare => Width == Height;

    public int Area => Width * Height;
}