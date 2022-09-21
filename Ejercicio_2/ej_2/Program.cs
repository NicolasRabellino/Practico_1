using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            alumno alumno1 = new alumno();
            alumno alumno2 = new alumno("Mateo", 16);
            alumno alumno3 = new alumno("Lisa", 18);

            alumno1.getNombre();
            alumno2.getNombre();
            alumno3.getNombreEdad();
            Console.ReadKey();
        }
    }
}
