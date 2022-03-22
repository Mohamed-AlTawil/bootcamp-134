

namespace Prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Determine whether the number entered by the user is prime or not

            Console.WriteLine("Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool check = true;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    check = false;  
                    break;
                }
            }

            if (check)
            {
                Console.WriteLine(num +": is a prime number ");
            }
            else
            {
                Console.WriteLine(num + ": is not a prime number ");
            }

        }
    }
}