using hu_mdk0202_lab1;

static void Main(string[] args)
{
    
    Circle circle = new Circle(5);
    Rectangle rectangle = new Rectangle(10, 20);

    
    Circle clonedCircle = (Circle)circle.Clone();
    Rectangle clonedRectangle = (Rectangle)rectangle.Clone();

        Console.WriteLine(clonedCircle);
    Console.WriteLine(clonedRectangle);
}

