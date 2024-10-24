using System.Formats.Asn1;

namespace Labb3_Polymorphism;
/// <summary>
/// Aa parent class with one virtual method for calculation the area. Virtual means that the method can be
/// redefined in a child class through override. Using virtual (or abstract) and override is also called dynamic
/// polymorphism mean that the response to a function will be determined at runtime. The area of a circle will always be
/// calculated in the Circle class. If I would instead just adding one Area() method to Geometry and the subclasses,
/// the area will be calc differently depending on how I treat my objects (when calling circle.Area() it will be calc in
/// the Circle class but when calling the Area(9 method from the the same object but now part of list of Geometries
/// (List<Geometry> geomertries), the area will be calculated in the base class Geometry instead (the response is then
/// determined in compile time and this is called static polymorphism).
///
/// At first, this was an abstract class instead, but I needed create an instance of this class at one point
/// (se nested for-loop for sorting list). Hence, I Changed it to virtual.  
/// </summary>
public class Geometry
{
    public virtual double Area()
    {
        Console.WriteLine("Denna arean är 0 då det inte är en satt geometri");
        double area = 0;
        return area; 
    }
}