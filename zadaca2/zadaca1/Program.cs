using System;

namespace zadaca1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int p, lasti = 0, x;
            Console.WriteLine("Enter number of rows : ");
            x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                for (p = 1; p <= i; p++)
                {
                    if (lasti == 1)
                    {
                        Console.Write("0");
                        lasti = 0;
                    }
                    else if (lasti == 0)
                    {
                        Console.Write("1");
                        lasti = 1;
                    }
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        
    }
    }
}
