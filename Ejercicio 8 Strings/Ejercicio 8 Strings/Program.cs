using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your first String");
            string cadenaUno = Console.ReadLine();//Escribir Hola
            Console.WriteLine("Type your second String");
            string cadenaDos = Console.ReadLine();//Escribir Mundo

            //Concatenación de cadenas
            string cadenaTres = cadenaUno + cadenaDos;
            Console.WriteLine("Join two Strings");
            Console.WriteLine(cadenaTres);

            //Extracción de carácteres
            Console.WriteLine("Extract string from position 2 to 6");
            Console.WriteLine(cadenaTres.Substring(2,6));

            //Reemplazo de carácteres
            Console.WriteLine("Replace Strings");
            Console.WriteLine(cadenaTres.Replace("Mundo","Todos"));

            //Indice de una palabra dentro de una cadena
            Console.WriteLine("IndexOf position of letter");
            int index = cadenaTres.IndexOf("M");
            Console.WriteLine(index);

            //Longitud
            Console.WriteLine("Lenght of String");
            Console.WriteLine(cadenaTres.Length);

            //Convertir a minúsculas
            Console.WriteLine("Convert to lower");
            Console.WriteLine(cadenaUno.ToLower());

            //Convertir a mayúsculas
            Console.WriteLine("Convert to Upper");
            Console.WriteLine(cadenaUno.ToUpper());

            //Comparacion de cadenas
            Console.WriteLine("String equals true or false");
            bool cadenasIguales = String.Equals(cadenaUno, cadenaDos);
            Console.WriteLine(cadenasIguales);
            cadenasIguales = String.Equals(cadenaUno, cadenaUno);
            Console.WriteLine(cadenasIguales);

            //Tratar cadena como un arreglo unidimensional
            Console.WriteLine("Use of String as array");
            for (int i = 0; i < cadenaTres.Length; i++)
            {
                //Cuerpo del ciclo for
                Console.WriteLine(cadenaTres[i]);
            }


            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
