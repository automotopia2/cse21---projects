using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        Square square1 = new Square("Blue", 2);
        shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle("Green", 4, 2);
        shapes.Add(rectangle1);

        Circle circle1 = new Circle("Red", 6);
        shapes.Add(circle1);


        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"Area: {area}\nColor: {color}\n");
        }
        
    }
}