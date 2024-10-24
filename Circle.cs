namespace Labb3_Polymorphism;

public class Circle : Geometry
{
    private double _radius;

    public double Radius
    {
        get { return _radius; }
        set
        {
            if (value > 0)
            {
                _radius = value;
            }
            else
            {
                throw new ArgumentException("Radius needs to be larger than 0!"); 
            }   
        }
    }

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double Area()
    {
        double area = Math.PI * Math.Pow(_radius, 2);
        return area; 
    }
}