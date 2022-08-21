using System;

namespace Ejercicios_Semana4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bryan Daniel Escobar Umanzor
            //Carlos Eduardo Mejía Luna
            int filas;
            Console.Write("Ingrese el número de registros (filas): ");
            filas = int.Parse(Console.ReadLine());

            int columnas;
            Console.Write("Ingrese el número de datos del registro (Columnas): ");
            columnas = int.Parse(Console.ReadLine());

            string[,] tabla = new string[filas, columnas];

            int registro;
            string continuar;

            for (int i = 0; i < filas; i++)
            {
                Console.WriteLine("_________________________________________");
                Console.Write("Registro " + i + "\n");
                Console.WriteLine("_________________________________________");

                for (int j = 0; j < columnas; j++)
                {

                    switch (j)
                    {
                        case 0:
                            Console.Write("Ingrese el nombre: ");
                            tabla[i, j] = Console.ReadLine();
                            break;
                        case 1:
                            Console.Write("Ingrese la carrera: ");
                            tabla[i, j] = Console.ReadLine();
                            break;
                        case 2:
                            Console.Write("Ingrese la facultad: ");
                            tabla[i, j] = Console.ReadLine();
                            break;
                        case 3:
                            Console.Write("Ingrese la edad: ");
                            tabla[i, j] = Console.ReadLine();
                            break;
                        case 4:
                            Console.Write("Ingrese la dirección email: ");
                            tabla[i, j] = Console.ReadLine();
                            break;
                        case 5:
                            Console.Write("Ingrese el número de télfeno: ");
                            tabla[i, j] = Console.ReadLine();
                            break;
                    }
                    Console.WriteLine("_________________________________________");
                }
            }
            continuar = "s";
            while (continuar == "s")
            {
                Console.Write("Ingrese el número de registro que desea consultar (fila): ");
                registro = int.Parse(Console.ReadLine());

                for (int k = 0; k < columnas; k++)
                {
                    switch (k)
                    {
                        case 0:
                            Console.Write("El nombre es: " + " | " + tabla[registro, k] + "\n");
                            break;
                        case 1:
                            Console.Write("La carrera es: " + " | " + tabla[registro, k] + "\n");
                            break;
                        case 2:
                            Console.Write("La facultad es: " + " | " + tabla[registro, k] + "\n");
                            break;
                        case 3:
                            Console.Write("La edad es: " + " | " + tabla[registro, k] + "\n");
                            break;
                        case 4:
                            Console.Write("La dirección email es: " + " | " + tabla[registro, k] + "\n");
                            break;
                        case 5:
                            Console.Write("El número de télefono es: " + " | " + tabla[registro, k] + "\n");
                            break;
                    }
                    Console.WriteLine("_________________________________________");
                }
                Console.Write("¿Desea consultar otro registro? Sí o No (S/N): ");
                continuar = Console.ReadLine();

            }

            Console.Write("¡EJECUCIÓN FINALLIZADA!");
            Console.ReadLine();


        }
    }
}
