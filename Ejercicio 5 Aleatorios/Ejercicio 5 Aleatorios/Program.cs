using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5_Aleatorios
{
    class Program
    {
        static void Main(string[] args)
        {
            //instancia de objeto tipo random
            Random rnd = new Random();
            int limite = 10;
            for (int i = 0; i <=limite;i++)
            {
                int numAleatorio = rnd.Next(limite);
                Console.WriteLine("El número generado aleatoriamente es " + numAleatorio);
            }
            Console.ReadKey();
        }
    }
}
