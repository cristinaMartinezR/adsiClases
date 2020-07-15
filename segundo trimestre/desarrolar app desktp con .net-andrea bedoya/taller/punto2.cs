using System;

namespace punto_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[100];
            
            for(int i = 2; i <= 200; i = i+2) 
            {
                int num;
                num = i;

                for(int k=2; k<=100; k++)
                {
                    arreglo[k] = num;
                    Console.WriteLine(arreglo[k]);
                    break;
                
                }

            }


        }
    }
}
