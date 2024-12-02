namespace Labb3_Polymorphism;
/// <summary>
/// A Ciecle sub-class that inherent from Geometry class. 
/// </summary>
public class Circle : Geometry
{
    private double _radius;
    
    //Added an argumentexception for setting the radius to less or equal to 0.
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

    public Circle()
    {
        Radius = 4; 
    }

    public Circle(double radius)
    {
        _radius = radius;
    }
    /// <summary>
    /// A metohod for calculating area of the cirkle that overrides the virtual area method in the parent class.
    /// </summary>
    /// <returns>area of circle</returns>
    public override double Area()
    {
        double area = Math.PI * Math.Pow(_radius, 2);
        return area; 
    }
}