using adfEjercico5_Practico1_Programacion2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico5_Practico1_Programacion2
{
    class Program
    {
        static void Main(string[] args)
        {
            PruebaVector pv = new PruebaVector();
            pv.Cargar();
            
            pv.visualizar();
            Console.ReadKey();
        }
    }
}
