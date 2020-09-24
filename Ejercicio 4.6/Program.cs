using System;

namespace Ejercicio_4._6{
    class Program{
        static void Main(string[] args){
            double AH = 0;

            int M = 0;

            do {
                Console.Write("\nIngresa una cantidad: ");
                int CA = int.Parse(Console.ReadLine());

                AH += CA;
                M++;

                Console.WriteLine("El ahorro del mes " + M + " es: " + AH);
            } while(M < 12);

            Console.WriteLine("\nEl ahorro final es: " + AH);

            Console.Write("\nPresiona culquier tecla para salir...");
            Console.ReadKey(true);
        }
    }
}
