using System;

namespace Natural_counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca la cantidad de numeros naturales que desea capturar: ");
            int num = Convert.ToInt32(Console.ReadLine());
            NaturalCounter(num);
            Console.Read();
        }

        public static int NaturalCounter(int n)
        {
            int i;
            for (i = 1; i < n + 1; i++ )
            {
                Console.WriteLine(i);
            } 
            return i;
        }
    }
}
