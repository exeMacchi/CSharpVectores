using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07___Pares_e_impares_2
{
    internal class Ejercicio07
    {
        static void Main(string[] args)
        {
            /* 
                7. Escriba un programa que genere un vector de nombre «todos» con 30 
                   enteros al azar cada uno (del 1 al 10) y crear dos vectores llamados 
                   «par» e «impar» para guardar en el primero todos los números pares del 
                   vector «todos» y en el segundo, los impares. 
                   Mostrar todos los vectores. No debe mostrar «basura». 
            */

            Random random = new Random();
            int[] vTodos = new int[30];
            int[] vPares = new int[30];
            int[] vImpares = new int[30];
            int contadorPares = 0, contadorImpares = 0;

            // Proceso
            for (int i = 0; i < 30; i++)
            {
                vTodos[i] = random.Next(1, 11);

                if (vTodos[i] % 2 == 0)
                {
                    vPares[contadorPares] = vTodos[i];
                    contadorPares++;
                }
                else
                {
                    vImpares[contadorImpares] = vTodos[i];
                    contadorImpares++;
                }
            }

            // Resultados
            Console.Write("Todos: ");
            for (int i = 0; i < 30; i++)
            {
                Console.Write(vTodos[i] + " ");
            }
            Console.WriteLine();

            Console.Write("Números pares: ");
            for (int i = 0; i < contadorPares; i++)
            {
                Console.Write(vPares[i] + " ");
            }
            Console.WriteLine();

            Console.Write("Números impares: ");
            for (int i = 0; i < contadorImpares; i++)
            {
                Console.Write(vImpares[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
