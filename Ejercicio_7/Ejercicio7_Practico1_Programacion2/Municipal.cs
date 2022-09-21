using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7_Practico1_Programacion2
{
    internal class Municipal
    {
        private int importe;
        private int partida;

        public Municipal()
        {
            this.importe = 0;
            this.partida = 0;
        }

        public Municipal(int importe, int partida)
        {
            this.importe = importe;
            this.partida = partida;
        }

        public void setRemito(int importe, int partida)
        {
            this.importe = importe;
            this.partida = partida;
        }

        public void Iimprimir()
        {
            Console.WriteLine("El importe del municipal fue de : " + this.importe);
            Console.WriteLine("La partida del municipal es : " + this.partida);
            Console.WriteLine("");
        }
    }
}
