//todo Hvis method KUN indeholder ET statement eller ET expression
//todo Kan Expression-bodied methods benyttes, for at gøre koden kortere

//todo Syntax:
//     public int CalculateArea() => Width * Height;  


Rectangle rectangle = new Rectangle(5,6);

class Rectangle
{

    public int Width;
    public int Height;

    public Rectangle(int width, int height)
    {
        this.Width = width;
        this.Height = height;    
    }


    // Med Expression-bodied method - !! husk !! KUN når der er ET statement el. expression
    public int CalculateCircumference() => 2 * Width + 2 * Height;

    public int CalculateArea() => Width * Height;





    public int CalculateCircumference1()
    {
        return 2 * Width + 2 * Height;      
    }

    public int CalculateArea1()
    {
        return Width * Height;              
    }
 }




