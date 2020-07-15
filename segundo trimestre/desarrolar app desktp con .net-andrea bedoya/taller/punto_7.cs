using System;
using System.Diagnostics.CodeAnalysis;

namespace punto._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int v, n, suma;
            Console.WriteLine("ingrese el tamaño del vector");
            v = int.Parse(Console.ReadLine());
            int[] totales = new int[v];
            suma = 0;
            for (int i = 0; i < v; i++) 
            {
                Console.WriteLine("escriba un numero");
                n = int.Parse(Console.ReadLine());
                totales[i] = n;

                if ((totales[i]>totales[0] & totales[i] > 25))
                {
                    suma = suma + totales[i];
                    Console.WriteLine(totales[i]);
                }
                            
            }

            Console.WriteLine("el vector es: ");
            for(int i=0; i<v; i++) 
            {
                Console.WriteLine(totales[i]);
            }
            Console.WriteLine("el total de los elementos sumados es: " + suma);
        }
    }
}
