using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exo_1_TP_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre, fois, resultat = 0;
            Console.WriteLine("on multiplie par : ");
            fois = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nombre : ");
            nombre = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= fois; i = i + 1)
            {
                resultat = resultat + nombre;
            }
            Console.WriteLine(resultat);
            Console.ReadLine();
        }
    }
}
