namespace Labb3_Polymorphism;
/// <summary>
/// A Rectange sub-class/child that inherent from Geometry class. 
/// </summary>
public class Rectangle : Geometry
{
    private double _base;
    private double _height;
    
    //Add a argumentexception for setting the Base or Height less or equal to 0.
    public double Base
    {
        get { return _base; }
        set {
            if (value > 0)
            {
                _base = value;
            }
            else
            {
                throw new ArgumentException("Base must be larger than 0."); 
            }   
        }
    }
    public double Height
    {
        get { return _height; }
        set {
            if (value > 0)
            {
                _height = value;
            }
            else
            {
                throw new ArgumentException("Height must be larger than 0."); 
            }   
        }
    }

    public Rectangle(double rBase, double rHeight)
    {
        Base = rBase;
        Height = rHeight;
    }
    /// <summary>
    /// A metohod for calculating area of the rectangle that overrides the virtual area method in the parent class.
    /// </summary>
    /// <returns>areaof rectangle (double)</returns>
    public override double Area()
    {
        double area = _base * _height;
        return area; 
    }
}