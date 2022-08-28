// See https://aka.ms/new-console-template for more information
using System;

namespace Ejercicio3 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("\nIngrese la cantidad de empleados: ");
                int cantidad = Convert.ToInt32(Console.ReadLine());

                var listaEmpleados = new List<Empleado>();

                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine($"\nEmpleado {i + 1}");

                    Console.WriteLine("Datos personales:");
                    Console.WriteLine("Apellido: ");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Fecha de nacimiento:");
                    Console.WriteLine("Día: ");
                    int dia = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Mes: ");
                    int mes = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Año: ");
                    int anio = Convert.ToInt32(Console.ReadLine());
                    string fecha = Convert.ToString(new DateOnly(anio, mes, dia));
                    Console.WriteLine("Sexo (hombre: H, mujer, M): ");
                    char sexo = Console.ReadLine()[0];
                    Console.WriteLine("Estado civil (soltero: S, en pareja: P, casado: C, viudo: V): ");
                    char civil = Console.ReadLine()[0];

                    var personal = new DatosPersonales(apellido, nombre, fecha, sexo, civil);

                    Console.WriteLine("Dirección:");
                    Console.WriteLine("Calle: ");
                    string calle = Console.ReadLine();
                    Console.WriteLine("Número: ");
                    int numero = Convert.ToInt32(Console.ReadLine());

                    var direc = new Direccion(calle, numero);

                    Console.WriteLine("Fecha de ingreso a la empresa:");
                    Console.WriteLine("Día: ");
                    dia = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Mes: ");
                    mes = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Año: ");
                    anio = Convert.ToInt32(Console.ReadLine());
                    fecha = Convert.ToString(new DateOnly(anio, mes, dia));

                    Console.WriteLine("Cargo que ocupa en la empresa: ");
                    string carg = Console.ReadLine();
                    Console.WriteLine("Suledo básico: ");
                    float sueldo = Convert.ToSingle(Console.ReadLine());

                    var profesional = new DatosProfesionales(carg, sueldo);

                    var emple = new Empleado(personal, direc, fecha, profesional);

                    listaEmpleados.Add(emple);

                }

                int j = 1;
                foreach (var item in listaEmpleados)
                {
                    Console.WriteLine($"\nEmpleado {j}");
                    Console.WriteLine($"Nombre completo: {item.DatPer.Apellido} {item.DatPer.Nombre}");
                    Console.WriteLine($"Edad: {item.CalcularEdad()} años");
                    Console.WriteLine($"Antiguedad: {item.CalcularAtiguedad()}");
                    Console.WriteLine($"Salario: {item.CalcularSalario()}");
                    j++;
                }
            }
            catch (IOException)
            {
                Console.WriteLine("\nError detectado, ha ocurrido un error de Entrada/Salida");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("\nError detectado, no hay suficiente espacio de memoria para continuar la ejecución del programa");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("\nError detectado, el valor de un argumento sobrepasa el rango límite definido");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nError detectado, el formato de un argumento es inválido");
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nError detectado, una operación aritmética, de casteo o conversión ha sufrido una sobrecarga");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("\nError detectado, se ha pasado un valor nulo a un método que no acepta valores nulos");
            }
        }
    }
}