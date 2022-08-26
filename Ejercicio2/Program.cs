// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Ejercicio2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
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
            catch (OverflowException x)
            {
                Console.WriteLine($"\n{x}\nError detectado, el número asignado es muy grande");
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
            catch (FormatException x)
            {
                Console.WriteLine($"\n{x}\nError detectado, el valor asignado no es un número");
            }
            catch (OverflowException x)
            {
                Console.WriteLine($"\n{x}\nError detectado, uno de los números asignados es muy grande");
            }
            catch (DivideByZeroException x)
            {
                Console.WriteLine($"\n{x}\nNo es posible dividir en cero");
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
            catch (FormatException x)
            {
                Console.WriteLine($"\n{x}\nError detectado, uno de los valores asignados no es un número");
            }
            catch (OverflowException x)
            {
                Console.WriteLine($"\n{x}\nError detectado, uno de los números asignados es muy grande");
            }
*/
            //Problema 4: Consumo de API
            Console.WriteLine("\n\n/----------------CONSUMO DE API----------------/");

            try
            {
                var url = $"https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre";
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Accept = "application/json";

                Root info = null;

                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader != null)
                        {
                            using (StreamReader objReader = new StreamReader(strReader))
                            {
                                string texto = objReader.ReadToEnd();

                                info = JsonSerializer.Deserialize<Root>(texto);
                            }
                        }
                    }
                }

                if (info != null)
                {
                    Mostrar(info);
                }
            }
            catch (NotSupportedException)
            {
                Console.WriteLine($"\nError detectado");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine($"\nError detectado");
            }
            catch (System.Security.SecurityException)
            {
                Console.WriteLine($"\nError detectado");
            }
            catch (UriFormatException)
            {
                Console.WriteLine($"\nError detectado");
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"\nError detectado");
            }
            catch (ProtocolViolationException)
            {
                Console.WriteLine($"\nError detectado");
            }
            catch (WebException)
            {
                Console.WriteLine($"\nError detectado");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine($"\nError detectado");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine($"\nError detectado");
            }
            catch (IOException)
            {
                Console.WriteLine($"\nError detectado");
            }
            catch (JsonException)
            {
                Console.WriteLine($"\nError detectado");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine($"\nError detectado");
            }
        }

        private static void Mostrar(Root info)
        {
            for (int i = info.Inicio; i < info.Cantidad; i++)
            {
                Console.WriteLine($"\nId: {info.Provincias[i].Id}");
                Console.WriteLine($"Provincia: {info.Provincias[i].Nombre}");
            }
        }
    }
}