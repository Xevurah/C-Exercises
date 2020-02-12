using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6_Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaración arreglo de la clase String
            String[] friendNames = { "Todd Anthony", "Kevin Holton", "Shane Laigla","Alfonso"};
            int i;
            Console.WriteLine($"Here are {friendNames.Length} " + "of my friends");
            for (i=0;i<friendNames.Length;i++)
            {
                //cuerpo del ciclo for
                Console.WriteLine(friendNames[i]);
            }
            Console.ReadKey();
        }
    }
}
