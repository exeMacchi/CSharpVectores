using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04___Suma_de_vectores
{
    internal class Ejercicio04
    {
        static void Main(string[] args)
        {
            /* 
                4. Escriba un programa que genere 2 vectores con 20 enteros al azar cada 
                   uno (del 1 al 9) y cree un tercer vector que guarde las suma de ambos 
                   (subíndice por subíndice). 
            */

            Random random = new Random();
            int[] vNumeros1 = new int[20];
            int[] vNumeros2 = new int[20];
            int[] vSuma = new int[20];

            for (int i = 0; i < 20; i++)
            {
                vNumeros1[i] = random.Next(1, 10);
                vNumeros2[i] = random.Next(1, 10);
                vSuma[i] = vNumeros1[i] + vNumeros2[i];
            }

            // Primer vector
            for (int i = 0; i < 20; i++)
            {
                Console.Write(vNumeros1[i] + " ");
            }
            Console.WriteLine();

            // Segundo vector
            for (int i = 0; i < 20; i++)
            {
                Console.Write(vNumeros2[i] + " ");
            }
            Console.WriteLine();

            // Tercer vector (suma)
            for (int i = 0; i < 20; i++)
            {
                Console.Write(vSuma[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
