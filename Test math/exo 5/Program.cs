using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exo_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("saisit un nombre");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("saisit un nombre");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(is_double(a,b));
            Console.ReadLine();

        }
        static bool is_double(int nombre, int nombre2)
        {
            int leDouble,leDouble2;
            bool retour;
            leDouble = nombre * 2;
            leDouble2 = nombre2 * 2;
            if ( leDouble == nombre2 || leDouble2 == nombre)
            {
                retour = true;
                return retour ;
            }
            else
            {
                retour = false;
                return retour;
            }
        }
    }
}
