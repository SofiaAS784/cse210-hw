public class Fraction
{
    private int _top;
    private int _bottom;
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public int GetTopNumber()
    {
        return _top;
    }
    public int GetBottomNumber()
    {
        return _bottom;
    }
    public void SetTopNumber(int top)
    {
        _top = top;
    }
    public void SetBottomNumber(int bottom)
    {
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue()
    {
        double decimalNumber = (double)_top / (double)_bottom;
        return decimalNumber;
    }
}