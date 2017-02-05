using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        while (true)
        {
            Console.WriteLine("Enter two numbers to add: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int sum = x + y;
            Console.WriteLine("The sum of " + x + " & " + y + " is: " + sum);
        }
    }
}