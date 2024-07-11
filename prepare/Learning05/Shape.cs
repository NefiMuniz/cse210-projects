using System;

public abstract class Shape
{
    // Member variable to store the color of the shape
    private string _color;

    // Constructor to set the color of the shape
    public Shape(string color)
    {
        _color = color;
    }

    // Getter and Setter for the color property
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    // Virtual method to compute the area of the shape
    public abstract double GetArea();
}
