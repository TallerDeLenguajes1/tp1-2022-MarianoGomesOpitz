// See https://aka.ms/new-console-template for more information
using System;

namespace Ejercicio2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema 1: Cuadrado de un número
            Console.WriteLine("\n\n/----------------CUADRADO----------------/");
            Console.WriteLine("\nIngresar un número para obtener un cuadrado");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"El cuadrado de {num} es: {num * num}");
            }
            catch (FormatException x)
            {
                Console.WriteLine($"\n{x}\nError detectado, el valor asignado no es un número");
            }

            //Problema 2: División de dos números
            Console.WriteLine("\n\n/----------------DIVISIÓN----------------/");
            try
            {
                Console.WriteLine("\nIngrese el dividendo");
                int dividendo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nIngrese el divisor");
                int divisor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"\nLa división de {dividendo} en {divisor} es: {dividendo / divisor}");
            }
            catch (FormatException y)
            {
                Console.WriteLine($"\n{y}\nError detectado, el valor asignado no es un número");
            }
            catch (DivideByZeroException z)
            {
                Console.WriteLine($"\n{z}\nNo es posible dividir en cero");
            }

            //Problema 3: Kilómetros y litros
            Console.WriteLine("\n\n/----------------KILÓMETROS Y LITROS----------------/");
            try
            {
                Console.WriteLine("\nIngrese los kilómetros recorridos");
                double kilo = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nIngrese la cantidad de litros gastados");
                double litro = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"\nLos {kilo} kilómetros recorridos por los {litro} litros gastados es: {kilo * litro}");
            }
            catch (FormatException p)
            {
                Console.WriteLine($"\n{p}\nError detectado, uno de los valores asignados no es un número");
            }

            //Problema 4:
        }
    }
}