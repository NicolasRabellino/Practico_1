using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7_Practico1_Programacion2
{
    internal class Remito : Impresora
    {
        private int cantBultos;
        private int fecha;
        private int numero;

        public Remito()
        {
            this.cantBultos = 0;
            this.fecha = 0;
            this.numero = 0;
        }

        public Remito(int cantBultos, int fecha, int numero)
        {
            this.cantBultos = cantBultos;
            this.fecha = fecha;
            this.numero = numero;
        }

        public void setRemito(int cantBultos, int fecha, int numero)
        {
            this.cantBultos = cantBultos;
            this.fecha = fecha;
            this.numero = numero;
        }

        public void Iimprimir()
        {
            Console.WriteLine("La cantidad de bultos en el remito es: " + this.cantBultos);
            Console.WriteLine("La fecha en la que se emitio el remito fue: " + this.fecha);
            Console.WriteLine("El número del remito es: " + this.numero);
            Console.WriteLine("");
        }


    }
}
