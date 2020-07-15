using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notas = new int[30];
            int nota_maxima=0;
            int nota_minima=25;
            int np=0;
            int nr=0;
            int suma_total;
            int numero;
            int m;


            for (int i = 0; i <= 29; i++) 
            {
                Console.WriteLine("ingrese el tamaño del vector: ");
                numero = int.Parse(Console.ReadLine());
                int[] total = new int[numero];
                suma_total = 0;
                
                for (int i= 0; i< numero; i++) 
                {
                    Console.WriteLine("escriba un numero");
                    m = int.Parse(Console.ReadLine());
                    total[i] = m;
                    if((total[i] > total[0] & (total[i] < 25))
                        {
                        Random random = new Random();
                        int numrandom = random.Next(1, 26);
                        notas[i] = numrandom;
                        if (notas[i] < 10) 
                        
                        {
                            nr++;
                        }
                        if (notas[i] > nota_maxima) 
                        {
                            nota_maxima = notas[i];
                            suma_total = notas[i];
                        }
                        np = suma_total / notas.Length;
                        Console.WriteLine("la nota  mas lata es: " + nota_maxima);
                        Console.WriteLine("la nota mas baja es: "+nota_minima)
                    }
                

                }

            }


        }
    }
}
