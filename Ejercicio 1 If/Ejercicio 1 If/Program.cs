using System;
using static System.Console;
using static System.Convert;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_If
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter a character\n");

            //declaracion de variables y lectura de teclado
            char ch = (char)Read();

            if (Char.IsUpper(ch))
            {
                WriteLine("The character is an uppercase letter");
            }
            else if (Char.IsLower(ch))
            {
                WriteLine("The character is an lowercase letter");
            }
            else if (Char.IsDigit(ch))
            {
                WriteLine("The character is a number");
            }
            else {
                WriteLine("The character is not alphanumeric");
            }
            WriteLine("Press a key to continue... THX :D");
            ReadKey();
        }
    }
}
