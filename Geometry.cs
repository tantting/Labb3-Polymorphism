using System.Formats.Asn1;

namespace Labb3_Polymorphism;
/// <summary>
/// Aa parent class with one virtual method for calculation the area. Virtual means that the method can be
/// redefined in a child class through override. Using virtual (or abstract) and override is also called dynamic
/// polymorphism and mean that the response to a function will be determined at runtime. The area of a circle will
/// always be calculated in the Circle class. If I would not use override but just add one Area() method to Geometry
/// and one to the subclasses, the area will be calc differently depending on how I treat my objects. When calling
/// circle.Area() it will be calc in the Circle class but when calling the Area() method from the the same object but
/// now part of list of Geometries (List<Geometry> geomertries), the area will be calculated in the base class Geometry
/// instead. The response is  determined in compile time and this is called static polymorphism. 
/// </summary>
public abstract class Geometry
{
    public abstract double Area();
}