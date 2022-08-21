using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
{
    static void Main(string[] args)
    {
        float a;

        float b;

        float c;

        float h;

        int v;

        Console.Write("Número de veces que el programa se ejecutará: ");
        v = int.Parse(Console.ReadLine());

        for (int contador = 1; contador <= v; contador++)
        {
            Console.Write("Primer lado: \n");
            a = float.Parse(Console.ReadLine());

            Console.Write("Segundo lado: \n");
            b = float.Parse(Console.ReadLine());

            Console.Write("Base: \n");
            c = float.Parse(Console.ReadLine());

            Console.Write("Altura: \n");
            h = float.Parse(Console.ReadLine());

            float Area = (b * h) / 2;

            float perimetro = a + b + c;

            Console.Write("El area es de: " + Area + " El perimetro es de: " + perimetro);
            Console.Write("\n");
        }
        Console.Read();
    }
}

