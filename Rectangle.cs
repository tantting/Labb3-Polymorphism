namespace Labb3_Polymorphism;

public class Rectangle : Geometry
{
    private double _base;
    private double _height;

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

    public override double Area()
    {
        double area = _base * _height;
        return area; 
    }
}