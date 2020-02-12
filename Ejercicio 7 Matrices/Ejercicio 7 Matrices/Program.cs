using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7_Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int variable = 1;
            int[,] matriz = new int[3, 3];
            for (int i = 0; i < 3; i++)//ciclo de llenado
            {
                //cuerpo del ciclo for
                for (int j = 0; j < 3; j++)
                {
                    //cuerpo de ciclo for
                    matriz[i, j] = variable;
                    variable++;
                }
            }
            for (int i = 0; i < 3; i++)//ciclo para iprimir
            {
                //cuerpo del ciclo for
                for (int j = 0; j < 3; j++)
                {
                    //cuerpo de ciclo for
                    Console.WriteLine(matriz[i, j] + ",");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
