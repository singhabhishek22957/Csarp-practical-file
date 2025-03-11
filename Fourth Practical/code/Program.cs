class Program
{
    static void Main()
    {
        Console.Write("Enter radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        Shape circle = new Circle(radius);
        Console.WriteLine("Area of Circle: " + circle.CalculateArea());

        Console.Write("Enter length of the rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter width of the rectangle: ");
        double width = Convert.ToDouble(Console.ReadLine());
        Shape rectangle = new Rectangle(length, width);
        Console.WriteLine("Area of Rectangle: " + rectangle.CalculateArea());
    }
}