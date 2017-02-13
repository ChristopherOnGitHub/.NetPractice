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
            Console.WriteLine("The volume of the prism is: "+(newPrism.Width*newPrism.Height*newPrism.Depth)+" cubic units");
            Console.WriteLine("The surface area of the prism is: "+((2*newPrism.Width*newPrism.Height)+(2*newPrism.Width*newPrism.Depth)+(2*newPrism.
                *newPrism.Height))+" square units");
            if(newPrism.Width==newPrism.Height && newPrism.Height == newPrism.Depth)
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