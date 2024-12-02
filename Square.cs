using System.Runtime.CompilerServices;

namespace Labb3_Polymorphism;

public class Square : Geometry
{
    private double _side;
    
    public double Side
    {
        get { return _side; }
        set {
            if (value > 0)
            {
                _side = value;
            }
            else
            {
                throw new ArgumentException("The parameter must be larger than 0."); 
            }   
        }
    }

    public Square()
    {
        Side = 4;
    }

    public Square(double side)
    {
        Side = side; 
    }
    /// <summary>
    /// A metohod for calculating the area of the square that overrides the virtual area method in the parent class.
    /// </summary>
    /// <returns>area of square (double)</returns>
    public override double Area()
    {
        double area = Math.Pow(_side, 2);
        return area; 
    }
}