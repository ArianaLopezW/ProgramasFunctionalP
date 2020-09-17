using System;

namespace Prog_2
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.Write("Favor ingresar las veces que quiere repetir la secuencia: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++){
                Console.WriteLine(FibonacciCounter(i));
            }
            Console.Read();
        }

        public static int FibonacciCounter(int n)
        {
            int a = 0;
            int b = 1;
            
            for (int i = 0; i <n; i++)
            {
                int temp = a;
                a = b;
                b = temp + a;
            }
            return a;
        }
    }
}
