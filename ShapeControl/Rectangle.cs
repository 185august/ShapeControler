namespace ShapeControl;

public class Rectangle(string name, string color, double height, double width)
    : Shape(name, color)
{
    private double Width { get; set; } = width;
    private double Height { get; set; } = height;

    public override double CalculateArea()
    {
        return Height * Width;
    }
}