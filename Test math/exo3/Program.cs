using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre;
            nombre = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(factorielle(nombre));
            Console.ReadLine();
        }                          

        static int factorielle(int nombre)
        {
            int resultat = 1;
            for(int i=1; i <= nombre;i ++)
            {
                resultat = resultat * i;
            }
        return resultat;
        }
    }
}
