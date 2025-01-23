public class Fraction
{
    private int _top;
    private int _bottom;


    // Constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top =wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    
    // Getters and Setters

    public string GetFraction()
    {
        string given = $"{_top}/{_bottom}";
        return given;
    }

    public double GetDecimal()
    {
        return (double)_top/ _bottom;
    }
}