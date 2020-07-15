using System;
using System.Net.NetworkInformation;

namespace punto_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int vector, m, p, numero, promedio;
            Console.WriteLine("ingrese la cantidad de los vectores");
            vector = int.Parse(Console.ReadLine());
            int[]arreglo = new int[vector];
            m = 0;
           
            for (int i = 0; i < v; i++) 
            {
                Console.WriteLine("ingrese un numero");
                numero = int.Parse(Console.ReadLine());
                vector[i] = numero;
                promedio = promedio + numero;

                if (vector[i] > numero) 
                {
                    m = vector[i];
                    p = i;

                }
                for (int i=0;i<vector;i++)
                {
                    Console.WriteLine(vector[i]);
                }
                promedio = promedio / vector;
                Console.WriteLine("el promedio es" + promedio);
                Console.WriteLine("el numero mayor es " + m);



            }


            
                        
            
           

        }
    }
}
