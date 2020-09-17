using System;

namespace Primes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Favor introducir hasta que valor desea ver numeros primos: ");
            int resp = Convert.ToInt32(Console.ReadLine());
            PrimeNumbers(resp);
            Console.Read();
        }

        public static void PrimeNumbers(int num)
        {
            for (int i = 1; i < num + 1; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("Prime:" + i);
                }
            }
        }
    }
}
