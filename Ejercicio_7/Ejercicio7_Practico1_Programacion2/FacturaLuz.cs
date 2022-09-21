using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7_Practico1_Programacion2
{
    internal class FacturaLuz : Impresora
    {
        private int codigoPago;
        private int importe;

        public FacturaLuz()
        {
            this.codigoPago = 0;
            this.importe = 0;
        }

        public FacturaLuz(int codigoPago, int importe)
        {
            this.codigoPago = codigoPago;
            this.importe = importe;
        }

        public void setRemito(int codigoPago, int importe)
        {
            this.codigoPago = codigoPago;
            this.importe = importe;
        }

        public void Iimprimir()
        {
            Console.WriteLine("El codigo del pago es : " + this.codigoPago);
            Console.WriteLine("El importe de la factura de la luz fue: " + this.importe);
            Console.WriteLine("");
        }
    }
}
