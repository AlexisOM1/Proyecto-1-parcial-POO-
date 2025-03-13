using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // 1. Se define el arreglo con los numeros definidos 

            Console.WriteLine("Arreglo inicial:");
            ImprimirArreglo(numeros); // Se imprime el primer arreglo

            numeros[2] = 99; // 2. Se cambia el indice 2 (tercer elemento) por 99

            Console.WriteLine("\nArreglo después de modificar el tercer elemento:");
            ImprimirArreglo(numeros);// Se imprime el nuevo arreglo después de la modificación

            int suma = 0; // 3. Se inicializa una variable para almacenar la suma tomando en cuenta el primer indice que es 0

            foreach (int num in numeros) // Se recorre el arreglo sumando cada elemento a la variable suma
            {
                suma += num;
            }

            Console.WriteLine("\nLa suma de los elementos del arreglo es: " + suma); // Se imprime la suma de los elementos del arreglo
 
            int numeroBuscado = 4; // 4. Se define que numero se va a buscar

            int indice = Array.IndexOf(numeros, numeroBuscado);// Se usa Array.IndexOf para encontrar el índice del número buscado

            if (indice != -1) // Se  usa el ciclo if para verificar si el número fue encontrado
            {
                // Se imprime el índice en el que se encontró el número
                Console.WriteLine("\nEl número " + numeroBuscado + " se encuentra en el índice: " + indice);
            }
            else
            {
                // Se imprime un mensaje si el número no fue encontrado
                Console.WriteLine("\nElemento no encontrado");
            }
        }
        static void ImprimirArreglo(int[] arreglo) // Método para imprimir los elementos de un arreglo
        {
            // Se recorre el arreglo e imprime cada elemento separado por un espacio
            foreach (int num in arreglo)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine(); // Se imprime una línea en blanco para mejorar la presentación en consola
        }
    }
}

