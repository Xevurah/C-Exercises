using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_practico_3_operadores_de_vectores
{
    class Program
    {
        private int[] A;//Declaramos un vector A
        private int[] B;//Declaramos un vector B
        private int[] C;//Declaramos un vector C
        private int[] D;//Declaramos un vector D
        private int[] E;//Declaramos un vector E
        public void Cargar()
        {
            Console.Write("Ingrese la longitud de los vectores a multiplicar y luego sumar con un tercer vector: ");
            string linea;
            linea = Console.ReadLine();
            int n = int.Parse(linea);
            A = new int[n];
            B = new int[n];
            C = new int[n];
            D = new int[n];
            E = new int[n];
            Console.WriteLine("Ingresando valores al vector A");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("Ingrese componente [" + (i + 1) + "]: ");
                linea = Console.ReadLine();
                A[i] = int.Parse(linea);
            }
            Console.WriteLine("Ingresando valores al vector B");
            for (int j = 0; j < B.Length; j++)
            {
                Console.Write("Ingrese componente [" + (j + 1) + "]: ");
                linea = Console.ReadLine();
                B[j] = int.Parse(linea);
            }
            Console.WriteLine("Ingresando valores al vector D");
            for (int k = 0; k < D.Length; k++)
            {
                Console.Write("Ingrese componente [" + (k + 1) + "]: ");
                linea = Console.ReadLine();
                D[k] = int.Parse(linea);
            }
            for (int i = 0; i < A.Length; i++)
            {
                C[i] = A[i] * B[i];
            }
            for (int i = 0; i < C.Length; i++)
            {
                E[i] = C[i] + D[i];
            }
        }
        public void Visualizar()
        {
            Console.WriteLine("La multiplicacion y suma de los vectores es: ");
            for (int i = 0; i < E.Length; i++)
            {
                Console.Write("[" + E[i] + "] ");
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Program pv = new Program();
            pv.Cargar();
            pv.Visualizar();
        }
    }
}
