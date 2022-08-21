using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act1
{
    class Program
    {
        static void Main(string[] args)
        {
            int entero;
            double hora = 60;
            double seg = 3600;
            int horatotal;
            int entero3;
            int entero4;
            int area;
            int entero5;
            int entero6;
            int entero7;
            int perimetro;
            float LH;
            double pi = 3.1416;
            float r;
            Console.Write("*********Ejercicio1************* \n");
            Console.Write("Ingrese hora que desea convertir: ");
            entero = int.Parse(Console.ReadLine());
            Console.Write("La conversion es de: " + entero * 60 ); Console.Write("  horas " );
            Console.Write("\n");
            Console.Write("La conversion de segundos es de:" + hora * seg); Console.Write(" segundos" );
            Console.Write("\n");

            Console.Write("*********Ejercicio2************* \n");
            Console.Write("Ingrese la altura: ");
            entero3 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la base: ");
            entero4 = int.Parse(Console.ReadLine());
            Console.Write("La conversion es de: " + (entero3 * entero4) / 2);
            Console.Write("\n");

            Console.Write("*********Perimetro*************");
            Console.Write("\n");
            Console.Write("Ingrese A: ");
            entero5 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese B: ");
            entero6 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese C: ");
            entero7 = int.Parse(Console.ReadLine());
            Console.Write("La conversion es de: " + (entero5 + entero6 + entero7));
            Console.Write("\n");

            Console.WriteLine("**************************ejercicio 3**************************");


            Console.Write("ingrese el radio: \n");
            r = float.Parse(Console.ReadLine());

            Console.Write("ingrese la altura: \n");
            LH = float.Parse(Console.ReadLine());

            double AreaCilindro = (2 * pi) * r * (LH + r);

            double volumen = pi * (r * r) * LH;

            Console.Write("el area del cilindro es de: " + AreaCilindro + " y el volumen es de: " + volumen);

            Console.WriteLine("**************************ejercicio 4**************************");


            Console.Write("ingrese el primer valor: \n");
            float Primero = float.Parse(Console.ReadLine());

            Console.Write("ingrese la altura: \n");
            float segundo = float.Parse(Console.ReadLine());

            float suma = Primero + segundo;
            float resta = Primero - segundo;
            float division = Primero / segundo;
            float multi = Primero * segundo;

            Console.Write("la suma es de: " + suma + ", la resta es de: " + resta + ", la division es de: " + division + ", la multiplicacion es de: " + multi);

            Console.WriteLine("**************************ejercicio 5**************************");

            Console.Write("ingrese su nombre: \n");
            string nombre = Console.ReadLine();

            Console.Write("ingrese su edad: \n");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("ingrese el peso: \n");
            float peso = float.Parse(Console.ReadLine());

            Console.Write("ingrese la estatura: \n");
            float estatura = float.Parse(Console.ReadLine());

            Console.Write("tipo de sangre: \n");
            string TipoDeSangre = Console.ReadLine();

            Console.Write("--resumen de los datos--\n");
            Console.Write("nombre: " + nombre + " edad: " + edad + " peso: " + peso + " estatura: " + estatura + " tipo de sangre: " + TipoDeSangre);
            Console.Read();
        }
    }
}