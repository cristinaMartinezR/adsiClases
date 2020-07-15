using System;

namespace punto_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero_de_arreglos = { 14,12,6,25,34,23,5 };
            int[] regreso_arreglos = new int[numero_de_arreglos.Length];
            Console.WriteLine("valores invertidos de los datos");
             for (int i =numero_de_arreglos.Length -1;i>=0;1--)
            {
                regreso_arreglos[i] = numero_de_arreglos[i];
                Console.WriteLine(regreso_arreglos[i]);

            }


        }
    }
}
