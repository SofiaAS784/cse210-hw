using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 12.5);
        Rectangle rectangle = new Rectangle("blue", 14, 22);
        Circle circle = new Circle("yellow", 7);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
            Console.WriteLine("");
        }
    }
}