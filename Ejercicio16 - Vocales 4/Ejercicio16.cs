using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16___Vocales_4
{
    internal class Ejercicio16
    {
        static void Main(string[] args)
        {
            /* 
                16. Cree dos vectores paralelos de 12 elementos c/u. Uno llamado 
                    «vocales», que debe contener vocales, y el otro llamado «números» que 
                    contenga enteros del 1 al 10. Ambos generados al azar.
                    Hallar la sumatoria del vector «números» siempre y cuando su paralelo 
                    «vocales» contenga la letra «e». 
            */

            Random random = new Random();
            const int maxElementos = 12;
            int[] vNumeros = new int[maxElementos];
            char[] vVocales = new char[maxElementos];
            char[] vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };
            bool letraE = false;
            int sumatoria = 0;

            // Inicialización
            for (int i = 0; i < maxElementos; i++)
            {
                vNumeros[i] = random.Next(1, 11);

                int vocal = random.Next(0, 5);
                vVocales[i] = vocales[vocal];

                if (vVocales[i] == 'e')
                {
                    letraE = true;
                }
            }

            // Verificación si apareció o no la vocal 'e'
            if (letraE)
            {
                // Proceso y resultados

                // Lista números
                for (int i = 0; i < maxElementos; i++)
                {
                    Console.Write(vNumeros[i] + " ");
                    Console.Write(vVocales[i] + " ");
                    Console.WriteLine();
                }
                Console.WriteLine();

                // Números con vocal e paralela
                Console.Write("Números con vocal 'e' paralela: ");
                for (int i = 0; i < maxElementos; i++)
                {
                    if (vVocales[i] == 'e')
                    {
                        sumatoria += vNumeros[i];
                        Console.Write(vNumeros[i] + " - ");
                    }
                }
                Console.WriteLine($"\nSumatoria: {sumatoria}");
            }
            else
            {
                Console.WriteLine($"La vocal 'e' no apareció en la secuencia.");
            }
        }
    }
}
