public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructor without parameters, initializes fraction to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor with one parameter, initializes fraction to top/1
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor with two parameters, initializes fraction to top/bottom
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter for the top number
    public int GetTop()
    {
        return _top;
    }

    // Setter for the top number
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter for the bottom number
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for the bottom number
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Method to return the fraction in string format
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Method to return the fraction in decimal format
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
