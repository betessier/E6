using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exo_4_TP04
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre, i;
            i = 0;
            Console.WriteLine(" saisir un nombre");
            nombre  = Convert.ToInt32(Console.ReadLine());
            while (i < 10)
            {
                nombre = nombre + 1;
                i = i + 1;
                Console.WriteLine(nombre);
            }
            Console.ReadLine();
        }
    }
}
