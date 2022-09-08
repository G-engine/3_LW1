using lw1;

namespace tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestRectangle()
    {
        Rectangle rec1 = new Rectangle(45.6, 0);

        Assert.AreEqual(0, rec1.AreaCalculator());
        Assert.AreEqual(0, rec1.PerimeterCalculator());
        Assert.AreEqual(0, rec1.Area);
        Assert.AreEqual(0, rec1.Perimeter);

        Rectangle rec2 = new Rectangle(34.33, 5.01);

        Assert.AreEqual(34.33 * 5.01, rec2.AreaCalculator());
        Assert.AreEqual((34.33 + 5.01) * 2, rec2.PerimeterCalculator());
        Assert.AreEqual(34.33 * 5.01, rec2.Area);
        Assert.AreEqual((34.33 + 5.01) * 2, rec2.Perimeter);
    }

    [TestMethod]
    public void TestFigure()
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(3, 0);
        Point p3 = new Point(3, 3);
        Point p4 = new Point(0, 3);
        Point p5 = new Point(5, 5);
        
        Figure square1 = new Figure(p1, p2, p3, p4);
        Assert.AreEqual(3, square1.LengthSide(p1,p2));
        square1.name = "kvadrat";
        Assert.IsNotNull(square1.name);
        
        Figure square2 = new Figure(p1, p2, p3);
        Figure square3 = new Figure(p1, p2, p3, p4, p5);
        
        square1.PerimeterCalculator();
        square2.PerimeterCalculator();
        square3.PerimeterCalculator();
    }
}

