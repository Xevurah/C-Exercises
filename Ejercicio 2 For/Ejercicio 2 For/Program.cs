using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_For
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variables
            int i;
            int j;

            //asignacion de valores
            j = 10;

            //ejemplo ciclo FOR
            for (i = 0, Console.WriteLine($"Start: i={i}, j={j}"); i < j; i++, j--,
                Console.WriteLine($"Step: i={i}, j={j}")) {
                //cuerpo del ciclo
            }
            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();
        }
    }
}
