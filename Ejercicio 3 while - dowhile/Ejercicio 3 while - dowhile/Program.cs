using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_while___dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo de ciclo while");
            //declaracion de variables
            int Contador1;
            //asignacion de valores
            Contador1 = 0;
            //uso del ciclo while 
            while (Contador1 < 5) {
                //cuerpo del ciclo while
                Console.WriteLine("El valor de la variable Contador1 es " + Contador1 );
                Contador1++;
            }

            Console.WriteLine("Ejemplo de ciclo do... while");
            //declaracion de variables
            int Contador2;
            //asignacion de valores
            Contador2 = 0;
            //uso del ciclo do... while
            do
            {
                Console.WriteLine("El valor de la variable Contador2 es " + Contador2);
                Contador2++;
            }
            while (Contador2 < 5);

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
