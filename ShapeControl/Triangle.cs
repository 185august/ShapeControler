namespace ShapeControl;

public class Triangle(string name, string color, double @base, double height)
    : Shape(name, color)
{
    
    private double Height { get; } = IsNegative(height);
    private double Base { get; } = IsNegative(@base);

    public override double CalculateArea() => 
        (Base * Height) / 2;

    private static double IsNegative(double num)
    {
        if (!(num < 0)) return num;
        throw new ArgumentException("Negative numbers are not allowed");
    }
}