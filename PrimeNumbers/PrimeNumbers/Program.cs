using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Generate all prime numbers up to what number?");
            int x = int.Parse(Console.ReadLine());
            int j;

            for (int i = 1; i <= x; i++)
            {
                int counter = 0;
                for (j = 2; j <= i/2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}