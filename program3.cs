namespace lw1;

public class Program3
{
    public static void Pr3()
    {
        Figure square = new Figure(new Point(0, 0), new Point(2, 0), new Point(2, 2), new Point(0, 2));
        square.name = Console.ReadLine();

        Console.WriteLine($"Figures name: {square.name}");
        square.PerimeterCalculator();
    }
}