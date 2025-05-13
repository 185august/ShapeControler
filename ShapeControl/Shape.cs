namespace ShapeControl;

public abstract class Shape(string name, string color)
{
    public string Name { get; private set; } = name;
    public string Color { get; private set; } = color;
    
    public abstract double CalculateArea();
}