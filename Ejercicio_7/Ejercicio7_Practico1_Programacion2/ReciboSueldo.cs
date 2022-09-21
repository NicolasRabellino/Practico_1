using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7_Practico1_Programacion2
{
    internal class ReciboSueldo
    {
        private int legajo;
        private int total;

        public ReciboSueldo()
        {
            this.legajo = 0;
            this.total = 0;
        }

        public ReciboSueldo(int legajo, int total)
        {
            this.legajo = legajo;
            this.total = total;
        }

        public void setRemito(int legajo, int total)
        {
            this.legajo = legajo;
            this.total = total;
        }

        public void Iimprimir()
        {
            Console.WriteLine("El legajo del recibo de sueldo es : " + this.legajo);
            Console.WriteLine("El total del recibo de sueldo es : " + this.total);
            Console.WriteLine("");
        }
    }
}
