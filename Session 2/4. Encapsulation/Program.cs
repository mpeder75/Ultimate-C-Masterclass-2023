
// instanser af clkasses oprettes
var myRectangle1 = new Rectangle(5, 5);
var myRectangle2 = new Rectangle(5, 10);
var calculator = new ShapesMessurementsCalculation();


// her printes metodernes beregninger
Console.WriteLine($"The area is: {calculator.CalculateRectangleArea(myRectangle1)}");
Console.WriteLine($"Circumference is: {calculator.CalculateRectangleCircumference(myRectangle1)}");

Console.WriteLine($"The area is: {calculator.CalculateRectangleArea(myRectangle2)}");
Console.WriteLine($"Circumference is: {calculator.CalculateRectangleCircumference(myRectangle2)}");


class Rectangle
{
    public int Width;
    public int Height;

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

}


// Her benyttes encapsulation til at indkapsle de metoder der er, i en class for sig selv
class ShapesMessurementsCalculation
{
    // method der beregner omfang - HUSK metoderne skal tage imod et objekt som parameter
    public int CalculateRectangleCircumference(Rectangle rectangle)
    {
        return 2 * rectangle.Width + 2 * rectangle.Height;
    }

    // method der beregner arealet - HUSK metoderne skal tage imod et objekt som parameter
    public int CalculateRectangleArea(Rectangle rectangle)
    {
        return rectangle.Width * rectangle.Height;
    }

}

