using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Generate fibonacci sequence up to what number?");
            int x = int.Parse(Console.ReadLine());
            int y = 1;
            int sum = 0;
            int z = 0;

            while (sum < x)
            {
                sum = y+z;
                if (sum<=x) {
                    Console.WriteLine(sum);
                }
                z = y;
                y = sum;
            }

        }
    }
}