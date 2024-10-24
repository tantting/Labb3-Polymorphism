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

    public Square(double side)
    {
        Side = side; 
    }

    public override double Area()
    {
        double area = Math.Pow(_side, 2);
        return area; 
    }
}