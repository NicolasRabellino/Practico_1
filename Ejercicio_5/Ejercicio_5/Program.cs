using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primerarray = new int[5];
            int[] segundoarray = new int[5];
            int numero;
            Random rnd = new Random();

            for (int i = 0; i <= 4; i++)
            {
                numero = rnd.Next(0, 100);
                primerarray[i] = numero;

                numero = rnd.Next(0, 100);
                segundoarray[i] = numero;
            }

            Console.WriteLine("----- Resultados -----");

            for (int i = 0; i <= 4; i++)
            {   
                Console.Write("La suma de " + primerarray[i] + " y " + segundoarray[i] + " es: "); 
                numero = primerarray[i] + segundoarray[i];
                Console.WriteLine(numero);
            }

            Console.ReadKey();
        }
    }
}
