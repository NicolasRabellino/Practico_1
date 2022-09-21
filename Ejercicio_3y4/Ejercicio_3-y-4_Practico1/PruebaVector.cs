using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_y_4_Practico1
{
    class PruebaVector
    {
        private double[] A;//Declaramos un vector A
        private double[] B;//Declaramos un vector B
        private double[] C;//Declaramos un vector C
        private double[] CC;
        private double D;

        public virtual void Cargar()
        {
            Console.Write("Ingrese la longitud de los vectores a sumar: ");
            string linea;
            linea = Console.ReadLine();
            int n = int.Parse(linea);
            A = new double[n];
            B = new double[n];
            C = new double[n];
            CC = new double[n];
            Console.WriteLine("Ingresando valores al vector A");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("Ingrese componente [" + (i + 1) + "]: ");
                linea = Console.ReadLine();
                A[i] = double.Parse(linea);
            }
            Console.WriteLine("Ingresando valores al vector B");
            for (int j = 0; j < B.Length; j++)
            {
                Console.Write("Ingrese componente [" + (j + 1) + "]: ");
                linea = Console.ReadLine();
                B[j] = double.Parse(linea);
            }
            //Suma vectores
            for (int i = 0; i < A.Length; i++)
            {
                C[i] = A[i] + B[i];
                CC[i] = A[i] - B[i];
            }
        }

        public void Visualizar()
        {
            Console.WriteLine("La suma de los vecores es: ");
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine("[" + C[i] + "] ");
            }
            Console.WriteLine("");

            Console.WriteLine("La resta de los vectores es: ");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("[" + CC[i] + "] ");
            }
            Console.WriteLine("");
        }

        public void distancia()
        {
            for (int i = 0; i < A.Length; i++)
            {
                D = D + (double)Math.Pow(A[i] - B[i], 2);
            }

            D = Math.Sqrt(D);

            Console.WriteLine("");
            Console.WriteLine("La distancia entre los puntos de los vectores asociados es: " + D);
        }
    }
}
