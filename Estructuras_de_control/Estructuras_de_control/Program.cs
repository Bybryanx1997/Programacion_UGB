using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            int entero;
            string SoN;

            Console.Write("si quieres comvertir a minutos escriba -1-, si quieresconvertir a segundos escriba -2- ");
            SoN = (Console.ReadLine());

            Console.Write("Escriba la cantidad de horas que desea convertir : \n");
            entero = int.Parse(Console.ReadLine());
            if (SoN == "1")
            {
                Console.Write("El resultado en minutos es de: " + (entero * 60));
            }
            if (SoN == "2")
            {
                Console.Write("El resultado en segundos es de: " + (entero * 60 * 60));

            }
            Console.Read();
        }
    }
