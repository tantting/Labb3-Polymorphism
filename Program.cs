namespace Labb3_Polymorphism;

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(10, 5);
        Square square = new Square(5);

        var geometries = new List<Geometry>() {circle, rectangle, square};
        //Tested to ways of sorting the list. 1st, I did it using OrderBy-method. Secondly, I did the nested for-loop 
        //below. 
        /*
        List<Geometry> sortedGeometries = geometries.OrderBy(o => o.Area()).ToList();
        
         foreach (var geometry in sortedGeometries)
         {
             Console.WriteLine($"Area of {geometry.GetType().Name} is {geometry.Area():N}");    
         }
         */
        
        //A nested for-loop for sorting the List of all the Geometry instanses. It moves the object with the
        //smallest area at every comparison to the i-position. After the first outer-loop, the classs instans witht the
        //smallest area will be at position i.....
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
           Console.WriteLine($"Area of {geometry.GetType().Name} is {geometry.Area():N}"); 
        }
    }
}