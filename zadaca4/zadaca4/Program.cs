using System;

namespace zadaca4
{
    class Program
    {
        static float findPerimeter(float a,
                           float b, float c)
        {
            if (c < a + b)
            {
                c = (a * a) + (b * b);
                return c;
            } else
            {
                Console.WriteLine("Invalid");
            }
            return 0;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Input a = ");
           float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Input b = ");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Input c = ");
            float c = float.Parse(Console.ReadLine());

            Console.WriteLine("The perimetar "+ findPerimeter(a,b,c));
        }
    }
}
