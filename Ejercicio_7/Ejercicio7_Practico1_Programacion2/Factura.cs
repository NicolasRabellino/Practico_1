using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7_Practico1_Programacion2
{
    internal class Factura : Impresora
    {
        private int fecha;
        private int importe;

        public Factura()
        {
            this.fecha = 0;
            this.importe = 0;
        }

        public Factura(int fecha, int importe)
        {
            this.fecha = fecha;
            this.importe = importe;
        }

        public void setRemito(int fecha, int importe)
        {
            this.fecha = fecha;
            this.importe = importe;
        }

        public void Iimprimir()
        {
            Console.WriteLine("La fecha en la que se emitio la factura fue: " + this.fecha);
            Console.WriteLine("El importe de la factura fue: " + this.importe);
            Console.WriteLine("");
        }

    }
}
