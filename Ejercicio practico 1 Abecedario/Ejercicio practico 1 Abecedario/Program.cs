using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_practico_1_Abecedario
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abecedario
            // [A,B,C,D,..........]
            // A = 4
            // E = 3
            // I = 1
            // O = 0
            // U = 7
            // Arreglo 10 x 10
            // Random para elegir el numero del index del abecedario
            // random dentro de for para llenar la matriz
            // llenar el arreglo con caracteres aleatorios
            // |X|_|_|_|_|_|_|_|_|_|
            // |_|I|_|_|_|_|_|_|_|_|
            // |_|_|A|_|_|_|_|_|_|_|
            // |_|_|_|B|_|_|_|_|_|_|
            // |_|_|_|_|C|_|_|_|_|_|

            //instancia de objeto tipo random
            Random rnd = new Random();

            //matrix declaration
            string[,] matrixstring;

            //matrix asignation
            matrixstring = new string[10, 10];

            //string array declaration
            string[] abc;

            //string array asignation
            abc = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };


            //MATRIX BUILDER
            for (int i= 0; i < 10; i++)
            {
                //row for cycle
                for (int j = 0; j < 10; j++)
                {
                    //int declaration and asigned by a random number
                    //random number from 0 to abc.length
                    int numAleatorio = rnd.Next(abc.Length);

                    //assigning values ​​to string type matrix from random number as index on abc array
                    matrixstring[i, j] = abc[numAleatorio];
                }
            }
            //MATRIX PRINTER
            for (int i = 0; i < 10; i++)
            {
                //for cycle body 
                for (int j = 0; j < 10; j++)
                {
                    //printing matrix
                    Console.Write(matrixstring[i, j] + ",");
                }
                //printing line matrix
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
