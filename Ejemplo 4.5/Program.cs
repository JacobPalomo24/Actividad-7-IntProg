using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_4._5{
    class Program{
        static void Main(string[] args) {
            double SU = 0; 

            Console.Write("Ingresa una estatura: ");
            double ES = double.Parse(Console.ReadLine());

            int C = 0;
            while(ES > 0){
                SU += ES;
                Console.Clear();
                Console.Write("Ingresa otra estatura: ");
                ES = double.Parse(Console.ReadLine());
                C++;
            }

            if(C == 0){
                Console.Clear();
                Console.WriteLine("No hay estaturas");
            } else{
                double PR = SU / C;
                Console.Clear();
                Console.WriteLine("El promedio de las estaturas es: " + PR);
            }

            Console.Write("\nPara salir presiona culquier tecla...");
            Console.ReadKey(true);
        }
    }
}
