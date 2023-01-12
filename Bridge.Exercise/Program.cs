using Bridge.Exercise.Renderers;
using Bridge.Exercise.Shapes;

#region Problem description

namespace Coding.Exercise
{
    // Вам дан пример иерархии наследования которая, к сожалению, приводит к дупликации сродни скалярному произведению, что не есть хорошо.
    //
    // Я хочу чтобы вы отрефакторили эту иерархию, дав базовому классу Shape  конструктор, который принимает аргумент типа IRenderer  определенный как
    //
    // interface IRenderer
    // {
    //     string WhatToRenderAs { get; }
    // }
    // Также нужно реализовать класссы VectorRenderer  и RasterRenderer. Каждый наследник абстрактного класса Shape  должен обладать конструктором,
    // который принимает IRenderer  так чтобы у каждого созданного объекта вызов ToString()  работал правильно, например,
    //
    // new Triangle(new RasterRenderer()).ToString() // возвращает "Drawing Triangle as pixels" 
    
    public abstract class Shape
    {
        public string Name { get; set; }
    }

    public class Triangle : Shape
    {
        public Triangle() => Name = "Triangle";
    }

    public class Square : Shape
    {
        public Square() => Name = "Square";
    }

    public class VectorSquare : Square
    {
        public override string ToString() => "Drawing {Name} as lines";
    }

    public class RasterSquare : Square
    {
        public override string ToString() => "Drawing {Name} as pixels";
    }

    // imagine VectorTriangle and RasterTriangle are here too
}

#endregion

internal static class Program
{
    private static void Main()
    {
        Console.WriteLine(new Triangle(new RasterRenderer()).ToString()); // возвращает "Drawing Triangle as pixels");
        Console.WriteLine(new Triangle(new VectorRenderer()).ToString()); // возвращает "Drawing Triangle as lines");
        Console.WriteLine(new Square(new RasterRenderer()).ToString()); // возвращает "Drawing Circle as pixels");
        Console.WriteLine(new Square(new VectorRenderer()).ToString()); // возвращает "Drawing Circle as lines");

        Shape shape = new Triangle(new RasterRenderer());

        Console.WriteLine(shape);
        
        Console.ReadKey();
    }
}