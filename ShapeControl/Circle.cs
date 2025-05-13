namespace ShapeControl;

public class Circle(string name, string color, int radius) : Shape(name, color)
{
    private double Radius { get; set; } = radius;

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}