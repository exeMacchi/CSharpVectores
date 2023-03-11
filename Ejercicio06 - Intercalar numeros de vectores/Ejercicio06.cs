using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06___Intercalar_numeros_de_vectores
{
    internal class Ejercicio06
    {
        static void Main(string[] args)
        {
            /* 
               6. Escriba un programa que genere 2 vectores con 20 enteros al azar cada 
                  uno (del 1 al 10) y cree un tercer vector de 40 elementos que sea el 
                  resultado de intercalar los dos vectores anteriores (subíndice por 
                  subíndice). Mostrar todos los vectores. 
           */

            Random random = new Random();
            int[] vNumeros1 = new int[20];
            int[] vNumeros2 = new int[20];
            int[] vIntercalado = new int[40];
            int indice = -1;

            // Vectores
            for (int i = 0; i < 20; i++)
            {
                vNumeros1[i] = random.Next(1, 11);
                vNumeros2[i] = random.Next(1, 11);
            }

            // Vector intercalado
            for (int i = 0; i < 20; i++)
            {
                indice++;
                vIntercalado[indice] = vNumeros1[i];
                indice++;
                vIntercalado[indice] = vNumeros2[i];
            }


            // Resultados
            for (int i = 0; i < 20; i++)
            {
                Console.Write(vNumeros1[i] + " " + vNumeros2[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < 40; i++)
            {
                Console.Write(vIntercalado[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
