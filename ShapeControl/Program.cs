using ShapeControl;

var listOfShapes = new List<Shape>()
{
  new Circle("Circle", "Red", 10),
  new Circle("Circle2", "Blue", 20),
  new Rectangle("Rectangle", "Yellow", 10, 10),
  new Rectangle("Rectangle2", "Blue", 20, 20),
  new Triangle("Triangle", "Red", 10, 10),
  new Triangle("Triangle2", "Yellow", 20, 20)
};
Console.WriteLine("List of shapes:");
ShapeHelper.ViewAll(listOfShapes);
Console.WriteLine($"\nTotal area: {ShapeHelper.GetTotalArea(listOfShapes):F2}");
Console.WriteLine($"\nOrder by area:");
ShapeHelper.OrderByArea(listOfShapes);
Console.WriteLine($"\nOrder by color:");
ShapeHelper.OrderByColor(listOfShapes);
return;

