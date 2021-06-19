using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserInput = int.Parse(Console.ReadLine());
            int Divisor = 0;
            
            for(int i =1; i <= UserInput; i++)
            {
                if (UserInput % i == 0)
                {
                    Divisor++;
                }
            }
            if (Divisor == 2)
            {
                Console.WriteLine("Prime Number");

            }
            else
            {
                Console.WriteLine("Not a prime number");
            }
        }
    }
}
