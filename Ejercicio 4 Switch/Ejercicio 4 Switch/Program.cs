using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//declaracion enum colección o listado de constantes
public enum Color {Red,Green,Blue};
namespace Ejercicio_4_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //creación (instancia) objeto C
            Color c = (Color)(new Random()).Next(0, 3);
            switch (c)
            {
                //cuerpo de la estructura switch
                case Color.Red:
                    Console.WriteLine("The color is Red");
                    break;
                case Color.Green:
                    Console.WriteLine("The color is Green");
                    break;
                case Color.Blue:
                    Console.WriteLine("The color is Blue");
                    break;
                default:
                    Console.WriteLine("Color is unknown");
                    break;
                    Console.ReadKey();
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
