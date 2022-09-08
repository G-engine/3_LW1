namespace lw1;

public class Figure
{
    private Point p1;
    private Point p2;
    private Point p3;
    private Point? p4;
    private Point? p5;

    public string name { get; set; } = String.Empty;
    
    public Figure(Point p1, Point p2, Point p3)
    {
        this.p1 = p1;
        this.p2 = p2;
        this.p3 = p3;
    }
    
    public Figure(Point p1, Point p2, Point p3, Point p4)
    {
        this.p1 = p1;
        this.p2 = p2;
        this.p3 = p3;
        this.p4 = p4;
    }
    
    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
    {
        this.p1 = p1;
        this.p2 = p2;
        this.p3 = p3;
        this.p4 = p4;
        this.p5 = p5;
    }

    public double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(A.coord1 - B.coord1, 2) + Math.Pow(A.coord2 - B.coord2, 2));
    }

    public void PerimeterCalculator()
    {
        double perimeter = LengthSide(p1, p2) + LengthSide(p2, p3);
        if (p4 == null)
            perimeter += LengthSide(p3, p1);
        else
        {
            perimeter += LengthSide(p3, p4);
            if (p5 == null)
                perimeter += LengthSide(p4, p1);
            else
                perimeter += LengthSide(p4, p5) + LengthSide(p5,p1);
        }
        Console.WriteLine($"Perimeter = {perimeter}");
    }

}