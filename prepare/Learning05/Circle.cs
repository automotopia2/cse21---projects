using System;

class Circle : Shape
{
   private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

   public override double GetArea()
    {
        return Math.PI * 0.5 * _radius * _radius;
    }
}    