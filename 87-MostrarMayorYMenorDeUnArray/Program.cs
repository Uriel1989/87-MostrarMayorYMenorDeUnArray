using System;

//Dado un array de números, muestra el mayor y el menor.

namespace _87_MostrarMayorYMenorDeUnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = { 4, 3, 7, 10, 100, 5, 7 };

            int maximo = valores[0];
            int minimo = valores[0];

            for (int i = 1; i < valores.Length; i++)
            {
                if (valores[i] > maximo)
                {
                    maximo = valores[i];
                }

                if (valores[i] < minimo)
                {
                    minimo = valores[i];
                }

            }

            Console.WriteLine("El valor minimo es: " + minimo);
            Console.WriteLine("El valor maximo es: " + maximo);
        }
    }
}
