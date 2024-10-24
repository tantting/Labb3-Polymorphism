namespace Labb3_Polymorphism;

class Program
{
    static void Main(string[] args)
    {
        //create instanses of the classes Circle, Rectangle and Square. 
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(10, 5);
        Square square = new Square(5);
        
        //Since the classes Circle, Square and Rectangle are all subclassses to the base-class Geometries (variants of
        //Geometries) I can treat the different objects as Geometry-objects and add them all to a List of the Geometry
        //class instanses.   
        var geometries = new List<Geometry>() {circle, rectangle, square};
        
        
        //A nested for-loop for sorting the List of all the Geometry instanses (by ascending areas). It moves the object
        //with the smallest area at every comparison to the i-position. After the first outer-loop, the classs instans
        //with the smallest area will be at position i.....
        //Before doing this, the Geometry class was an abstract class. I needed to change that, in order to create a
        //general Geometry object (geomwetry) to store objects in while swaping object orders.  
        for (int i = 0; i < geometries.Count-1; i++)
        {
            for (int y = i + 1; y < geometries.Count; y++)
            {
                Geometry geometrySwap = new Geometry();

                if (geometries[y].Area() < geometries[i].Area())
                {
                    geometrySwap = geometries[i];
                    geometries[i] = geometries[y];
                    geometries[y] = geometrySwap;
                }
            }
        }

        foreach (var geometry in geometries)
        {
           Console.WriteLine($"The area of the {geometry.GetType().Name.ToLower()} is {geometry.Area():N}"); 
        }
        
        //Tested at first this way of sorting the list - using the OrderBy-method. For fun, I also ended up doing the 
        //for loop above. 
        /*
        List<Geometry> sortedGeometries = geometries.OrderBy(o => o.Area()).ToList();

         foreach (var geometry in sortedGeometries)
         {
             Console.WriteLine($"Area of {geometry.GetType().Name} is {geometry.Area():N}");
         }
         */
    }
}