using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre, i , somme;
            somme = 0;
            i = 0;
            while (i < 4)
            {
                Console.WriteLine("saisir un nombre");
                nombre = Convert.ToInt32(Console.ReadLine());
                somme = somme + nombre;
                i = i + 1;
            }
            Console.WriteLine("somme des nombres : {0}", somme);
            Console.ReadLine();

        }
    }
}
