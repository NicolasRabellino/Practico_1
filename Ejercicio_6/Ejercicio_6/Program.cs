using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            horasmath hora = new horasmath();

            hora.mostrar();
            hora.sumarhoras();
            hora.comparar();
            Console.WriteLine("");
            hora.sumar();
            Console.ReadKey();
        }
    }


}
