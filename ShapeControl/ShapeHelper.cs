namespace ShapeControl;

public static class ShapeHelper
{
    public static void ViewAll(List<Shape> shapes)
    {
        foreach (var shape in shapes)
        {
            Console.WriteLine($"{shape.Name}, {shape.Color}, {shape.CalculateArea():F2}");
        }
    }

    public static double GetTotalArea(List<Shape> shapes)
    {
        var totalArea = 0.0;
        foreach (var shape in shapes)
        {
            totalArea += shape.CalculateArea();
        }
        return totalArea;
    }

    public static void OrderByArea(List<Shape> shapes)
    {
        shapes.Sort((x, y) => x.CalculateArea().CompareTo(y.CalculateArea()));
        ViewAll(shapes);
    }

    public static void OrderByColor(List<Shape> shapes)
    {
        shapes.Sort((x, y) => string.Compare(x.Color, y.Color, StringComparison.Ordinal));
        ViewAll(shapes);
    }
}