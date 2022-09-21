using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7_Practico1_Programacion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Remito remitoJuan = new Remito(6, 6, 8);
            Factura facturaOSE = new Factura(8, 8);
            FacturaLuz facturaLuzUTE = new FacturaLuz(8, 9);
            Municipal maldonado = new Municipal(7, 9);
            ReciboSueldo reciboSueldo = new ReciboSueldo(8, 21);

            Console.WriteLine("IMPRESORA");
            Console.WriteLine("");

            remitoJuan.Iimprimir();
            facturaOSE.Iimprimir();
            facturaLuzUTE.Iimprimir();
            maldonado.Iimprimir();
            reciboSueldo.Iimprimir();
            Console.ReadKey();
        }
    }
}
