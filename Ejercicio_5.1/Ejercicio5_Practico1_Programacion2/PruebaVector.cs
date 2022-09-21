using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adfEjercico5_Practico1_Programacion2
{
    class PruebaVector
     {

        Random rnd = new Random();
        private int[,] MatrizA;
        private int[,] MatrizB;
        private int[,] MatrizC;
        public void Cargar()
        {
            MatrizA = new int[10, 10];
            MatrizB = new int[10, 10];
            MatrizC = new int[10, 10];
            Console.WriteLine("Ingresando datos al matriz A");
            for (int i = 1; i <= 2; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    Console.Write("Ingrese posicion [" + i + "," + j + "]: ");
                    MatrizA[i, j] = rnd.Next(0, 100);
                    Console.WriteLine(MatrizA[i, j]);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Ingresando datos al matriz B");
            for (int i = 1; i <= 2; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    Console.Write("Ingrese posicion [" + i + "," + j + "]: ");
                    MatrizB[i, j] = rnd.Next(0, 100);
                    Console.WriteLine(MatrizB[i, j]);
                }
            }
            //Sumamos la matrizA y la MatrizB
            for (int i = 1; i <= 2; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    MatrizC[i, j] = MatrizA[i, j] + MatrizB[i, j];
                }
            }
            Console.WriteLine("");
        }
        // visualizamos la suma de las matrices
        public void visualizar()
        {
            Console.WriteLine("La suma de la MatrizA y MatrizB es :");
            for (int i = 1; i <= 2; i++)
            {
                Console.Write("\n");
                for (int j = 1; j <= 2; j++)
                {
                    Console.Write(MatrizC[i, j] + "  ");
                }
            }
        }
    }
}
