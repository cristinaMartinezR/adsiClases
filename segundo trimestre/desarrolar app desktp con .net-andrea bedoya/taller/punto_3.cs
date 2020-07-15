using System;

namespace PUNTO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[10];
            int suma = 0;

            for (int i = 3; i <= 30; i += 3) 
            {
                int numero;
                numero = i;
                suma = suma + numero;

                for (int j =0; j <= 10; j++) 
                {
                    arreglo[j] = numero;
                    Console.WriteLine(arreglo[j]);
                    break;
                }
                
            }
            Console.WriteLine("la suma es:" + suma);
        }
    }
}
