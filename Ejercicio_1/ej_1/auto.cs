using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej_1
{
    internal class auto
    {
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private string tapecieria;
        private string clima = "no";
        private string color;
        public auto()
        {
            this.ruedas = 4;
            this.largo = 3;
            this.ancho = 2;
            this.climatizador = false;
            this.tapecieria = "tela";
            this.color = "verde ";
        }
        public auto(double largo, double ancho, string color)
        {
            this.ruedas = 4;
            this.largo = largo;
            this.ancho = ancho;
            this.climatizador = false;
            this.tapecieria = "tela";
            this.color = color;

        }
        public void getInfoAuto()
        {
            Console.WriteLine("El auto "+color+" mide de largo " + largo + " y de " + ancho +" ancho." );
        }
        public void setThisExtras(bool climatizador, string tapecieria)
        {
            if (climatizador == true)
            {
                clima = "si";
            }
            this.tapecieria = tapecieria;

        }
        public void getExtra()
        {
            Console.WriteLine( clima + " tiene climatizador y tapecieria de " + tapecieria);
        }

    }
}
