using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exo_5_TP_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre, resultat, i;
            Console.WriteLine(" saisir un nombre");
            nombre = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" table de {0}",nombre);
            i = 1;
            while(i <= 10)
            {
                resultat = nombre * i;
                Console.WriteLine("{0} * {1} = {2}", nombre, i , resultat);
                i = i + 1;
            }
            Console.ReadLine();
            
        }
    }
}
