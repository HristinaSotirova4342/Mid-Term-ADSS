using System;

namespace zadaca3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = new string[7];

            Console.WriteLine("Input string in the array :");
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = Console.ReadLine();
            }

          

            var shortString = array1[0];
        
            foreach (var t in array1)
            {
                if (shortString.Length > t.Length)
                    shortString = t;
            }

           

                Console.WriteLine("Shortest string is:" + shortString);
            Console.Read();
        }
    }
}

