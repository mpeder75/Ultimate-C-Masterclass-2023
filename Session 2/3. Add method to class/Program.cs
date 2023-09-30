// instanser oprettes
var myRectangle1 = new Rectangle(5, 5);
var myRectangle2 = new Rectangle(5, 10);


// her printes metodernes beregninger
Console.WriteLine($"The area is: {myRectangle1.CalculateArea()}");
Console.WriteLine($"Circumference is: {myRectangle1.CalculateCircumference()}");

Console.WriteLine($"The area is: {myRectangle2.CalculateArea()}");
Console.WriteLine($"Circumference is: {myRectangle2.CalculateCircumference()}");


class Rectangle
{
    public int Width;
    public int Height;

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    // method der beregner omfang
    public int CalculateCircumference()
    {
        return 2 * Width + 2 * Height;
    }

    // method der beregner arealet
    public int CalculateArea()
    {
        return Width * Height;
    }

}