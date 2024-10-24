namespace Labb3_Polymorphism;

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(10, 5);
        Square square = new Square(5);

        var geometries = new List<Geometry>() {circle, rectangle, square};
        //Do new list that is ordered by ascending areas. 
        List<Geometry> sortedGeometries = geometries.OrderBy(o => o.Area()).ToList();
        
         foreach (var geometry in sortedGeometries)
         {
             Console.WriteLine($"Area of {geometry.GetType().Name} is {geometry.Area():N}");    
         }
    }
}