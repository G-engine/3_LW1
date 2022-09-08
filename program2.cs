namespace lw1;

internal class Program2
{
    public static void Pr2()
    {
        double side1 = double.Parse(Console.ReadLine());
        double side2 = double.Parse(Console.ReadLine());
        
        Rectangle rec = new Rectangle(side1, side2);
        
        Console.WriteLine($"\nPerimeter = {rec.PerimeterCalculator()}, Area = {rec.AreaCalculator()}");
    }
}
