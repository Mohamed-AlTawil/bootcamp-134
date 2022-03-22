using System;

namespace Prime_Listing
{
    class Program
    {
        static void Main(string[] args)
        {
            // List all prime numbers from 1 to 10000

            bool check = true;
            int counter = 0;

            for (int i = 2; i < 10000; i++)
            {
                for (int j  = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                       check = false;
                        break;
                    }
                }
                if (check)
                {
                    Console.WriteLine(i);
                    counter++;
                }
                check = true;
            }
            Console.WriteLine("Count of Prime Number is "+ counter);
        }
    }
}