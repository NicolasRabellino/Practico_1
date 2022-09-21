using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class horasmath
    {

        DateTime hora = Convert.ToDateTime("21:13:0");
        DateTime hora1 = Convert.ToDateTime("10:20:20");
        DateTime horaComparar;
        DateTime horasSumada;

        public void sumar()
        {

            Console.Write("sume segundos: ");
            int num = Int32.Parse(Console.ReadLine());
            hora = hora.AddSeconds(num);
            Console.WriteLine(hora);

            Console.Write("sume minutos: ");
            num = Int32.Parse(Console.ReadLine());
            hora = hora.AddMinutes(num);
            Console.WriteLine(hora);


            Console.Write("sume horas: ");
            num = Int32.Parse(Console.ReadLine());
            hora = hora.AddHours(num);
            Console.WriteLine(hora);

            Console.Write("sume dias: ");
            num = Int32.Parse(Console.ReadLine());
            hora = hora.AddDays(num);
            Console.WriteLine(hora);

            Console.Write("sume mes: ");
            num = Int32.Parse(Console.ReadLine());
            hora = hora.AddMonths(num);
            Console.WriteLine(hora);

            Console.Write("sume año: ");
            num = Int32.Parse(Console.ReadLine());
            hora = hora.AddYears(num);
            Console.WriteLine("Fecha Final: " + hora);

        }
        public void mostrar()
        {
            Console.WriteLine("Primera hora: " + hora);
            Console.WriteLine("Segunda hora: " + hora1);
        }
        public void comparar()
        {
            if (hora.CompareTo(hora1) > 0)
            {

                horaComparar = hora.AddSeconds(-hora1.Second);
                horaComparar = hora.AddMinutes(-hora1.Minute);
                horaComparar = hora.AddHours(-hora1.Hour);



                Console.WriteLine("Hora Comparada: " + horaComparar.Hour + ":" + horaComparar.Minute + ":" + horaComparar.Second);
            }
            else if (hora.CompareTo(hora1) < 0)
            {
                horaComparar = hora1.AddSeconds(-hora.Second);
                horaComparar = hora1.AddMinutes(-hora.Minute);
                horaComparar = hora1.AddHours(-hora.Hour);



                Console.WriteLine("Hora Comparada: " + horaComparar.Hour + ":" + horaComparar.Minute + ":" + horaComparar.Second);
            }
            else
            {
                Console.WriteLine("No hay diferencia entre ambas fechas");
            }
        }
        public void sumarhoras()
        {
            horasSumada = hora.AddSeconds(hora1.Second);
            horasSumada = hora.AddMinutes(hora1.Minute);
            horasSumada = hora.AddHours(hora1.Hour);


            Console.WriteLine("Horas Sumadas: " + horasSumada);

        }
    }

}
