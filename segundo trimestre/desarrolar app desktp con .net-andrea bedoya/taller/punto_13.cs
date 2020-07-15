using System;

namespace punto_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dv = new int[365];
            int sdv = 0;
            int cv = 169;
            int fv = dv.Length - 100;
            Console.WriteLine("catidad de dias verano");
            for (int i =0; i <365; i++) 
            {
                dv[i] = (i + 1);

            }
            for (int i =cv;i< fv; i++) 
            {
                sdv = 1;
            }
            Console.WriteLine(sdv);
        }
    }
}
