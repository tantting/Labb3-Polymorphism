using System.Formats.Asn1;

namespace Labb3_Polymorphism;
/// <summary>
/// A abstract parent class with a abstract method for calculation the area. Using abstract (or virtual) and override is
/// also called dynamic polymorphism and mean that the response to a function will be determined at runtime. The area of
/// a circle will always be calculated in the Circle class. If I would not use override but just add one Area() method to
/// Geometry and one to the subclasses, the area will be calc differently depending on how I treat my objects. When calling
/// circle.Area() it will be calc in the Circle class but when calling the Area() method from the the same object but
/// now part of list of Geometries (List<Geometry> geomertries), the area will be calculated in the base class Geometry
/// instead. The response is  determined in compile time and this is called static polymorphism. 
/// </summary>
public abstract class Geometry
{
    public abstract double Area();
}