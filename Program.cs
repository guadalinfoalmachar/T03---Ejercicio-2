using System;

namespace T03_Eje2
{
    class T03_Eje2
    {
        static void Main()
        {
            int N = 26;
            double A = 15.6;
            char C = 'a';

            Console.WriteLine("Variable N = {0}", N);
            Console.WriteLine("Variable A = {0}", A);
            Console.WriteLine("Variable C = {0}", C);

            Console.WriteLine("La suma de N + A es {0}", N+A);
            Console.WriteLine("La diferencia de A - N es {0}", A-N);
            Console.WriteLine("El valor numérico del carácter {0} es {1}", C, (int)C);
            
            Console.WriteLine("Pulse cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}