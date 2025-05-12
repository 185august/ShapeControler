namespace ShapeControl;

public abstract class Form
{
    protected string Name { get; }
    protected string Color { get; }

    protected Form(string name, string color)
    {
        Name = name;
        Color = color;
    }
    
    public abstract double CalulateArea();
}