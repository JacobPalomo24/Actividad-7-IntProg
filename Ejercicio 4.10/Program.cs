using System;

namespace Ejercicio_4._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int SH = 0;

            Console.Write("Ingresa el Pago por Hora: ");
            double PH = double.Parse(Console.ReadLine());

            int D = 1;

            do
            {
                Console.Write("Ingresa las horas trabajadas del día: ");
                int HT = int.Parse(Console.ReadLine());
                SH += HT;
                D++;
            } while (D > 6);

            double SU = SH * PH;

            Console.WriteLine("Las horas trabajadas son: " + SH);
            Console.WriteLine("El sueldo es: " + SU);

            Console.Write("\nPresiona cualquier tecla para salir...");
            Console.ReadKey(true);

        }
    }
}
