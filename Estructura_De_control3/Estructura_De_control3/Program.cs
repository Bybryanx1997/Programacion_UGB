using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_De_Control3
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 1;

            while (p == 1)
            {

                double R, HH, Area, Volumen;
                Console.Write("Valor de Radio: ");
                R = float.Parse(Console.ReadLine());
                Console.Write("Valor de H: ");
                HH = float.Parse(Console.ReadLine());
                Area = (2 * 3.1416) * (R * (HH + R));
                Volumen = 3.1416 * (R * R) * HH;
                Console.Write("");
                Console.Write("El are es de: " + Area + " Y su volumen es de: " + Volumen);
                Console.Write("\n");
                Console.Write("Escriba -Y- si quiere seguir con el procesos y -N- si no ");
                p = int.Parse(Console.ReadLine());

            }
            Console.ReadLine();
        }
    }
}