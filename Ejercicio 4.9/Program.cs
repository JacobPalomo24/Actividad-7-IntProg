using System;

namespace Ejercicio_4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número: ");
            int n = int.Parse(Console.ReadLine());

            int a = 0, b = 1;
            Console.Write(a + ", ", b + ", ");

            int m = 1;

            while(m <= (n - 2))
            {
                int c = a + b;
                Console.Write(c + ", ");

                a = b;
                b = c;
                m++;
            }

            Console.Write("\n\nPresiona cualquier tecla para salir...");
            Console.ReadKey(true);
        }
    }
}
