using System;

namespace TALLER
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[5];

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("ingrese un numero");
                int numero;

                numero = int.Parse(Console.ReadLine());
                arreglo[i] = numero;

            }
            Console.WriteLine("LOS NUMEROS INGRESADOS SON: ");

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(arreglo[i]);
            }

        }
    }
}
