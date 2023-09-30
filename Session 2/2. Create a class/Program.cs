

/* Her oprettes flere instancer/objekter af class Rectangle, gemt i 2 variabler */
var myRectangle1 = new Rectangle(5,5);
var myRectangle2 = new Rectangle(5,10);


Console.WriteLine($"{myRectangle1.Height}");
Console.WriteLine($"{myRectangle1.Width}");


/* Class Rectangle oprettes med 2 public fields */
class Rectangle
{
    // Field er variabler der tilhøre et objekt i en class
    public int Width;
    public int Height;

    // Constructor
    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

 }


