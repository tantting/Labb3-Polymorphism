using System.Collections.Concurrent;
using System.Diagnostics;

namespace Labb3_Polymorphism;

class Program
{
    static void Main(string[] args)
    {
        //create instanses of the classes with the empty constructor where fields are pre-set. 
        Circle circle = new Circle();
        Rectangle rectangle = new Rectangle();
        Square square = new Square();
        
        //create instanses of the classes Circle, Rectangle and Square where I set values myself.
        Circle circleSettingValues = new Circle(5);
        Rectangle rectangleSettingValues = new Rectangle(10, 5);
        Square squareSettingValues = new Square(5);
        
        //Since the classes Circle, Square and Rectangle are all subclassses to the base-class Geometries (variants of
        //Geometries) I can treat the different objects as Geometry-objects and add them all to a List of the Geometry
        //class instanses.   
        var geometries = new List<Geometry>() {circle, rectangle, 
            square};
        var geometriesSettingValues = new List<Geometry>() {circleSettingValues, rectangleSettingValues, 
            squareSettingValues};
        
        //Create a sorted list, using OrderBy and sorting by area.
        List<Geometry> sortedGeometries = geometries.OrderBy(o => o.Area()).ToList();
        List<Geometry> sortedGeometriesOwnValues = geometriesSettingValues.OrderBy(o => o.Area()).ToList();
        
        foreach (var geometry in sortedGeometries)
        {
            Console.WriteLine($"The area of {geometry.GetType().Name.ToLower()} is {geometry.Area():N}");
        }

        Console.WriteLine("----------");

        foreach (var geometry in sortedGeometriesOwnValues)
        {
            Console.WriteLine($"The area of {geometry.GetType().Name.ToLower()} is {geometry.Area():N}");
        }
        
        //For fun, I also made a nested for-loop for sorting the List of all the Geometry instanses (by ascending areas)
        //instead of sing OrderBy (just for fun). It moves the object with the smallest area at every comparison to the
        //i-position. After the first outer-loop, the classs instance with the smallest area will be at position i.....
        //To be able and run this,the Geometry class cannot be an abstract class since I need to create a
        //general Geometry object (geomwetry) to store objects in while swapping object orders.  
        /*
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
        */
         
    }
}