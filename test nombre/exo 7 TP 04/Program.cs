using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exo_7_TP_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre, resultat = 1;
            Console.WriteLine(" saisir un nombre");
            nombre = Convert.ToInt32(Console.ReadLine());
            Console.Write("1");

            for (int i = 2; i <= nombre; i++)
            {
                Console.Write("+{0} ", i);
                resultat = resultat + i;
            }
            Console.Write("= {0} ", resultat);
            Console.ReadLine();

        }
    }
}
