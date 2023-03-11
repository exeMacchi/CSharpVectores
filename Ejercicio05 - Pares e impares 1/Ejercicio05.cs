using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05___Pares_e_impares_1
{
    internal class Ejercicio05
    {
        static void Main(string[] args)
        {
            /* 
                5. Escriba un programa que genere un vector de 30 números al azar (del 1 
                   al 10), lo muestre y cuente la cantidad de números pares e impares. 
                   Mostrar los resultados. 
            */

            Random random = new Random();
            int[] vNumeros = new int[30];
            int contadorPares = 0, contadorImpares = 0;

            for (int i = 0; i < 30; i++)
            {
                vNumeros[i] = random.Next(1, 11);

                if (vNumeros[i] % 2 == 0)
                {
                    contadorPares++;
                }
                else
                {
                    contadorImpares++;
                }
            }

            for (int i = 0; i < 30; i++)
            {
                Console.Write(vNumeros[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine($"Cantidad de números pares: {contadorPares}");
            Console.WriteLine($"Cantidad de números impares: {contadorImpares}");
        }
    }
}
