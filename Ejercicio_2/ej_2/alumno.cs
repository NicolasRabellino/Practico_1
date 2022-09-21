using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej_2
{
    internal class alumno
    {
        private string nombreAlumno;
        private int edadAlumno;

        public alumno()
        {
            this.nombreAlumno = "nada";
            this.edadAlumno = 0;
        }
        public alumno(string nombreAlumno, int edadAlumno)
        {
            this.nombreAlumno = nombreAlumno;
            this.edadAlumno = edadAlumno;
        }
        public void getNombreEdad()
        {
            Console.WriteLine("Nombre: " + nombreAlumno + " - Edad: " +edadAlumno);
        }
        public void getNombre()
        {
            Console.WriteLine("Nombre: " + nombreAlumno);
        }
    }
}
