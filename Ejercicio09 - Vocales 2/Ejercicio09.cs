using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09___Vocales_2
{
    internal class Ejercicio09
    {
        static void Main(string[] args)
        {
            /* 
                9. Escriba un programa que genere un vector de 30 vocales al azar, lo 
                   muestre, luego lo ordene de modo ascendente y vuelva a mostrarlo. 
                   Por último, cuente la cantidad de vocales «a», «e», «i», «o», «u» 
                   usando un vector contador cantvocales[5]={0}, donde la posición 0 esté
                   relacionada con la cantidad de vocales «a», la posición 1, con la «e»,
                   etcétera. 
            */

            Random random = new Random();
            char[] vSecuencia = new char[30];
            char[] vVocales = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int[] vContadorVocales = new int[] { 0, 0, 0, 0, 0 };

            // Proceso
            for (int i = 0; i < 30; i++)
            {
                int vocal = random.Next(0, 5);
                vSecuencia[i] = vVocales[vocal];

                if (vSecuencia[i] == 'a')
                {
                    vContadorVocales[0]++;
                }
                else if (vSecuencia[i] == 'e')
                {
                    vContadorVocales[1]++;
                }
                else if (vSecuencia[i] == 'i')
                {
                    vContadorVocales[2]++;
                }
                else if (vSecuencia[i] == 'o')
                {
                    vContadorVocales[3]++;
                }
                else if (vSecuencia[i] == 'u')
                {
                    vContadorVocales[4]++;
                }
            }

            // Mostrar secuencia original
            Console.Write("Secuencia original: ");
            for (int i = 0; i < 30; i++)
            {
                Console.Write(vSecuencia[i] + " ");
            }
            Console.WriteLine();

            // Ordenar de forma ascendente 
            for (int i = 0; i < 30; i++)
            {
                for (int x = 0; x < 29; x++)
                {
                    if (vSecuencia[x + 1] < vSecuencia[x])
                    {
                        char aux = vSecuencia[x];
                        vSecuencia[x] = vSecuencia[x + 1];
                        vSecuencia[x + 1] = aux;
                    }
                }
            }

            // Mostrar secuencia ordenada
            Console.Write("Secuencia ordenada: ");
            for (int i = 0; i < 30; i++)
            {
                Console.Write(vSecuencia[i] + " ");
            }
            Console.WriteLine();

            // Resultados
            Console.WriteLine();
            Console.WriteLine($"Cantidad de vocales a: {vContadorVocales[0]}");
            Console.WriteLine($"Cantidad de vocales e: {vContadorVocales[1]}");
            Console.WriteLine($"Cantidad de vocales i: {vContadorVocales[2]}");
            Console.WriteLine($"Cantidad de vocales o: {vContadorVocales[3]}");
            Console.WriteLine($"Cantidad de vocales u: {vContadorVocales[4]}");
        }
    }
}
