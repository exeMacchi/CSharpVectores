using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14___Multiplicacion_de_vectores
{
    internal class Ejercicio14
    {
        static void Main(string[] args)
        {
            /* 
                14. Escriba un programa que genere un vector de 10 números al azar 
                    (del 1 al 9) y permita ingresar por teclado un número para 
                    efectuar el producto con el vector. El vector resultante deberá
                    ser uno nuevo y mostrarlo. 
            */

            Random random = new Random();
            int[] vNumeros = new int[10];
            int[] vProducto = new int[10];

            // Proceso
            Console.Write("Ingrese el número de producto del vector: ");
            int producto = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                vNumeros[i] = random.Next(1, 10);
                vProducto[i] = vNumeros[i] * producto;
            }

            // Resultados
            Console.WriteLine("Resultados: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{vNumeros[i]} * {producto} = {vProducto[i]}");
            }
            Console.WriteLine();
        }
    }
}
