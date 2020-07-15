using System;

namespace punto_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[0];
            int numd = 0;
            int sumapar = 0;

            for (int i = arreglo.Length - 1; i >= 0; i--) 
            {
                if (i == 0) 
                {
                    continue;
                }
                else if (arreglo[i] == 10) 
                {
                    numd++;
                    if (i % 2==0)
                    {
                        sumapar = arreglo[i];
                    }
                }
                else if (i%2==0)
                {
                    
                    Console.WriteLine(arreglo[i]);
                    
                }
            }
            Console.WriteLine("la cantidad de numeros iguales a diez es ;" + numd);
            Console.WriteLine("la suma de las pciciones pares es de ; " + sumapar);
        } 
    }
}
