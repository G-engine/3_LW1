namespace lw1;

public class Rectangle
{
    private double side1;
    private double side2;

    public Rectangle(double sideA, double sideB)
    {
        side1 = sideA;
        side2 = sideB;
    }

    public double AreaCalculator()
    {
        return side1 * side2;
    }

    public double PerimeterCalculator()
    {
        if (side1 == 0 || side2 == 0)
            return 0;
        return (side1 + side2) * 2;
    }

    public double Area
    {
        get
        {
            return side1 * side2;
        }
    }

    public double Perimeter
    {
        get
        {
            if (side1 == 0 || side2 == 0)
                return 0;
            return (side1 + side2) * 2;
        }
    }
}