using System;

public class Prism
{
    public double Width { get; set; }
    public double Height { get; set; }
    public double Depth { get; set; }

    public Prism(double width, double height, double depth)
    {
        Width = width;
        Height = height;
        Depth = depth;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the 3 dimensions of the prism:");
        while (true)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());

            Prism newPrism = new Prism(x, y, z);
            Console.WriteLine("The volume of the prism is: "+(x*y*z)+" cubic units");
            Console.WriteLine("The surface area of the prism is: "+((2*x*y)+(2*x*z)+(2*z*y))+" square units");
            if(x==y && y == z)
            {
                Console.WriteLine("This prism is a cube");
            }
            else
            {
                Console.WriteLine("This prism is not a cube");
            }
            Console.WriteLine();
            Console.WriteLine("Enter the three dimensions of the next prism:");
        }
    }
}