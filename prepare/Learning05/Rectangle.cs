using System;

public class Rectangle : Shape
{
    // Member variables to store the length and width of the rectangle
    private double _length;
    private double _width;

    // Constructor to set the color, length, and width of the rectangle
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    // Override the GetArea method to compute the area of the rectangle
    public override double GetArea()
    {
        return _length * _width;
    }
}
